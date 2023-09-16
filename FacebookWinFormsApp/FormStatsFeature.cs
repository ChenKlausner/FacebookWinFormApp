using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public abstract partial class FormStatsFeature : Form
    {
        private readonly string r_EmptyData = " - - - - - ";
        private readonly int r_DaysInWeek = 7;
        private readonly int r_MonthsInYear = 12;
        private readonly int r_YearsToCalc = 10;
        private readonly Posts r_Posts;
        private User m_LoggedInUser;
        private string m_PrefFeatureDayToPostByLikes;
        private string m_PrefFeatureDayToPostByComments;
        private string m_PrefFeatureDayToPostByLikesAndComments;
        private int m_PrefFeatureMonthToPostByLikes = 0;
        private int m_PrefFeatureMonthToPostByComments = 0;
        private int m_PrefFeatureMonthToPostByLikesAndComments = 0;

        public int FilterNumber { get; set; }

        public FormStatsFeature(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            r_Posts = new Posts(m_LoggedInUser);
            initializeForm();
            FilterNumber = 0;
            strategyLikesCountChooser();
            r_Posts.FilterStrategy = (FullDataPost post) => post.LikesCount > FilterNumber;
        }

        private void strategyLikesCountChooser()
        {
            FormStrategyChooser formStrategyChooser = new FormStrategyChooser(this);

            formStrategyChooser.ShowDialog();
        }

        protected abstract void initializeForm();

        protected abstract bool equlaize(int i_FirstNum, int i_SecondNum);

        protected abstract void sortDataGridView(string i_ColumnName);

        protected abstract string generateFirstNotifyMessage(DateTime i_SelectedDate);

        protected abstract string generateSecondNotifyMessage(DateTime i_SelectedDate);

        private void buttonPopularPosts_Click(object sender, EventArgs e)
        {
            dataGridViewPostsStats.Rows.Clear();
            try
            {
                foreach (FullDataPost currPost in r_Posts.GetFilteredEnumerator())
                {
                    dataGridViewPostsStats.Rows.Add(currPost.Post.Message != null ? currPost.Post.Message : currPost.Post.Name, currPost.LikesCount, currPost.CommentsCount, currPost.Post.UpdateTime.Value.Date, currPost.Post.UpdateTime.Value.DayOfWeek, currPost.Post.UpdateTime.Value.Month);
                }

                sortDataGridView("m_ColumnLikesCount");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBestYears_Click(object sender, EventArgs e)
        {
            int likesCountInYear;
            int commentsCountInYear;

            dataGridViewPostsStats.Rows.Clear();
            for (int i = 1; i < r_YearsToCalc; i++)
            {
                likesCountInYear = 0;
                commentsCountInYear = 0;
                foreach (FullDataPost currPost in r_Posts.GetFilteredEnumerator())
                {
                    if (currPost.Post.UpdateTime.Value.Year == DateTime.Now.Year - i)
                    {
                        likesCountInYear += currPost.LikesCount;
                        commentsCountInYear += currPost.CommentsCount;
                    }
                }

                dataGridViewPostsStats.Rows.Add(
                DateTime.Now.Year - i,
                likesCountInYear,
                commentsCountInYear,
                r_EmptyData,
                r_EmptyData,
                r_EmptyData);
            }

            sortDataGridView("m_ColumnLikesCount");
        }

        private void buttonBestDays_Click(object sender, EventArgs e)
        {
            int preferdFeatureLikesInDay = 0;
            int preferdFeatureCommentsInDay = 0;
            int preferdFeatureLikesAndCommentsInDay = 0;
            int likesCountInDay = 0;
            int commentsCountInDay = 0;
            FullDataPost currentDayPost = null;

            dataGridViewPostsStats.Rows.Clear();
            for (int i = 0; i < r_DaysInWeek; i++)
            {
                likesCountInDay = 0;
                commentsCountInDay = 0;
                foreach (FullDataPost currPost in r_Posts.GetFilteredEnumerator())
                {
                    if ((int)currPost.Post.UpdateTime.Value.DayOfWeek == i)
                    {
                        currentDayPost = currPost;
                        likesCountInDay += currPost.LikesCount;
                        commentsCountInDay += currPost.CommentsCount;
                    }
                }

                if(i == 0)
                {
                    preferdFeatureLikesInDay = likesCountInDay;
                    preferdFeatureCommentsInDay = commentsCountInDay;
                    preferdFeatureLikesAndCommentsInDay = likesCountInDay + commentsCountInDay;
                    m_PrefFeatureDayToPostByLikes = currentDayPost.Post.UpdateTime.Value.DayOfWeek.ToString();
                    m_PrefFeatureDayToPostByComments = currentDayPost.Post.UpdateTime.Value.DayOfWeek.ToString();
                    m_PrefFeatureDayToPostByLikesAndComments = currentDayPost.Post.UpdateTime.Value.DayOfWeek.ToString();
                }

                if (equlaize(preferdFeatureLikesInDay, likesCountInDay))
                {
                    m_PrefFeatureDayToPostByLikes = currentDayPost.Post.UpdateTime.Value.DayOfWeek.ToString();
                    preferdFeatureLikesInDay = likesCountInDay;
                }

                if (equlaize(preferdFeatureCommentsInDay, commentsCountInDay))
                {
                    m_PrefFeatureDayToPostByComments = currentDayPost.Post.UpdateTime.Value.DayOfWeek.ToString();
                    preferdFeatureCommentsInDay = commentsCountInDay;
                }

                if (equlaize(preferdFeatureLikesAndCommentsInDay, likesCountInDay + commentsCountInDay))
                {
                    m_PrefFeatureDayToPostByLikesAndComments = currentDayPost.Post.UpdateTime.Value.DayOfWeek.ToString();
                    preferdFeatureLikesAndCommentsInDay = likesCountInDay + commentsCountInDay;
                }

                dataGridViewPostsStats.Rows.Add(((DayOfWeek)i).ToString(), likesCountInDay, commentsCountInDay, r_EmptyData, ((DayOfWeek)i).ToString(), r_EmptyData);
            }

            sortDataGridView("m_ColumnLikesCount");
        }
        
        private void buttonBestMonths_Click(object sender, EventArgs e)
        {
            int prefFeatureLikesInMonth = 0;
            int prefFeatureCommentsInMonth = 0;
            int prefFeatureLikesAndCommentsInMonth = 0;
            int likesCountInMonth = 0;
            int commentsCountInMonth = 0;

            dataGridViewPostsStats.Rows.Clear();
            for (int i = 1; i <= r_MonthsInYear; i++)
            {
                likesCountInMonth = 0;
                commentsCountInMonth = 0;
                foreach (FullDataPost currPost in r_Posts.GetFilteredEnumerator())
                {
                    if (currPost.Post.UpdateTime.Value.Month == i)
                    {
                        likesCountInMonth += currPost.LikesCount;
                        commentsCountInMonth += currPost.CommentsCount;
                    }
                }

                if (i == 1)
                {
                    prefFeatureLikesInMonth = likesCountInMonth;
                    prefFeatureCommentsInMonth = commentsCountInMonth;
                    prefFeatureLikesAndCommentsInMonth = likesCountInMonth + commentsCountInMonth;
                    m_PrefFeatureMonthToPostByLikes = i;
                    m_PrefFeatureMonthToPostByComments = i;
                    m_PrefFeatureMonthToPostByLikesAndComments = i;
                }

                if (equlaize(prefFeatureLikesInMonth, likesCountInMonth))
                {
                    m_PrefFeatureMonthToPostByLikes = i;
                    prefFeatureLikesInMonth = likesCountInMonth;
                }

                if (equlaize(prefFeatureCommentsInMonth, commentsCountInMonth))
                {
                    m_PrefFeatureMonthToPostByComments = i;
                    prefFeatureCommentsInMonth = commentsCountInMonth;
                }

                if (equlaize(prefFeatureLikesAndCommentsInMonth, likesCountInMonth + commentsCountInMonth))
                {
                    m_PrefFeatureMonthToPostByLikesAndComments = i;
                    prefFeatureLikesAndCommentsInMonth = likesCountInMonth + commentsCountInMonth;
                }

                dataGridViewPostsStats.Rows.Add(DateTimeFormatInfo.CurrentInfo.GetMonthName(i), likesCountInMonth, commentsCountInMonth, r_EmptyData, r_EmptyData, i);
            }

            sortDataGridView("m_ColumnLikesCount");
        }

        private List<DateTime> getDates(int i_Year, bool i_IsByLikes, bool i_IsByComments, bool i_IsByLikesAndComments)
        {
            List<DateTime> prefDatesToPost = new List<DateTime>();

            if (i_IsByLikes)
            {
                prefDatesToPost = calcDates(i_Year, m_PrefFeatureMonthToPostByLikes, m_PrefFeatureDayToPostByLikes);            
            }
            else if (i_IsByComments)
            {
                prefDatesToPost = calcDates(i_Year, m_PrefFeatureMonthToPostByComments, m_PrefFeatureDayToPostByComments);
            }
            else
            {
                prefDatesToPost = calcDates(i_Year, m_PrefFeatureMonthToPostByLikesAndComments, m_PrefFeatureDayToPostByLikesAndComments);
            }

            return prefDatesToPost;
        }

        private List<DateTime> calcDates(int i_Year, int i_Month, string i_Day)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(i_Year, i_Month))
            .Where(d => new DateTime(i_Year, i_Month, d).ToString("dddd").Equals(i_Day))
            .Select(d => new DateTime(i_Year, i_Month, d)).ToList();
        }

        private void populateListBox<DateTime>(ListBox i_ListBox, List<DateTime> i_Data)
        {
            i_ListBox.Items.Clear();
            try
            {
                foreach (DateTime currDate in i_Data)
                {
                    i_ListBox.Items.Add(currDate);
                }

                if (i_ListBox.Items.Count == 0)
                {
                    MessageBox.Show("Nothing to show.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxBestDatesToPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBestDatesToPost.SelectedItems.Count == 1)
            {
                DateTime selectedDate = (DateTime)listBoxBestDatesToPost.SelectedItem;
                DialogResult dialogResult = MessageBox.Show(generateFirstNotifyMessage(selectedDate), "Notifier", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult dialogResultYes = MessageBox.Show(generateSecondNotifyMessage(selectedDate), "Confirmation", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("please select one date to notify");
            }
        }

        private void buttonCalcBestDatesToPostByLikes_Click(object sender, EventArgs e)
        {
            bool isByLikes = true;
            bool isByComments = false;
            bool isByLikesAndComments = false;

            if (m_PrefFeatureDayToPostByLikes == null)
            {
                buttonBestDays_Click(sender, e);
            }

            if (m_PrefFeatureMonthToPostByLikes == 0)
            {
                buttonBestMonths_Click(sender, e);
            }

            populateListBox(listBoxBestDatesToPost, getDates(m_PrefFeatureMonthToPostByLikes > DateTime.Now.Month ? DateTime.Now.Year : DateTime.Now.Year + 1, isByLikes, isByComments, isByLikesAndComments));
        }

        private void buttonCalcBestDatesToPostComments_Click(object sender, EventArgs e)
        {
            bool isByLikes = false;
            bool isByComments = true;
            bool isByLikesAndComments = false;

            if (m_PrefFeatureDayToPostByComments == null)
            {
                buttonBestDays_Click(sender, e);
            }

            if (m_PrefFeatureMonthToPostByComments == 0)
            {
                buttonBestMonths_Click(sender, e);
            }

            populateListBox(listBoxBestDatesToPost, getDates(m_PrefFeatureMonthToPostByComments > DateTime.Now.Month ? DateTime.Now.Year : DateTime.Now.Year + 1, isByLikes, isByComments, isByLikesAndComments));
        }

        private void buttonCalcBestDatesToPostLikesAndComments_Click(object sender, EventArgs e)
        {
            bool isByLikes = false;
            bool isByComments = false;
            bool isByLikesAndComments = true;

            if (m_PrefFeatureDayToPostByLikesAndComments == null)
            {
                buttonBestDays_Click(sender, e);
            }

            if (m_PrefFeatureMonthToPostByLikesAndComments == 0)
            {
                buttonBestMonths_Click(sender, e);
            }

            populateListBox(listBoxBestDatesToPost, getDates(m_PrefFeatureMonthToPostByLikesAndComments > DateTime.Now.Month ? DateTime.Now.Year : DateTime.Now.Year + 1, isByLikes, isByComments, isByLikesAndComments));
        }
    }
}