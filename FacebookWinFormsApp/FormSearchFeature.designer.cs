
namespace BasicFacebookFeatures
{
    partial class FormSearchFeature
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
            this.labelSearchPost = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.textBoxSearchPost = new System.Windows.Forms.TextBox();
            this.labelSearchAlbum = new System.Windows.Forms.Label();
            this.textBoxSearchAlbum = new System.Windows.Forms.TextBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelSearchLikedPages = new System.Windows.Forms.Label();
            this.textBoxSearchLikedPage = new System.Windows.Forms.TextBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonLikePost = new System.Windows.Forms.Button();
            this.buttonUnlikePost = new System.Windows.Forms.Button();
            this.buttonSendPost = new System.Windows.Forms.Button();
            this.buttonDeleteAlbum = new System.Windows.Forms.Button();
            this.buttonInviteToGroup = new System.Windows.Forms.Button();
            this.buttonUnlikePage = new System.Windows.Forms.Button();
            this.buttonInviteFreindsToLikePage = new System.Windows.Forms.Button();
            this.checkedListBoxFriends = new System.Windows.Forms.CheckedListBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.buttonSendOrInvite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_LabelSearchPost
            // 
            this.labelSearchPost.AutoSize = true;
            this.labelSearchPost.Location = new System.Drawing.Point(12, 19);
            this.labelSearchPost.Name = "m_LabelSearchPost";
            this.labelSearchPost.Size = new System.Drawing.Size(76, 13);
            this.labelSearchPost.TabIndex = 0;
            this.labelSearchPost.Text = "Search a post:";
            // 
            // m_ListBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(12, 61);
            this.listBoxPosts.Name = "m_ListBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(189, 225);
            this.listBoxPosts.TabIndex = 1;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // m_TextBoxSearchPost
            // 
            this.textBoxSearchPost.Location = new System.Drawing.Point(12, 35);
            this.textBoxSearchPost.Name = "m_TextBoxSearchPost";
            this.textBoxSearchPost.Size = new System.Drawing.Size(189, 20);
            this.textBoxSearchPost.TabIndex = 2;
            this.textBoxSearchPost.TextChanged += new System.EventHandler(this.textBoxSearchPost_TextChanged);
            // 
            // m_LabelSearchAlbum
            // 
            this.labelSearchAlbum.AutoSize = true;
            this.labelSearchAlbum.Location = new System.Drawing.Point(218, 19);
            this.labelSearchAlbum.Name = "m_LabelSearchAlbum";
            this.labelSearchAlbum.Size = new System.Drawing.Size(84, 13);
            this.labelSearchAlbum.TabIndex = 3;
            this.labelSearchAlbum.Text = "Search a album:";
            // 
            // m_TextBoxSearchGroup
            // 
            this.textBoxSearchAlbum.Location = new System.Drawing.Point(221, 35);
            this.textBoxSearchAlbum.Name = "m_TextBoxSearchGroup";
            this.textBoxSearchAlbum.Size = new System.Drawing.Size(189, 20);
            this.textBoxSearchAlbum.TabIndex = 4;
            this.textBoxSearchAlbum.TextChanged += new System.EventHandler(this.textBoxSearchGroup_TextChanged);
            // 
            // m_ListBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(221, 61);
            this.listBoxAlbums.Name = "m_ListBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(189, 225);
            this.listBoxAlbums.TabIndex = 5;
            // 
            // m_LabelSearchLikedPages
            // 
            this.labelSearchLikedPages.AutoSize = true;
            this.labelSearchLikedPages.Location = new System.Drawing.Point(425, 19);
            this.labelSearchLikedPages.Name = "m_LabelSearchLikedPages";
            this.labelSearchLikedPages.Size = new System.Drawing.Size(105, 13);
            this.labelSearchLikedPages.TabIndex = 6;
            this.labelSearchLikedPages.Text = "Search a liked page:";
            // 
            // m_TextBoxSearchLikedPage
            // 
            this.textBoxSearchLikedPage.Location = new System.Drawing.Point(428, 35);
            this.textBoxSearchLikedPage.Name = "m_TextBoxSearchLikedPage";
            this.textBoxSearchLikedPage.Size = new System.Drawing.Size(189, 20);
            this.textBoxSearchLikedPage.TabIndex = 7;
            this.textBoxSearchLikedPage.TextChanged += new System.EventHandler(this.textBoxSearchLikedPage_TextChanged);
            // 
            // m_ListBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.Location = new System.Drawing.Point(428, 61);
            this.listBoxLikedPages.Name = "m_ListBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(189, 225);
            this.listBoxLikedPages.TabIndex = 8;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // m_ButtonLikePost
            // 
            this.buttonLikePost.Location = new System.Drawing.Point(12, 301);
            this.buttonLikePost.Name = "m_ButtonLikePost";
            this.buttonLikePost.Size = new System.Drawing.Size(35, 23);
            this.buttonLikePost.TabIndex = 9;
            this.buttonLikePost.Text = "Like";
            this.buttonLikePost.UseVisualStyleBackColor = true;
            this.buttonLikePost.Click += new System.EventHandler(this.buttonLikePost_Click);
            // 
            // m_ButtonUnlikePost
            // 
            this.buttonUnlikePost.Location = new System.Drawing.Point(53, 301);
            this.buttonUnlikePost.Name = "m_ButtonUnlikePost";
            this.buttonUnlikePost.Size = new System.Drawing.Size(47, 23);
            this.buttonUnlikePost.TabIndex = 10;
            this.buttonUnlikePost.Text = "Unlike";
            this.buttonUnlikePost.UseVisualStyleBackColor = true;
            this.buttonUnlikePost.Click += new System.EventHandler(this.buttonUnlikePost_Click);
            // 
            // m_ButtonSendPost
            // 
            this.buttonSendPost.Location = new System.Drawing.Point(106, 301);
            this.buttonSendPost.Name = "m_ButtonSendPost";
            this.buttonSendPost.Size = new System.Drawing.Size(91, 23);
            this.buttonSendPost.TabIndex = 11;
            this.buttonSendPost.Text = "Send to friends";
            this.buttonSendPost.UseVisualStyleBackColor = true;
            this.buttonSendPost.Click += new System.EventHandler(this.buttonSendPost_Click);
            // 
            // m_ButtonDeleteAlbum
            // 
            this.buttonDeleteAlbum.Location = new System.Drawing.Point(221, 301);
            this.buttonDeleteAlbum.Name = "m_ButtonDeleteAlbum";
            this.buttonDeleteAlbum.Size = new System.Drawing.Size(93, 23);
            this.buttonDeleteAlbum.TabIndex = 12;
            this.buttonDeleteAlbum.Text = "Delete album";
            this.buttonDeleteAlbum.UseVisualStyleBackColor = true;
            this.buttonDeleteAlbum.Click += new System.EventHandler(this.buttonDeleteAlbum_Click);
            // 
            // m_ButtonInviteToGroup
            // 
            this.buttonInviteToGroup.Location = new System.Drawing.Point(319, 301);
            this.buttonInviteToGroup.Name = "m_ButtonInviteToGroup";
            this.buttonInviteToGroup.Size = new System.Drawing.Size(91, 23);
            this.buttonInviteToGroup.TabIndex = 13;
            this.buttonInviteToGroup.Text = "Send to friends";
            this.buttonInviteToGroup.UseVisualStyleBackColor = true;
            this.buttonInviteToGroup.Click += new System.EventHandler(this.buttonSendAlbumToFriends_Click);
            // 
            // m_ButtonUnlikePage
            // 
            this.buttonUnlikePage.Location = new System.Drawing.Point(428, 301);
            this.buttonUnlikePage.Name = "m_ButtonUnlikePage";
            this.buttonUnlikePage.Size = new System.Drawing.Size(92, 23);
            this.buttonUnlikePage.TabIndex = 14;
            this.buttonUnlikePage.Text = "Unlike Page";
            this.buttonUnlikePage.UseVisualStyleBackColor = true;
            this.buttonUnlikePage.Click += new System.EventHandler(this.buttonUnlikePage_Click);
            // 
            // m_ButtonInviteFreindsToLikePage
            // 
            this.buttonInviteFreindsToLikePage.Location = new System.Drawing.Point(526, 301);
            this.buttonInviteFreindsToLikePage.Name = "m_ButtonInviteFreindsToLikePage";
            this.buttonInviteFreindsToLikePage.Size = new System.Drawing.Size(91, 23);
            this.buttonInviteFreindsToLikePage.TabIndex = 15;
            this.buttonInviteFreindsToLikePage.Text = "Invite friends";
            this.buttonInviteFreindsToLikePage.UseVisualStyleBackColor = true;
            this.buttonInviteFreindsToLikePage.Click += new System.EventHandler(this.buttonInviteFreindsToLikePage_Click);
            // 
            // m_CheckedListBoxFriends
            // 
            this.checkedListBoxFriends.FormattingEnabled = true;
            this.checkedListBoxFriends.Location = new System.Drawing.Point(643, 61);
            this.checkedListBoxFriends.Name = "m_CheckedListBoxFriends";
            this.checkedListBoxFriends.Size = new System.Drawing.Size(170, 214);
            this.checkedListBoxFriends.TabIndex = 16;
            this.checkedListBoxFriends.Visible = false;
            // 
            // m_LabelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Location = new System.Drawing.Point(640, 45);
            this.labelFriends.Name = "m_LabelFriends";
            this.labelFriends.Size = new System.Drawing.Size(44, 13);
            this.labelFriends.TabIndex = 17;
            this.labelFriends.Text = "Friends:";
            this.labelFriends.Visible = false;
            // 
            // m_ButtonSendOrInvite
            // 
            this.buttonSendOrInvite.Location = new System.Drawing.Point(643, 301);
            this.buttonSendOrInvite.Name = "m_ButtonSendOrInvite";
            this.buttonSendOrInvite.Size = new System.Drawing.Size(75, 23);
            this.buttonSendOrInvite.TabIndex = 18;
            this.buttonSendOrInvite.UseVisualStyleBackColor = true;
            this.buttonSendOrInvite.Visible = false;
            this.buttonSendOrInvite.Click += new System.EventHandler(this.buttonSendOrInvite_Click);
            // 
            // FormSearchFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 348);
            this.Controls.Add(this.buttonSendOrInvite);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.checkedListBoxFriends);
            this.Controls.Add(this.buttonInviteFreindsToLikePage);
            this.Controls.Add(this.buttonUnlikePage);
            this.Controls.Add(this.buttonInviteToGroup);
            this.Controls.Add(this.buttonDeleteAlbum);
            this.Controls.Add(this.buttonSendPost);
            this.Controls.Add(this.buttonUnlikePost);
            this.Controls.Add(this.buttonLikePost);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.textBoxSearchLikedPage);
            this.Controls.Add(this.labelSearchLikedPages);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.textBoxSearchAlbum);
            this.Controls.Add(this.labelSearchAlbum);
            this.Controls.Add(this.textBoxSearchPost);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.labelSearchPost);
            this.Name = "FormSearchFeature";
            this.Text = "Search Engine Feature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchPost;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TextBox textBoxSearchPost;
        private System.Windows.Forms.Label labelSearchAlbum;
        private System.Windows.Forms.TextBox textBoxSearchAlbum;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelSearchLikedPages;
        private System.Windows.Forms.TextBox textBoxSearchLikedPage;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonLikePost;
        private System.Windows.Forms.Button buttonUnlikePost;
        private System.Windows.Forms.Button buttonSendPost;
        private System.Windows.Forms.Button buttonDeleteAlbum;
        private System.Windows.Forms.Button buttonInviteToGroup;
        private System.Windows.Forms.Button buttonUnlikePage;
        private System.Windows.Forms.Button buttonInviteFreindsToLikePage;
        private System.Windows.Forms.CheckedListBox checkedListBoxFriends;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Button buttonSendOrInvite;
    }
}