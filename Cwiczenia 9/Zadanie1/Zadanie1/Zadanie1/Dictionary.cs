using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Dictionary
    {
        public string[] Words { get; set; }

        public void LoadWords()
        {
            Words = System.IO.File.ReadAllLines("english2.txt");  // /bin/debug
            EachWordToLowerCase();
        }

        public void EachWordToLowerCase()
        {
            for(int i = 0; i < Words.Length; i++)
            {
                Words[i] = Words[i].ToLower();
            }
        }

        public bool Contains(string word)
        {
            return Words.Contains(word);
        }

    }
}
