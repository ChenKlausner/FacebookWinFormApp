using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class Trie
    {
        public class TrieNode
        {
            private Dictionary<char, TrieNode> m_Children;
            private char m_Character;
            private bool m_IsWord;

            public bool IsWord { get => m_IsWord; set => m_IsWord = value; }

            public char Character { get => m_Character; set => m_Character = value; }

            public Dictionary<char, TrieNode> Children { get => m_Children; set => m_Children = value; }

            public TrieNode(char i_Charater)
            {
                this.m_Character = i_Charater;
                m_Children = new Dictionary<char, TrieNode>();
            }

            public TrieNode()
            {
                m_Children = new Dictionary<char, TrieNode>();
            }

            public void Insert(string i_Word)
            {
                if (i_Word == null || i_Word.Length == 0)
                {
                    return;
                }

                char firstChar = i_Word[0];

                m_Children.TryGetValue(firstChar, out TrieNode child);

                if (child == null)
                {
                    child = new TrieNode(firstChar);
                    m_Children.Add(firstChar, child);
                }

                if (i_Word.Length > 1)
                {
                    child.Insert(i_Word.Substring(1));
                }
                else
                {
                    child.m_IsWord = true;
                }
            }
        }

        private TrieNode m_Root;

        public Trie(List<string> i_Words)
        {
            m_Root = new TrieNode();
            foreach (string word in i_Words)
            {
                m_Root.Insert(word);
            }
        }

        public void SuggestHelper(TrieNode i_Root, List<string> i_List, StringBuilder i_CurrentWord)
        {
            if (i_Root.IsWord)
            {
                i_List.Add(i_CurrentWord.ToString());
            }

            if (i_Root.Children == null || i_Root.Children.Count == 0)
            {
                return;
            }

            foreach (TrieNode child in i_Root.Children.Values)
            {
                SuggestHelper(child, i_List, i_CurrentWord.Append(child.Character));
                i_CurrentWord.Length = i_CurrentWord.Length - 1;
            }
        }

        public List<string> Suggest(string i_Prefix)
        {
            List<string> list = new List<string>();
            TrieNode lastNode = m_Root;
            StringBuilder curr = new StringBuilder();

            foreach (char c in i_Prefix.ToCharArray())
            {
                lastNode.Children.TryGetValue(c, out lastNode);
                if (lastNode == null)
                {
                    return list;
                }

                curr.Append(c);
            }

            SuggestHelper(lastNode, list, curr);

            return list;
        }
    }
}
