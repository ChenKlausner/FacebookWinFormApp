using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class Posts : IEnumerable<FullDataPost>
    {
        private User m_LoggedInUser;
        private List<FullDataPost> m_ListOfPostsWithFullData;

        public Func<FullDataPost, bool> FilterStrategy { get; set; }

        public Posts(User loggedInUser)
        {
            m_LoggedInUser = loggedInUser;
            initializeFullDataListPosts();
        }

        public IEnumerable<FullDataPost> GetFilteredEnumerator()
        {
            return m_ListOfPostsWithFullData.Where(FilterStrategy);
        }

        public IEnumerator<FullDataPost> GetEnumerator()
        {
            return m_ListOfPostsWithFullData.GetEnumerator();
        }

        public void RemoveFilter()
        {
            FilterStrategy = null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void initializeFullDataListPosts()
        {
            m_ListOfPostsWithFullData = new List<FullDataPost>();
            Random random = new Random();

            foreach (Post currPost in m_LoggedInUser.Posts)
            {
                if (currPost.Type != Post.eType.photo && (currPost.Message != null || currPost.Name != null))
                {
                    FullDataPost newPostWithFullData = new FullDataPost();
                    newPostWithFullData.Post = currPost;
                    newPostWithFullData.CommentsCount = random.Next(200);
                    newPostWithFullData.LikesCount = random.Next(500);
                    m_ListOfPostsWithFullData.Add(newPostWithFullData);
                }
            }
        }
    }
}
