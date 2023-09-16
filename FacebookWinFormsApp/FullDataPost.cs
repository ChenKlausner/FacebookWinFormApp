using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FullDataPost
    {
        private Post m_Post;
        private int m_LikesCount;
        private int m_CommentsCount;

        public Post Post
        {
            get
            {
                return m_Post;
            }

            set
            {
                m_Post = value;
            }
        }

        public int LikesCount
        {
            get
            {
                return m_LikesCount;
            }

            set
            {
                m_LikesCount = value;
            }
        }

        public int CommentsCount
        {
            get
            {
                return m_CommentsCount;
            }

            set
            {
                m_CommentsCount = value;
            }
        }
    }
}
