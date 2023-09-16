using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PostProxy
    {
        private Post m_Post;

        public PostProxy(Post i_Post)
        {
            m_Post = i_Post;
        }

        public Post Post { get => m_Post; }

        public string Message
        {
            get { return m_Post.Message; }
        }

        public string Caption
        {
            get { return m_Post.Caption; }
        }

        public DateTime? DateTime
        {
            get { return m_Post.UpdateTime; }
        }

        public override string ToString()
        {
            StringBuilder sbPost = new StringBuilder();

            if (m_Post.Message != null)
            {
                sbPost.Append(m_Post.Message);
            }
            else if (m_Post.Caption != null)
            {
                sbPost.Append(m_Post.Caption);
            }
            else if (m_Post.Type != null)
            {
                sbPost.Append(string.Format($"{m_Post.Type}"));
            }

            return string.Format(@"{0} | {1}", DateTime, sbPost.ToString());
        }
    }
}
