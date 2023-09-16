namespace BasicFacebookFeatures
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using FacebookWrapper.ObjectModel;

    public partial class FormBestStatsFeature : FormStatsFeature
    {
        public FormBestStatsFeature(User i_LoggedInUser) : base(i_LoggedInUser)
        {
            InitializeComponent();
        }

        protected override bool equlaize(int i_FirstNum, int i_SecondNum)
        {
            return i_FirstNum < i_SecondNum;
        }

        protected override void initializeForm()
        {
            buttonPopularPosts.Text = "Popular posts";
            buttonBestYears.Text = "Best Years";
            buttonBestMonths.Text = "Best Month To Post";
            buttonBestDays.Text = "Best Day To Post";
            labelBestDatesChooser.Text = "Best Dates To Post";
        }

        protected override void sortDataGridView(string i_ColumnName)
        {
            dataGridViewPostsStats.Sort(dataGridViewPostsStats.Columns[i_ColumnName], ListSortDirection.Descending);
        }

        protected override string generateFirstNotifyMessage(DateTime i_SelectedDate)
        {
            return $"Do you want facebook to notify you at {i_SelectedDate} to post your post for maximum potential of likes?";
        }

        protected override string generateSecondNotifyMessage(DateTime i_SelectedDate)
        {
            return $"Facebook will notify you at {i_SelectedDate} to post your post. Good luck!";
        }
    }
}
