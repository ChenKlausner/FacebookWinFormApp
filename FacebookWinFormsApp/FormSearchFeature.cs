using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormSearchFeature : Form
    {
        private readonly User r_LoggedInUser;
        private readonly string r_FriendsfileName = $"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\\friendsList.txt";
        private Trie m_PostTrie;
        private Trie m_AlbumsTrie;
        private Trie m_LikedPageTrie;
        private Dictionary<string, bool> m_PostDictionary;
        private List<string> m_GroupList;
        private Dictionary<string, bool> m_LikedPagesDictionary;

        public FormSearchFeature(User i_LoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = i_LoggedInUser;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            try
            {
                fetchPosts();
                m_PostTrie = new Trie(m_PostDictionary.Keys.ToList());
                fetchLikedPages();
                m_LikedPageTrie = new Trie(m_LikedPagesDictionary.Keys.ToList());
                fetchAlbums();
                m_AlbumsTrie = new Trie(m_GroupList);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"There was a problem. Error: { exception.Message }");
                Close();
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();
            m_PostDictionary = new Dictionary<string, bool>();
            foreach (Post post in r_LoggedInUser.Posts)
            {
                bool liked;

                if (post.Message != null && !m_PostDictionary.TryGetValue(post.Message, out liked))
                {
                    m_PostDictionary.Add(post.Message, false);
                }
            }

            if (m_PostDictionary.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }

            listBoxPosts.Items.Clear();
            listBoxPosts.Items.AddRange(m_PostDictionary.Keys.ToList().ToArray());
        }

        private void buttonLikePost_Click(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedItem == null)
            {
                MessageBox.Show("You need to select post");

                return;
            }

            string selctedPost = listBoxPosts.GetItemText(listBoxPosts.SelectedItem);
            bool isLiked = false;

            buttonLikePost.BackColor = Color.LightBlue;
            m_PostDictionary[selctedPost] = true;
            m_PostDictionary.TryGetValue(selctedPost, out isLiked);
            if (isLiked)
            {
                buttonLikePost.BackColor = Color.LightBlue;
            }
        }

        private void buttonUnlikePost_Click(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedItem == null)
            {
                MessageBox.Show("You need to select post");

                return;
            }

            string selctedPost = listBoxPosts.GetItemText(listBoxPosts.SelectedItem);

            buttonLikePost.BackColor = Color.LightGray;
            m_PostDictionary[selctedPost] = false;
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selctedPost = listBoxPosts.GetItemText(listBoxPosts.SelectedItem);
            bool isLiked = false;

            m_PostDictionary.TryGetValue(selctedPost, out isLiked);
            buttonLikePost.BackColor = isLiked ? Color.LightBlue : Color.LightGray;
        }

        private void textBoxSearchPost_TextChanged(object sender, EventArgs e)
        {
            buttonLikePost.BackColor = Color.LightGray;
            listBoxPosts.Items.Clear();
            listBoxPosts.Items.AddRange(m_PostTrie.Suggest(textBoxSearchPost.Text).ToArray());
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            m_LikedPagesDictionary = new Dictionary<string, bool>();
            try
            {
                foreach (Page page in r_LoggedInUser.LikedPages)
                {
                    if(!m_LikedPagesDictionary.TryGetValue(page.Name, out bool liked))
                    {
                        m_LikedPagesDictionary.Add(page.Name, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (m_LikedPagesDictionary.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }

            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.Items.AddRange(m_LikedPagesDictionary.Keys.ToList().ToArray());
        }

        private void buttonUnlikePage_Click(object sender, EventArgs e)
        {
            if (listBoxLikedPages.SelectedItem == null)
            {
                MessageBox.Show("You need to select page");

                return;
            }

            string selctedLikedPage = listBoxLikedPages.GetItemText(listBoxLikedPages.SelectedItem);

            if (buttonUnlikePage.Text.Equals("Like"))
            {
                buttonUnlikePage.Text = "Unlike";
                m_LikedPagesDictionary[selctedLikedPage] = true;
            }

            buttonUnlikePage.Text = "Like";
            m_LikedPagesDictionary[selctedLikedPage] = false;
        }

        private void textBoxSearchLikedPage_TextChanged(object sender, EventArgs e)
        {
            buttonUnlikePage.Text = "Unlike page";
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.Items.AddRange(m_LikedPageTrie.Suggest(textBoxSearchLikedPage.Text).ToArray());
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selctedLikedPage = listBoxLikedPages.GetItemText(listBoxLikedPages.SelectedItem);
            bool isLiked = false;

            m_LikedPagesDictionary.TryGetValue(selctedLikedPage, out isLiked);
            buttonUnlikePage.Text = isLiked ? "Unlike Page" : "Like";
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            m_GroupList = new List<string>();
            try
            {
                foreach (Album group in r_LoggedInUser.Albums)
                {
                    m_GroupList.Add(group.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (m_GroupList.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }

            listBoxAlbums.Items.Clear();
            listBoxAlbums.Items.AddRange(m_GroupList.ToArray());
        }

        private void buttonDeleteAlbum_Click(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItem == null)
            {
                MessageBox.Show("You need to select an album to delete");

                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Are You sure you want to delete {listBoxAlbums.SelectedItem}?", "Notifier", MessageBoxButtons.YesNo);
        }

        private void textBoxSearchGroup_TextChanged(object sender, EventArgs e)
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.Items.AddRange(m_AlbumsTrie.Suggest(textBoxSearchAlbum.Text).ToArray());
        }

        private void buttonSendPost_Click(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedItem == null)
            {
                MessageBox.Show("You need to select post");

                return;
            }

            buttonSendOrInvite.Text = "Send";
            doWhenSendOrInviteFriendIsPressed();
        }

        private void buttonSendAlbumToFriends_Click(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItem == null)
            {
                MessageBox.Show("You need to select an album");

                return;
            }

            buttonSendOrInvite.Text = "Send";
            doWhenSendOrInviteFriendIsPressed();
        }

        private void buttonInviteFreindsToLikePage_Click(object sender, EventArgs e)
        {
            if (listBoxLikedPages.SelectedItem == null)
            {
                MessageBox.Show("You need to select page");

                return;
            }

            buttonSendOrInvite.Text = "Invite";
            doWhenSendOrInviteFriendIsPressed();
        }

        private void doWhenSendOrInviteFriendIsPressed()
        {
            string[] friendsArray = File.ReadAllLines(r_FriendsfileName);

            checkedListBoxFriends.Visible = true;
            labelFriends.Visible = true;
            buttonSendOrInvite.Visible = true;
            checkedListBoxFriends.Items.AddRange(friendsArray);
        }

        private void buttonSendOrInvite_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opration successfully done!");
            checkedListBoxFriends.Visible = false;
            labelFriends.Visible = false;
            buttonSendOrInvite.Visible = false;
            for (int i = 0; i < checkedListBoxFriends.Items.Count; i++)
            {
                checkedListBoxFriends.SetItemChecked(i, false);
            }
        }
    }
}
