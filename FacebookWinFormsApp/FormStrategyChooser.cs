using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class FormStrategyChooser : Form
    {
        private Button buttonSubmit;
        private Label labelComment;
        private TextBox textBoxLikesCount;
        private Label labelChoose;
        private FormStatsFeature m_FormStatsFeature;

        public FormStrategyChooser(FormStatsFeature i_FormStatsFeature)
        {
            InitializeComponent();
            m_FormStatsFeature = i_FormStatsFeature;
        }
        private void buttonSubmit_Click(object sender, System.EventArgs e)
        {
            int filterLikeCountNumber;

            if (textBoxLikesCount.Text == null || !int.TryParse(textBoxLikesCount.Text, out filterLikeCountNumber))
            {
                MessageBox.Show($"Please enter a number", "Notifier", MessageBoxButtons.OK);
            }
            else
            {
                int.TryParse(textBoxLikesCount.Text, out filterLikeCountNumber);
                m_FormStatsFeature.FilterNumber = filterLikeCountNumber;
                this.Dispose();
            }
        }

        private void InitializeComponent()
        {
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelChoose = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxLikesCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(204, 116);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Location = new System.Drawing.Point(13, 13);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(192, 20);
            this.labelChoose.TabIndex = 1;
            this.labelChoose.Text = "Please choose a like-filter:";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(13, 33);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(324, 20);
            this.labelComment.TabIndex = 2;
            this.labelComment.Text = "(stats will be on posts with higher likes count)";
            // 
            // textBoxLikesCount
            // 
            this.textBoxLikesCount.Location = new System.Drawing.Point(87, 114);
            this.textBoxLikesCount.Name = "textBoxLikesCount";
            this.textBoxLikesCount.Size = new System.Drawing.Size(100, 26);
            this.textBoxLikesCount.TabIndex = 3;
            // 
            // FormStrategyChooser
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.textBoxLikesCount);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "FormStrategyChooser";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}