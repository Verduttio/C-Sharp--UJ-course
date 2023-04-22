using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class WordVerifier
    {
        public List<string> DivideStringIntoWords(string wordsAll)
        {
            var words = new List<string>();
            bool wordStarted = false;
            int wordStartedIndex = 0;
            for(int i = 0; i < wordsAll.Length; i++)
            {
                if(wordStarted == false && !IsPunctuationMark(wordsAll.ElementAt(i)))
                {
                    wordStarted = true;
                    wordStartedIndex = i;
                }
                else if (wordStarted == true && IsPunctuationMark(wordsAll.ElementAt(i)))
                {
                    words.Add(wordsAll.Substring(wordStartedIndex, i - wordStartedIndex));
                    wordStarted = false;
                }
            }
            if(wordStarted)
                words.Add(wordsAll.Substring(wordStartedIndex));

            return words;
            
        }

        public bool IsPunctuationMark(char mark)
        {
            return (mark == '.' || mark == ':' || mark == ';' || mark == '-' ||
                    mark == '"' || mark == '\'' || mark == '(' || mark == ')' ||
                    mark == '?' || mark == '!' || mark == ',' || mark == '[' ||
                    mark == ']' || mark == '{' || mark == '}' || mark == '\n' ||
                    mark == ' ');
        }


    }
}
