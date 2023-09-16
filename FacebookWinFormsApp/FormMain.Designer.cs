namespace BasicFacebookFeatures
{
    public partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label isPublishedLabel;
            System.Windows.Forms.Label nameLabel;
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.labelChoosePhoto = new System.Windows.Forms.Label();
            this.buttonFeatureStats = new System.Windows.Forms.Button();
            this.buttonFeatureSearch = new System.Windows.Forms.Button();
            this.listBoxPhotosList = new System.Windows.Forms.ListBox();
            this.listBoxAlbumsList = new System.Windows.Forms.ListBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelAlbumsList = new System.Windows.Forms.Label();
            this.listBoxPostsList = new System.Windows.Forms.ListBox();
            this.labelFeed = new System.Windows.Forms.Label();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.textBoxOwnStatus = new System.Windows.Forms.TextBox();
            this.textBoxCommentOnPost = new System.Windows.Forms.TextBox();
            this.labelCommentOnPost = new System.Windows.Forms.Label();
            this.labelLikesPost = new System.Windows.Forms.Label();
            this.textBoxLikesCountPost = new System.Windows.Forms.TextBox();
            this.buttonCommentOnPost = new System.Windows.Forms.Button();
            this.buttonLikePost = new System.Windows.Forms.Button();
            this.listBoxCommentsPost = new System.Windows.Forms.ListBox();
            this.buttonUploadOwnStatus = new System.Windows.Forms.Button();
            this.labelCommentsPost = new System.Windows.Forms.Label();
            this.pictureBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.listBoxLikedPagesList = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelLikesPhoto = new System.Windows.Forms.Label();
            this.textBoxLikesCountPhoto = new System.Windows.Forms.TextBox();
            this.labelCommentsPhoto = new System.Windows.Forms.Label();
            this.listBoxCommentsPhoto = new System.Windows.Forms.ListBox();
            this.label4About = new System.Windows.Forms.Label();
            this.textBox2About = new System.Windows.Forms.TextBox();
            this.labelCurrentPost = new System.Windows.Forms.Label();
            this.textBoxSelectedPost = new System.Windows.Forms.TextBox();
            this.textBox4About = new System.Windows.Forms.TextBox();
            this.textBox3About = new System.Windows.Forms.TextBox();
            this.label2About = new System.Windows.Forms.Label();
            this.label3About = new System.Windows.Forms.Label();
            this.label1About = new System.Windows.Forms.Label();
            this.textBox1About = new System.Windows.Forms.TextBox();
            this.buttonLikePhoto = new System.Windows.Forms.Button();
            this.groupBoxFeatures = new System.Windows.Forms.GroupBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.isPublishedCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            isPublishedLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            this.groupBoxFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 53);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(123, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(728, 42);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(102, 23);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Checked = true;
            this.checkBoxRememberUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(12, 82);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(94, 17);
            this.checkBoxRememberUser.TabIndex = 56;
            this.checkBoxRememberUser.Text = "Remember me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            this.checkBoxRememberUser.CheckedChanged += new System.EventHandler(this.checkBoxRememberUser_CheckedChanged);
            // 
            // labelChoosePhoto
            // 
            this.labelChoosePhoto.AutoSize = true;
            this.labelChoosePhoto.Location = new System.Drawing.Point(258, 336);
            this.labelChoosePhoto.Name = "labelChoosePhoto";
            this.labelChoosePhoto.Size = new System.Drawing.Size(40, 13);
            this.labelChoosePhoto.TabIndex = 59;
            this.labelChoosePhoto.Text = "Photos";
            // 
            // buttonFeatureStats
            // 
            this.buttonFeatureStats.Location = new System.Drawing.Point(6, 42);
            this.buttonFeatureStats.Name = "buttonFeatureStats";
            this.buttonFeatureStats.Size = new System.Drawing.Size(90, 23);
            this.buttonFeatureStats.TabIndex = 83;
            this.buttonFeatureStats.Text = "Stats";
            this.buttonFeatureStats.UseVisualStyleBackColor = true;
            this.buttonFeatureStats.Click += new System.EventHandler(this.buttonFeatureStats_Click);
            // 
            // buttonFeatureSearch
            // 
            this.buttonFeatureSearch.Location = new System.Drawing.Point(7, 71);
            this.buttonFeatureSearch.Name = "buttonFeatureSearch";
            this.buttonFeatureSearch.Size = new System.Drawing.Size(89, 23);
            this.buttonFeatureSearch.TabIndex = 84;
            this.buttonFeatureSearch.Text = "Search Engine";
            this.buttonFeatureSearch.UseVisualStyleBackColor = true;
            this.buttonFeatureSearch.Click += new System.EventHandler(this.buttonFeatureSearchEngine_Click);
            // 
            // listBoxPhotosList
            // 
            this.listBoxPhotosList.FormattingEnabled = true;
            this.listBoxPhotosList.Location = new System.Drawing.Point(201, 356);
            this.listBoxPhotosList.Name = "listBoxPhotosList";
            this.listBoxPhotosList.Size = new System.Drawing.Size(167, 264);
            this.listBoxPhotosList.TabIndex = 58;
            this.listBoxPhotosList.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotosList_SelectedIndexChanged);
            // 
            // listBoxAlbumsList
            // 
            this.listBoxAlbumsList.FormattingEnabled = true;
            this.listBoxAlbumsList.Location = new System.Drawing.Point(12, 356);
            this.listBoxAlbumsList.Name = "listBoxAlbumsList";
            this.listBoxAlbumsList.Size = new System.Drawing.Size(162, 264);
            this.listBoxAlbumsList.TabIndex = 2;
            this.listBoxAlbumsList.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbumsList_SelectedIndexChanged);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(395, 356);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(125, 119);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 1;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // labelAlbumsList
            // 
            this.labelAlbumsList.AutoSize = true;
            this.labelAlbumsList.Location = new System.Drawing.Point(65, 336);
            this.labelAlbumsList.Name = "labelAlbumsList";
            this.labelAlbumsList.Size = new System.Drawing.Size(41, 13);
            this.labelAlbumsList.TabIndex = 0;
            this.labelAlbumsList.Text = "Albums";
            // 
            // listBoxPostsList
            // 
            this.listBoxPostsList.FormattingEnabled = true;
            this.listBoxPostsList.Location = new System.Drawing.Point(201, 82);
            this.listBoxPostsList.Name = "listBoxPostsList";
            this.listBoxPostsList.Size = new System.Drawing.Size(391, 160);
            this.listBoxPostsList.TabIndex = 58;
            this.listBoxPostsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSelectedPost_MouseDoubleClick);
            // 
            // labelFeed
            // 
            this.labelFeed.AutoSize = true;
            this.labelFeed.Location = new System.Drawing.Point(203, 63);
            this.labelFeed.Name = "labelFeed";
            this.labelFeed.Size = new System.Drawing.Size(34, 13);
            this.labelFeed.TabIndex = 63;
            this.labelFeed.Text = "Feed:";
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Location = new System.Drawing.Point(203, 9);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(109, 13);
            this.labelPostStatus.TabIndex = 67;
            this.labelPostStatus.Text = "What\'s on your mind?";
            // 
            // textBoxOwnStatus
            // 
            this.textBoxOwnStatus.Location = new System.Drawing.Point(206, 25);
            this.textBoxOwnStatus.Name = "textBoxOwnStatus";
            this.textBoxOwnStatus.Size = new System.Drawing.Size(386, 20);
            this.textBoxOwnStatus.TabIndex = 68;
            // 
            // textBoxCommentOnPost
            // 
            this.textBoxCommentOnPost.Location = new System.Drawing.Point(634, 259);
            this.textBoxCommentOnPost.Multiline = true;
            this.textBoxCommentOnPost.Name = "textBoxCommentOnPost";
            this.textBoxCommentOnPost.Size = new System.Drawing.Size(184, 48);
            this.textBoxCommentOnPost.TabIndex = 70;
            // 
            // labelCommentOnPost
            // 
            this.labelCommentOnPost.AutoSize = true;
            this.labelCommentOnPost.Location = new System.Drawing.Point(631, 243);
            this.labelCommentOnPost.Name = "labelCommentOnPost";
            this.labelCommentOnPost.Size = new System.Drawing.Size(124, 13);
            this.labelCommentOnPost.TabIndex = 71;
            this.labelCommentOnPost.Text = "What are your thoughts?";
            // 
            // labelLikesPost
            // 
            this.labelLikesPost.AutoSize = true;
            this.labelLikesPost.Location = new System.Drawing.Point(631, 102);
            this.labelLikesPost.Name = "labelLikesPost";
            this.labelLikesPost.Size = new System.Drawing.Size(35, 13);
            this.labelLikesPost.TabIndex = 72;
            this.labelLikesPost.Text = "Likes:";
            // 
            // textBoxLikesCountPost
            // 
            this.textBoxLikesCountPost.Location = new System.Drawing.Point(672, 99);
            this.textBoxLikesCountPost.Name = "textBoxLikesCountPost";
            this.textBoxLikesCountPost.ReadOnly = true;
            this.textBoxLikesCountPost.Size = new System.Drawing.Size(64, 20);
            this.textBoxLikesCountPost.TabIndex = 73;
            // 
            // buttonCommentOnPost
            // 
            this.buttonCommentOnPost.Location = new System.Drawing.Point(663, 313);
            this.buttonCommentOnPost.Name = "buttonCommentOnPost";
            this.buttonCommentOnPost.Size = new System.Drawing.Size(113, 23);
            this.buttonCommentOnPost.TabIndex = 74;
            this.buttonCommentOnPost.Text = "Comment on post";
            this.buttonCommentOnPost.UseVisualStyleBackColor = true;
            this.buttonCommentOnPost.Click += new System.EventHandler(this.buttonCommentOnPost_Click);
            // 
            // buttonLikePost
            // 
            this.buttonLikePost.Location = new System.Drawing.Point(755, 99);
            this.buttonLikePost.Name = "buttonLikePost";
            this.buttonLikePost.Size = new System.Drawing.Size(51, 23);
            this.buttonLikePost.TabIndex = 75;
            this.buttonLikePost.Text = "Like !";
            this.buttonLikePost.UseVisualStyleBackColor = true;
            this.buttonLikePost.Click += new System.EventHandler(this.buttonLikePost_Click);
            // 
            // listBoxCommentsPost
            // 
            this.listBoxCommentsPost.FormattingEnabled = true;
            this.listBoxCommentsPost.Location = new System.Drawing.Point(634, 145);
            this.listBoxCommentsPost.Name = "listBoxCommentsPost";
            this.listBoxCommentsPost.Size = new System.Drawing.Size(184, 95);
            this.listBoxCommentsPost.TabIndex = 76;
            // 
            // buttonUploadOwnStatus
            // 
            this.buttonUploadOwnStatus.Location = new System.Drawing.Point(517, 51);
            this.buttonUploadOwnStatus.Name = "buttonUploadOwnStatus";
            this.buttonUploadOwnStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadOwnStatus.TabIndex = 65;
            this.buttonUploadOwnStatus.Text = "Post status";
            this.buttonUploadOwnStatus.UseVisualStyleBackColor = true;
            this.buttonUploadOwnStatus.Click += new System.EventHandler(this.buttonUploadOwnStatus_Click);
            // 
            // labelCommentsPost
            // 
            this.labelCommentsPost.AutoSize = true;
            this.labelCommentsPost.Location = new System.Drawing.Point(631, 129);
            this.labelCommentsPost.Name = "labelCommentsPost";
            this.labelCommentsPost.Size = new System.Drawing.Size(59, 13);
            this.labelCommentsPost.TabIndex = 77;
            this.labelCommentsPost.Text = "Comments:";
            // 
            // pictureBoxProfilePic
            // 
            this.pictureBoxProfilePic.Location = new System.Drawing.Point(9, 105);
            this.pictureBoxProfilePic.Name = "pictureBoxProfilePic";
            this.pictureBoxProfilePic.Size = new System.Drawing.Size(165, 125);
            this.pictureBoxProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePic.TabIndex = 53;
            this.pictureBoxProfilePic.TabStop = false;
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Location = new System.Drawing.Point(690, 377);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(65, 13);
            this.labelLikedPages.TabIndex = 64;
            this.labelLikedPages.Text = "Liked pages";
            // 
            // listBoxLikedPagesList
            // 
            this.listBoxLikedPagesList.DataSource = this.pageBindingSource;
            this.listBoxLikedPagesList.DisplayMember = "Name";
            this.listBoxLikedPagesList.FormattingEnabled = true;
            this.listBoxLikedPagesList.Location = new System.Drawing.Point(634, 393);
            this.listBoxLikedPagesList.Name = "listBoxLikedPagesList";
            this.listBoxLikedPagesList.Size = new System.Drawing.Size(184, 225);
            this.listBoxLikedPagesList.TabIndex = 59;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // labelLikesPhoto
            // 
            this.labelLikesPhoto.AutoSize = true;
            this.labelLikesPhoto.Location = new System.Drawing.Point(392, 484);
            this.labelLikesPhoto.Name = "labelLikesPhoto";
            this.labelLikesPhoto.Size = new System.Drawing.Size(35, 13);
            this.labelLikesPhoto.TabIndex = 78;
            this.labelLikesPhoto.Text = "Likes:";
            // 
            // textBoxLikesCountPhoto
            // 
            this.textBoxLikesCountPhoto.Location = new System.Drawing.Point(433, 481);
            this.textBoxLikesCountPhoto.Name = "textBoxLikesCountPhoto";
            this.textBoxLikesCountPhoto.ReadOnly = true;
            this.textBoxLikesCountPhoto.Size = new System.Drawing.Size(64, 20);
            this.textBoxLikesCountPhoto.TabIndex = 79;
            // 
            // labelCommentsPhoto
            // 
            this.labelCommentsPhoto.AutoSize = true;
            this.labelCommentsPhoto.Location = new System.Drawing.Point(392, 504);
            this.labelCommentsPhoto.Name = "labelCommentsPhoto";
            this.labelCommentsPhoto.Size = new System.Drawing.Size(59, 13);
            this.labelCommentsPhoto.TabIndex = 80;
            this.labelCommentsPhoto.Text = "Comments:";
            // 
            // listBoxCommentsPhoto
            // 
            this.listBoxCommentsPhoto.FormattingEnabled = true;
            this.listBoxCommentsPhoto.Location = new System.Drawing.Point(395, 525);
            this.listBoxCommentsPhoto.Name = "listBoxCommentsPhoto";
            this.listBoxCommentsPhoto.Size = new System.Drawing.Size(184, 95);
            this.listBoxCommentsPhoto.TabIndex = 81;
            // 
            // label4About
            // 
            this.label4About.AutoSize = true;
            this.label4About.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4About.Location = new System.Drawing.Point(12, 318);
            this.label4About.Name = "label4About";
            this.label4About.Size = new System.Drawing.Size(0, 13);
            this.label4About.TabIndex = 86;
            // 
            // textBox2About
            // 
            this.textBox2About.Location = new System.Drawing.Point(79, 262);
            this.textBox2About.Name = "textBox2About";
            this.textBox2About.ReadOnly = true;
            this.textBox2About.Size = new System.Drawing.Size(95, 20);
            this.textBox2About.TabIndex = 87;
            // 
            // labelCurrentPost
            // 
            this.labelCurrentPost.AutoSize = true;
            this.labelCurrentPost.Location = new System.Drawing.Point(203, 245);
            this.labelCurrentPost.Name = "labelCurrentPost";
            this.labelCurrentPost.Size = new System.Drawing.Size(67, 13);
            this.labelCurrentPost.TabIndex = 89;
            this.labelCurrentPost.Text = "Current post:";
            // 
            // textBoxSelectedPost
            // 
            this.textBoxSelectedPost.Location = new System.Drawing.Point(201, 262);
            this.textBoxSelectedPost.Multiline = true;
            this.textBoxSelectedPost.Name = "textBoxSelectedPost";
            this.textBoxSelectedPost.Size = new System.Drawing.Size(391, 45);
            this.textBoxSelectedPost.TabIndex = 90;
            // 
            // textBox4About
            // 
            this.textBox4About.Location = new System.Drawing.Point(79, 316);
            this.textBox4About.Name = "textBox4About";
            this.textBox4About.ReadOnly = true;
            this.textBox4About.Size = new System.Drawing.Size(95, 20);
            this.textBox4About.TabIndex = 92;
            // 
            // textBox3About
            // 
            this.textBox3About.Location = new System.Drawing.Point(79, 289);
            this.textBox3About.Name = "textBox3About";
            this.textBox3About.ReadOnly = true;
            this.textBox3About.Size = new System.Drawing.Size(95, 20);
            this.textBox3About.TabIndex = 93;
            // 
            // label2About
            // 
            this.label2About.AutoSize = true;
            this.label2About.Location = new System.Drawing.Point(12, 262);
            this.label2About.Name = "label2About";
            this.label2About.Size = new System.Drawing.Size(0, 13);
            this.label2About.TabIndex = 94;
            // 
            // label3About
            // 
            this.label3About.AutoSize = true;
            this.label3About.Location = new System.Drawing.Point(12, 292);
            this.label3About.Name = "label3About";
            this.label3About.Size = new System.Drawing.Size(0, 13);
            this.label3About.TabIndex = 95;
            // 
            // label1About
            // 
            this.label1About.AutoSize = true;
            this.label1About.Location = new System.Drawing.Point(12, 233);
            this.label1About.Name = "label1About";
            this.label1About.Size = new System.Drawing.Size(0, 13);
            this.label1About.TabIndex = 96;
            // 
            // textBox1About
            // 
            this.textBox1About.Location = new System.Drawing.Point(79, 233);
            this.textBox1About.Name = "textBox1About";
            this.textBox1About.ReadOnly = true;
            this.textBox1About.Size = new System.Drawing.Size(95, 20);
            this.textBox1About.TabIndex = 97;
            // 
            // buttonLikePhoto
            // 
            this.buttonLikePhoto.Location = new System.Drawing.Point(527, 481);
            this.buttonLikePhoto.Name = "buttonLikePhoto";
            this.buttonLikePhoto.Size = new System.Drawing.Size(52, 23);
            this.buttonLikePhoto.TabIndex = 98;
            this.buttonLikePhoto.Text = "Like !";
            this.buttonLikePhoto.UseVisualStyleBackColor = true;
            this.buttonLikePhoto.Click += new System.EventHandler(this.buttonLikePhoto_Click);
            // 
            // groupBoxFeatures
            // 
            this.groupBoxFeatures.Controls.Add(this.buttonFeatureSearch);
            this.groupBoxFeatures.Controls.Add(this.buttonFeatureStats);
            this.groupBoxFeatures.Location = new System.Drawing.Point(527, 356);
            this.groupBoxFeatures.Name = "groupBoxFeatures";
            this.groupBoxFeatures.Size = new System.Drawing.Size(102, 97);
            this.groupBoxFeatures.TabIndex = 99;
            this.groupBoxFeatures.TabStop = false;
            this.groupBoxFeatures.Text = "Features";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 7);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(45, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 100;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(isPublishedLabel);
            this.panel1.Controls.Add(this.isPublishedCheckBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(825, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 203);
            this.panel1.TabIndex = 101;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(3, 153);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(84, 150);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(104, 50);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(84, 34);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(104, 90);
            this.imageNormalPictureBox.TabIndex = 3;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // isPublishedLabel
            // 
            isPublishedLabel.AutoSize = true;
            isPublishedLabel.Location = new System.Drawing.Point(3, 132);
            isPublishedLabel.Name = "isPublishedLabel";
            isPublishedLabel.Size = new System.Drawing.Size(67, 13);
            isPublishedLabel.TabIndex = 4;
            isPublishedLabel.Text = "Is Published:";
            // 
            // isPublishedCheckBox
            // 
            this.isPublishedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pageBindingSource, "IsPublished", true));
            this.isPublishedCheckBox.Location = new System.Drawing.Point(84, 127);
            this.isPublishedCheckBox.Name = "isPublishedCheckBox";
            this.isPublishedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isPublishedCheckBox.TabIndex = 5;
            this.isPublishedCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 10);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(84, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(104, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.groupBoxFeatures);
            this.Controls.Add(this.buttonLikePhoto);
            this.Controls.Add(this.textBox1About);
            this.Controls.Add(this.label1About);
            this.Controls.Add(this.label3About);
            this.Controls.Add(this.label2About);
            this.Controls.Add(this.textBox3About);
            this.Controls.Add(this.textBox4About);
            this.Controls.Add(this.textBoxSelectedPost);
            this.Controls.Add(this.labelCurrentPost);
            this.Controls.Add(this.textBox2About);
            this.Controls.Add(this.label4About);
            this.Controls.Add(this.listBoxCommentsPhoto);
            this.Controls.Add(this.labelCommentsPhoto);
            this.Controls.Add(this.textBoxLikesCountPhoto);
            this.Controls.Add(this.labelLikesPhoto);
            this.Controls.Add(this.labelCommentsPost);
            this.Controls.Add(this.listBoxCommentsPost);
            this.Controls.Add(this.buttonLikePost);
            this.Controls.Add(this.buttonCommentOnPost);
            this.Controls.Add(this.textBoxLikesCountPost);
            this.Controls.Add(this.labelLikesPost);
            this.Controls.Add(this.labelCommentOnPost);
            this.Controls.Add(this.textBoxCommentOnPost);
            this.Controls.Add(this.textBoxOwnStatus);
            this.Controls.Add(this.labelPostStatus);
            this.Controls.Add(this.buttonUploadOwnStatus);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.listBoxAlbumsList);
            this.Controls.Add(this.labelAlbumsList);
            this.Controls.Add(this.labelChoosePhoto);
            this.Controls.Add(this.labelLikedPages);
            this.Controls.Add(this.listBoxPhotosList);
            this.Controls.Add(this.labelFeed);
            this.Controls.Add(this.listBoxLikedPagesList);
            this.Controls.Add(this.listBoxPostsList);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.pictureBoxProfilePic);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            this.groupBoxFeatures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfilePic;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.ListBox listBoxAlbumsList;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label labelAlbumsList;
        private System.Windows.Forms.ListBox listBoxPhotosList;
        private System.Windows.Forms.ListBox listBoxPostsList;
        private System.Windows.Forms.Label labelChoosePhoto;
        private System.Windows.Forms.Label labelFeed;
        private System.Windows.Forms.Button buttonUploadOwnStatus;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.TextBox textBoxOwnStatus;
        private System.Windows.Forms.TextBox textBoxCommentOnPost;
        private System.Windows.Forms.Label labelCommentOnPost;
        private System.Windows.Forms.Label labelLikesPost;
        private System.Windows.Forms.TextBox textBoxLikesCountPost;
        private System.Windows.Forms.Button buttonCommentOnPost;
        private System.Windows.Forms.Button buttonLikePost;
        private System.Windows.Forms.ListBox listBoxCommentsPost;
        private System.Windows.Forms.Label labelCommentsPost;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.ListBox listBoxLikedPagesList;
        private System.Windows.Forms.Label labelLikesPhoto;
        private System.Windows.Forms.TextBox textBoxLikesCountPhoto;
        private System.Windows.Forms.Label labelCommentsPhoto;
        private System.Windows.Forms.ListBox listBoxCommentsPhoto;
        private System.Windows.Forms.Button buttonFeatureStats;
        private System.Windows.Forms.Button buttonFeatureSearch;
        private System.Windows.Forms.Label label4About;
        private System.Windows.Forms.TextBox textBox2About;
        private System.Windows.Forms.Label labelCurrentPost;
        private System.Windows.Forms.TextBox textBoxSelectedPost;
        private System.Windows.Forms.TextBox textBox4About;
        private System.Windows.Forms.TextBox textBox3About;
        private System.Windows.Forms.Label label2About;
        private System.Windows.Forms.Label label3About;
        private System.Windows.Forms.Label label1About;
        private System.Windows.Forms.TextBox textBox1About;
        private System.Windows.Forms.Button buttonLikePhoto;
        private System.Windows.Forms.GroupBox groupBoxFeatures;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.CheckBox isPublishedCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}