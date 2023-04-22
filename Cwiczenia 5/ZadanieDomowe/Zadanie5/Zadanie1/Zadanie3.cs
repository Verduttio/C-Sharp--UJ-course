using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    /**
* Interfejs obiektu który sprawdza czy dane słowa są anagramami. * Anagram
jest słowem lub frazą, która powstała
* przez zmianę kolejności liter w oryginalnym słowie lub frazie.
* Zobacz kilka przykładów na http://www.wordsmith.org/anagram/hof.html
*/
    public interface IAnagramChecker
    {
        /*Sprawdza czy jedno slowo jest anagramem drugiego.
        * Wszystkie niealfanumeryczne znaki są ignorowane.
        * Wielkość liter nie ma znaczenia.
        * word1 - dowolny niepusty string różny od null.
        * word2 - dowolny niepusty string różny od null.
        * Zwraca true wtedy i tylko wtedy gdy word1 jest anagramem word2.
        */
        bool IsAnagram(string word1, string word2);
    }




    public class AnagramChecker : IAnagramChecker
    {
        public bool IsAnagram(string word1, string word2)
        {
            if (word1 == null || word2 == null || word1.Length == 0 || word2.Length == 0)
            {
                Console.WriteLine("Invalid input");
                return false;
            }
            else
            {
                word1 = word1.ToLower();
                word2 = word2.ToLower();

                int[] lettersWord1 = CountLetters(word1);
                int[] lettersWord2 = CountLetters(word2);

                return Enumerable.SequenceEqual(lettersWord1, lettersWord2);
            }
        }

        public int AsciiConverterToArrayIndex(char ascii)
        {
            return ascii - 97;
        }

        public int[] CountLetters(string word)
        {
            var NumberOfLetterAppearence = new int [26];
            // Default value of an array in C# is zero or null

            foreach(char letter in word)
            {
                if(letter >= 'a' && letter <= 'z')
                    NumberOfLetterAppearence[AsciiConverterToArrayIndex(letter)]++;
            }

            return NumberOfLetterAppearence;
        }


    }
}
