using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Threading;
using System.Reflection.Emit;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private static readonly string sr_AppSettingsFileName =
            $"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\\appSettings.xml";

        private readonly AppSettings r_AppSettings;
        private readonly string r_Like = "Like";
        private readonly string r_Unlike = "Unlike";
        private readonly string r_Login = "Login";
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_AppSettings = new AppSettings();
            r_AppSettings.LoadAppSettingsData(sr_AppSettingsFileName);
            checkBoxRememberUser.Checked = r_AppSettings.RememberUser;
            m_LoggedInUser = null;
            m_LoginResult = null;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FacebookFacade facade = new FacebookFacade();
            m_LoginResult = facade.Login(AppSettings.AppId, AppSettings.Permissions);
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (r_AppSettings.RememberUser && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                try
                {
                    FacebookFacade facade = new FacebookFacade();
                    m_LoginResult = facade.Connect(r_AppSettings.LastAccessToken);
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    fetchUserInfo();
                    buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Can't connect to facebook. Error: {exception.Message}");
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            saveAppSettings();
        }

        private void saveAppSettings()
        {
            r_AppSettings.RememberUser = checkBoxRememberUser.Checked;
            r_AppSettings.LastAccessToken = r_AppSettings.RememberUser && m_LoginResult != null ? m_LoginResult.AccessToken : null;
            r_AppSettings.SaveData(sr_AppSettingsFileName);
        }

        private void fetchUserInfo()
        {
            resetForm();
            pictureBoxProfilePic.LoadAsync(m_LoggedInUser.PictureNormalURL);
            DialogResult dialogResult = MessageBox.Show($"Would you like to observe business info? (to keep personal info press No.)", "Notifier", MessageBoxButtons.YesNo);
            IInfoBuilder infoBuilder = dialogResult == DialogResult.Yes ? (IInfoBuilder)new BusinessInfoBuilder() :
                (IInfoBuilder)new PersonalInfoBuilder();
            new Thread(fetchPosts).Start();
            new Thread(() => populateListBox(listBoxAlbumsList, m_LoggedInUser.Albums.ToList())).Start();
            InfoComposer infoComposer = new InfoComposer { InfoBuilder = infoBuilder };
            infoComposer.ConstructInfoPackets(m_LoggedInUser);
            new Thread(() => populateUIInfoFromInfoPackets(infoComposer.InfoBuilder.Info)).Start();
            fetchPages();
        }

        private void fetchPages()
        {
            pageBindingSource.DataSource = m_LoggedInUser.LikedPages;
        }

        private void populateUIInfoFromInfoPackets(Info i_Info)
        {
            label1About.Invoke(new Action(() => label1About.Text = i_Info.InfoPacket1.Label));
            textBox1About.Invoke(new Action(() => textBox1About.Text = i_Info.InfoPacket1.Info));
            label2About.Invoke(new Action(() => label2About.Text = i_Info.InfoPacket2.Label));
            textBox2About.Invoke(new Action(() => textBox2About.Text = i_Info.InfoPacket2.Info));
            label3About.Invoke(new Action(() => label3About.Text = i_Info.InfoPacket3.Label));
            textBox3About.Invoke(new Action(() => textBox3About.Text = i_Info.InfoPacket3.Info));
            label4About.Invoke(new Action(() => label4About.Text = i_Info.InfoPacket4.Label));
            textBox4About.Invoke(new Action(() => textBox4About.Text = i_Info.InfoPacket4.Info));
        }

        private void resetForm()
        {
            buttonLikePost.Enabled = false;
            buttonLikePhoto.Enabled = false;
        }

        private void listBoxAlbumsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchPhotosForSelectedAlbum();
        }

        private void listBoxPhotosList_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchPhotoFromSpecificAlbum();
        }

        private void textBoxSelectedPost_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();

            if (listBoxPostsList.SelectedItem != null)
            {
                try
                {
                    Post selected = m_LoggedInUser.Posts[listBoxPostsList.SelectedIndex];
                    textBoxSelectedPost.Text = selected.ToString();
                    populateListBox(listBoxCommentsPost, selected.Comments.ToList());
                    textBoxLikesCountPost.Text = random.Next(500).ToString();
                    buttonLikePost.Enabled = true;
                    buttonLikePost.Text = r_Like;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void populateListBox<T>(ListBox i_ListBox, List<T> i_Data) where T : class
        {
            i_ListBox.Invoke(new Action(() => i_ListBox.Items.Clear()));
            try
            {
                foreach (T currObj in i_Data)
                {
                    i_ListBox.Invoke(new Action(() => i_ListBox.Items.Add(currObj)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchPosts()
        {
            listBoxPostsList.Invoke(new Action(() => listBoxPostsList.Items.Clear()));
            try
            {
                foreach (Post currPost in m_LoggedInUser.Posts)
                {
                    listBoxPostsList.Invoke(new Action(() => listBoxPostsList.Items.Add(new PostProxy(currPost))));
                }

                if (listBoxPostsList.Items.Count == 0)
                {
                    MessageBox.Show("No Posts");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchPhotosForSelectedAlbum()
        {
            if (listBoxAlbumsList.SelectedItems.Count == 1)
            {
                listBoxPhotosList.Items.Clear();
                try
                {
                    Album selectedAlbum = listBoxAlbumsList.SelectedItem as Album;

                    if (selectedAlbum != null)
                    {
                        foreach (Photo currPhoto in selectedAlbum.Photos)
                        {
                            listBoxPhotosList.Items.Add(currPhoto);
                        }

                        if (selectedAlbum.Count == 0)
                        {
                            MessageBox.Show("empty album");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("please select one albums");
            }
        }

        private void fetchPhotoFromSpecificAlbum()
        {
            Random random = new Random();

            if (listBoxAlbumsList.SelectedItems.Count == 1)
            {
                try
                {
                    Photo selectedPhoto = listBoxPhotosList.SelectedItem as Photo;
                    
                    if (selectedPhoto != null)
                    {
                        pictureBoxPhoto.LoadAsync(selectedPhoto.PictureNormalURL);
                        pictureBoxPhoto.Visible = true;
                        textBoxLikesCountPhoto.Text = random.Next(500).ToString();
                        populateListBox(listBoxCommentsPhoto, selectedPhoto.Comments.ToList());
                        buttonLikePhoto.Enabled = true;
                        buttonLikePhoto.Text = r_Like;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("please select one photo");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            buttonLogin.Text = r_Login;
            if (m_LoggedInUser == null)
            {
                MessageBox.Show("You are already logged out");

                return;
            }

            try
            {
                FacebookService.LogoutWithUI();
                r_AppSettings.LastAccessToken = null;
                m_LoggedInUser = null;
                m_LoginResult = null;
                resetForm();
                saveAppSettings();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonLikePost_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            if (listBoxPostsList.SelectedItems.Count == 1)
            {
                try
                {
                    object selectedPost = listBoxPostsList.SelectedItem;

                    if (selectedPost != null)
                    {
                        if (buttonLikePost.Text.Equals(r_Unlike))
                        {
                            buttonLikePost.Text = r_Like;
                            textBoxLikesCountPost.Text = (int.Parse(textBoxLikesCountPost.Text) - 1).ToString();
                        }
                        else
                        {
                            buttonLikePost.Text = r_Unlike;
                            textBoxLikesCountPost.Text = (int.Parse(textBoxLikesCountPost.Text) + 1).ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("please select one photo to like/unlike");
            }
        }

        private void buttonLikePhoto_Click(object sender, EventArgs e)
        {
            if (listBoxAlbumsList.SelectedItems.Count == 1)
            {
                try
                {
                    Photo selectedPhoto = listBoxPhotosList.SelectedItem as Photo;

                    if (selectedPhoto != null)
                    {
                        if (buttonLikePhoto.Text == r_Like)
                        {
                            buttonLikePhoto.Text = r_Unlike;
                            textBoxLikesCountPhoto.Text = (int.Parse(textBoxLikesCountPhoto.Text) + 1).ToString();
                        }
                        else
                        {
                            buttonLikePhoto.Text = r_Like;
                            textBoxLikesCountPhoto.Text = (int.Parse(textBoxLikesCountPhoto.Text) - 1).ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("please select one photo to like/unlike");
            }
        }

        private void buttonCommentOnPost_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCommentOnPost.Text))
            {
                try
                {
                    textBoxCommentOnPost.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("please insert a comment");
            }
        }

        private void buttonUploadOwnStatus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxOwnStatus.Text))
            {
                try
                {
                    textBoxOwnStatus.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("please insert a comment");
            }
        }

        private void checkBoxRememberUser_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox castedSender)
            {
                r_AppSettings.RememberUser = castedSender.Checked;
            }
        }

        private void buttonFeatureStats_Click(object sender, EventArgs e)
        {
            FormStatsFeature formStatsFeature;
            DialogResult dialogResult = MessageBox.Show("Would you like best preformnce stats? (for worst press No)", "Notifier", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                formStatsFeature = new FormBestStatsFeature(m_LoggedInUser);
            }
            else
            {
                formStatsFeature = new FormWorstStatsFeature(m_LoggedInUser);
            }

            formStatsFeature.Show();
        }

        private void buttonFeatureSearchEngine_Click(object sender, EventArgs e)
        {
            FormSearchFeature formSearchFeature = new FormSearchFeature(m_LoggedInUser);

            formSearchFeature.Show();
        }

        private void checkinsCountLabel_Click(object sender, EventArgs e)
        {
        }

        private void checkinsCountTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void imageNormalLabel_Click(object sender, EventArgs e)
        {
        }

        private void imageNormalPictureBox_Click(object sender, EventArgs e)
        {
        }

        private void isPublishedLabel_Click(object sender, EventArgs e)
        {
        }

        private void isPublishedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
