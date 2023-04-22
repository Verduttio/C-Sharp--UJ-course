using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class CorrectWord
    {
        public string Word { get; set; }
        public int Counts { get; set; }
        public CorrectWord(string word)
        {
            Word = word;
            Counts = 1;
        }

        public CorrectWord() { }
    }
}
