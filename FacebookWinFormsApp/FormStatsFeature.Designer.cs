namespace BasicFacebookFeatures
{
    abstract partial class FormStatsFeature
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
            this.buttonPopularPosts = new System.Windows.Forms.Button();
            this.buttonBestYears = new System.Windows.Forms.Button();
            this.buttonBestMonths = new System.Windows.Forms.Button();
            this.buttonBestDays = new System.Windows.Forms.Button();
            this.dataGridViewPostsStats = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ColumnLikesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ColumnComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ColumnDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_columnMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCalcBestDatesToPostLikes = new System.Windows.Forms.Button();
            this.labelPressOnDateToNotify = new System.Windows.Forms.Label();
            this.listBoxBestDatesToPost = new System.Windows.Forms.ListBox();
            this.buttonCalcBestDatesToPostComments = new System.Windows.Forms.Button();
            this.buttonCalcBestDatesToPostLikesAndComments = new System.Windows.Forms.Button();
            this.labelBestDatesChooser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostsStats)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPopularPosts
            // 
            this.buttonPopularPosts.Location = new System.Drawing.Point(66, 52);
            this.buttonPopularPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPopularPosts.Name = "buttonPopularPosts";
            this.buttonPopularPosts.Size = new System.Drawing.Size(140, 35);
            this.buttonPopularPosts.TabIndex = 1;
            this.buttonPopularPosts.Text = "Popular Posts";
            this.buttonPopularPosts.UseVisualStyleBackColor = true;
            this.buttonPopularPosts.Click += new System.EventHandler(this.buttonPopularPosts_Click);
            // 
            // buttonBestYears
            // 
            this.buttonBestYears.Location = new System.Drawing.Point(214, 52);
            this.buttonBestYears.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBestYears.Name = "buttonBestYears";
            this.buttonBestYears.Size = new System.Drawing.Size(112, 35);
            this.buttonBestYears.TabIndex = 5;
            this.buttonBestYears.Text = "Best Years";
            this.buttonBestYears.UseVisualStyleBackColor = true;
            this.buttonBestYears.Click += new System.EventHandler(this.buttonBestYears_Click);
            // 
            // buttonBestMonths
            // 
            this.buttonBestMonths.Location = new System.Drawing.Point(334, 52);
            this.buttonBestMonths.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBestMonths.Name = "buttonBestMonths";
            this.buttonBestMonths.Size = new System.Drawing.Size(177, 35);
            this.buttonBestMonths.TabIndex = 6;
            this.buttonBestMonths.Text = "Best Month To Post";
            this.buttonBestMonths.UseVisualStyleBackColor = true;
            this.buttonBestMonths.Click += new System.EventHandler(this.buttonBestMonths_Click);
            // 
            // buttonBestDays
            // 
            this.buttonBestDays.Location = new System.Drawing.Point(519, 52);
            this.buttonBestDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBestDays.Name = "buttonBestDays";
            this.buttonBestDays.Size = new System.Drawing.Size(158, 35);
            this.buttonBestDays.TabIndex = 7;
            this.buttonBestDays.Text = "Best Day To Post";
            this.buttonBestDays.UseVisualStyleBackColor = true;
            this.buttonBestDays.Click += new System.EventHandler(this.buttonBestDays_Click);
            // 
            // dataGridViewPostsStats
            // 
            this.dataGridViewPostsStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPostsStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.m_ColumnLikesCount,
            this.m_ColumnComments,
            this.m_ColumnDate,
            this.m_ColumnDay,
            this.m_columnMonth});
            this.dataGridViewPostsStats.Location = new System.Drawing.Point(40, 97);
            this.dataGridViewPostsStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPostsStats.Name = "dataGridViewPostsStats";
            this.dataGridViewPostsStats.Size = new System.Drawing.Size(966, 545);
            this.dataGridViewPostsStats.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.HeaderText = "Post / Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // m_ColumnLikesCount
            // 
            this.m_ColumnLikesCount.HeaderText = "Likes Count";
            this.m_ColumnLikesCount.Name = "m_ColumnLikesCount";
            this.m_ColumnLikesCount.ReadOnly = true;
            // 
            // m_ColumnComments
            // 
            this.m_ColumnComments.HeaderText = "Comments";
            this.m_ColumnComments.Name = "m_ColumnComments";
            this.m_ColumnComments.ReadOnly = true;
            // 
            // m_ColumnDate
            // 
            this.m_ColumnDate.HeaderText = "Date";
            this.m_ColumnDate.Name = "m_ColumnDate";
            // 
            // m_ColumnDay
            // 
            this.m_ColumnDay.HeaderText = "Day";
            this.m_ColumnDay.Name = "m_ColumnDay";
            this.m_ColumnDay.ReadOnly = true;
            // 
            // m_columnMonth
            // 
            this.m_columnMonth.HeaderText = "Month";
            this.m_columnMonth.Name = "m_columnMonth";
            this.m_columnMonth.ReadOnly = true;
            // 
            // buttonCalcBestDatesToPostLikes
            // 
            this.buttonCalcBestDatesToPostLikes.Location = new System.Drawing.Point(1016, 52);
            this.buttonCalcBestDatesToPostLikes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCalcBestDatesToPostLikes.Name = "buttonCalcBestDatesToPostLikes";
            this.buttonCalcBestDatesToPostLikes.Size = new System.Drawing.Size(182, 35);
            this.buttonCalcBestDatesToPostLikes.TabIndex = 9;
            this.buttonCalcBestDatesToPostLikes.Text = "For likes";
            this.buttonCalcBestDatesToPostLikes.UseVisualStyleBackColor = true;
            this.buttonCalcBestDatesToPostLikes.Click += new System.EventHandler(this.buttonCalcBestDatesToPostByLikes_Click);
            // 
            // labelPressOnDateToNotify
            // 
            this.labelPressOnDateToNotify.AutoSize = true;
            this.labelPressOnDateToNotify.Location = new System.Drawing.Point(1016, 497);
            this.labelPressOnDateToNotify.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPressOnDateToNotify.Name = "labelPressOnDateToNotify";
            this.labelPressOnDateToNotify.Size = new System.Drawing.Size(167, 20);
            this.labelPressOnDateToNotify.TabIndex = 10;
            this.labelPressOnDateToNotify.Text = "Press on date to notify";
            // 
            // listBoxBestDatesToPost
            // 
            this.listBoxBestDatesToPost.FormattingEnabled = true;
            this.listBoxBestDatesToPost.ItemHeight = 20;
            this.listBoxBestDatesToPost.Location = new System.Drawing.Point(1016, 186);
            this.listBoxBestDatesToPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxBestDatesToPost.Name = "listBoxBestDatesToPost";
            this.listBoxBestDatesToPost.Size = new System.Drawing.Size(178, 304);
            this.listBoxBestDatesToPost.TabIndex = 11;
            this.listBoxBestDatesToPost.SelectedIndexChanged += new System.EventHandler(this.listBoxBestDatesToPost_SelectedIndexChanged);
            // 
            // buttonCalcBestDatesToPostComments
            // 
            this.buttonCalcBestDatesToPostComments.Location = new System.Drawing.Point(1014, 97);
            this.buttonCalcBestDatesToPostComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCalcBestDatesToPostComments.Name = "buttonCalcBestDatesToPostComments";
            this.buttonCalcBestDatesToPostComments.Size = new System.Drawing.Size(182, 35);
            this.buttonCalcBestDatesToPostComments.TabIndex = 12;
            this.buttonCalcBestDatesToPostComments.Text = "For comments";
            this.buttonCalcBestDatesToPostComments.UseVisualStyleBackColor = true;
            this.buttonCalcBestDatesToPostComments.Click += new System.EventHandler(this.buttonCalcBestDatesToPostComments_Click);
            // 
            // buttonCalcBestDatesToPostLikesAndComments
            // 
            this.buttonCalcBestDatesToPostLikesAndComments.Location = new System.Drawing.Point(1020, 142);
            this.buttonCalcBestDatesToPostLikesAndComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCalcBestDatesToPostLikesAndComments.Name = "buttonCalcBestDatesToPostLikesAndComments";
            this.buttonCalcBestDatesToPostLikesAndComments.Size = new System.Drawing.Size(176, 35);
            this.buttonCalcBestDatesToPostLikesAndComments.TabIndex = 13;
            this.buttonCalcBestDatesToPostLikesAndComments.Text = "For likes + comments";
            this.buttonCalcBestDatesToPostLikesAndComments.UseVisualStyleBackColor = true;
            this.buttonCalcBestDatesToPostLikesAndComments.Click += new System.EventHandler(this.buttonCalcBestDatesToPostLikesAndComments_Click);
            // 
            // labelBestDatesChooser
            // 
            this.labelBestDatesChooser.AutoSize = true;
            this.labelBestDatesChooser.Location = new System.Drawing.Point(1034, 28);
            this.labelBestDatesChooser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBestDatesChooser.Name = "labelBestDatesChooser";
            this.labelBestDatesChooser.Size = new System.Drawing.Size(147, 20);
            this.labelBestDatesChooser.TabIndex = 14;
            this.labelBestDatesChooser.Text = "Best Dates To Post";
            // 
            // FormStatsFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.labelBestDatesChooser);
            this.Controls.Add(this.buttonCalcBestDatesToPostLikesAndComments);
            this.Controls.Add(this.buttonCalcBestDatesToPostComments);
            this.Controls.Add(this.listBoxBestDatesToPost);
            this.Controls.Add(this.labelPressOnDateToNotify);
            this.Controls.Add(this.buttonCalcBestDatesToPostLikes);
            this.Controls.Add(this.buttonBestDays);
            this.Controls.Add(this.buttonBestMonths);
            this.Controls.Add(this.buttonBestYears);
            this.Controls.Add(this.buttonPopularPosts);
            this.Controls.Add(this.dataGridViewPostsStats);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text = "Stats Feature";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostsStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button buttonPopularPosts;
        protected System.Windows.Forms.Button buttonBestYears;
        protected System.Windows.Forms.Button buttonBestMonths;
        protected System.Windows.Forms.Button buttonBestDays;
        protected System.Windows.Forms.DataGridView dataGridViewPostsStats;
        protected System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        protected System.Windows.Forms.DataGridViewTextBoxColumn columnLikesCount;
        protected System.Windows.Forms.DataGridViewTextBoxColumn columnComments;
        protected System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        protected System.Windows.Forms.DataGridViewTextBoxColumn columnDay;
        protected System.Windows.Forms.DataGridViewTextBoxColumn columnMonth;
        protected System.Windows.Forms.Button buttonCalcBestDatesToPostLikes;
        protected System.Windows.Forms.Label labelPressOnDateToNotify;
        protected System.Windows.Forms.ListBox listBoxBestDatesToPost;
        protected System.Windows.Forms.Button buttonCalcBestDatesToPostComments;
        protected System.Windows.Forms.Button buttonCalcBestDatesToPostLikesAndComments;
        protected System.Windows.Forms.Label labelBestDatesChooser;
        protected System.Windows.Forms.DataGridViewTextBoxColumn Name;
        protected System.Windows.Forms.DataGridViewTextBoxColumn m_ColumnLikesCount;
        protected System.Windows.Forms.DataGridViewTextBoxColumn m_ColumnComments;
        protected System.Windows.Forms.DataGridViewTextBoxColumn m_ColumnDate;
        protected System.Windows.Forms.DataGridViewTextBoxColumn m_ColumnDay;
        protected System.Windows.Forms.DataGridViewTextBoxColumn m_columnMonth;
    }
}