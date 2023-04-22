using NUnit.Framework;
using System;
using Zadania;


namespace Zadanie5
{
    public class Tests
    {

        #region Zadanie 1
        [Test, Category("Zadanie 1")]
        public void TestConnectStringsFirstNull()
        {
            string first = null;
            string second = "second";
            string result = ConnectStringsClass.ConnectStrings(first, second);

            Assert.AreEqual(null, result);
        }

        [Test, Category("Zadanie 1")]
        public void TestConnectStringsSecondNull()
        {
            string first = "first";
            string second = null;
            string result = ConnectStringsClass.ConnectStrings(first, second);

            Assert.AreEqual(null, result);
        }

        [Test, Category("Zadanie 1")]
        public void TestConnectStringsAllNull()
        {
            string first = null;
            string second = null;
            string result = ConnectStringsClass.ConnectStrings(first, second);

            Assert.AreEqual(null, result);
        }

        [Test, Category("Zadanie 1")]
        public void TestConnectStringsNotNull()
        {
            string first = "first";
            string second = "second";
            string result = ConnectStringsClass.ConnectStrings(first, second);

            Assert.AreEqual("firstsecond", result);
        }
        #endregion Zadanie 1

        #region Zadanie 2
        [Test, Category("Zadanie 2")]
        public void TestConnectStringsExceptionFirstNull()
        {
            string first = null;
            string second = "second";

            TestDelegate test = () => ConnectStringsExceptionClass.ConnectStrings(first, second);
            Assert.Throws<ArgumentException>(test);
        }

        [Test, Category("Zadanie 2")]
        public void TestConnectStringsExceptionSecondNull()
        {
            string first = "first";
            string second = null;

            TestDelegate test = () => ConnectStringsExceptionClass.ConnectStrings(first, second);
            Assert.Throws<ArgumentException>(test);
        }

        [Test, Category("Zadanie 2")]
        public void TestConnectStringsExceptionAllNull()
        {
            string first = null;
            string second = null;

            TestDelegate test = () => ConnectStringsExceptionClass.ConnectStrings(first, second);
            Assert.Throws<ArgumentException>(test);
        }

        [Test, Category("Zadanie 2")]
        public void TestConnectStringsExceptionNotNull()
        {
            string first = "first";
            string second = "second";
            string result = ConnectStringsExceptionClass.ConnectStrings(first, second);

            Assert.AreEqual("firstsecond", result);
        }
        #endregion Zadanie 2

        #region Zadanie 3
        [Test, Category("Zadanie 3")]  // Wykryto b³¹d: System.IndexOutOfRangeException
        public void CheckIfAnagram1()
        {
            var anagramChecker = new AnagramChecker();
            string word1 = "Ala ma kota";
            string word2 = "atok am alA";
            bool result = anagramChecker.IsAnagram(word1, word2);

            Assert.AreEqual(true, result);
        }

        [Test, Category("Zadanie 3")]
        public void CheckIfAnagram2()
        {
            var anagramChecker = new AnagramChecker();
            string word1 = "AbCde";
            string word2 = "Abde";
            bool result = anagramChecker.IsAnagram(word1, word2);

            Assert.AreEqual(false, result);
        }

        [Test, Category("Zadanie 3")]  // Wykryto b³¹d: Expected: True | But was: False

        public void CheckIfAnagram3() 
        {
            var anagramChecker = new AnagramChecker();
            string word1 = "George Bush";
            string word2 = "He bugs Gore";
            bool result = anagramChecker.IsAnagram(word1, word2);

            Assert.AreEqual(true, result);
        }

        [Test, Category("Zadanie 3")]
        public void CheckIfAnagram4()
        {
            var anagramChecker = new AnagramChecker();
            string word1 = "aa";
            string word2 = "a";
            bool result = anagramChecker.IsAnagram(word1, word2);

            Assert.AreEqual(false, result);
        }

        [Test, Category("Zadanie 3")]
        public void CheckIfAnagram5()
        {
            var anagramChecker = new AnagramChecker();
            string word1 = "";
            string word2 = "a";
            bool result = anagramChecker.IsAnagram(word1, word2);

            Assert.AreEqual(false, result);
        }

        [Test, Category("Zadanie 3")]
        public void CheckIfAnagram6()
        {
            var anagramChecker = new AnagramChecker();
            string word1 = "Listen";
            string word2 = "Silent";
            bool result = anagramChecker.IsAnagram(word1, word2);

            Assert.AreEqual(true, result);
        }


        [Test, Category("Zadanie 3")]
        public void CheckIfAnagram7()
        {
            var anagramChecker = new AnagramChecker();
            string word1 = "123qwerty-+;'";
            string word2 = "qwerty";
            bool result = anagramChecker.IsAnagram(word1, word2);

            Assert.AreEqual(true, result);
        }

        [Test, Category("Zadanie 3")]
        public void CheckIfAnagram8()
        {
            var anagramChecker = new AnagramChecker();
            string word1 = "a";
            string word2 = null;
            bool result = anagramChecker.IsAnagram(word1, word2);

            Assert.AreEqual(false, result);
        }


        #endregion Zadanie 3

        // Testy do zadania 4 robione na dzieñ 2021-11-17 --18 update
        #region Zadanie 4
        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountOneDayYoung1()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "03311666297";
            bool result = dicountCalculator.HasDiscount(pesel);
            Assert.AreEqual(false, result);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountOneDayYoung2()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "03311717924";
            bool result = dicountCalculator.HasDiscount(pesel);
            Assert.AreEqual(false, result);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountOneDayYoung3()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "03311892128";
            bool result = dicountCalculator.HasDiscount(pesel);
            Assert.AreEqual(false, result);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountYearYoung1()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "04311616756";
            bool result = dicountCalculator.HasDiscount(pesel);
            Assert.AreEqual(true, result);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountYearYoung2()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "02311616912";
            bool result = dicountCalculator.HasDiscount(pesel);
            Assert.AreEqual(false, result);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountDayOld1()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "56111688936";
            bool result = dicountCalculator.HasDiscount(pesel);
            Assert.AreEqual(true, result);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountDayOld2()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "56111757742";
            bool result = dicountCalculator.HasDiscount(pesel);
            Assert.AreEqual(true, result);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountDayOld3()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "56111833961";
            bool result = dicountCalculator.HasDiscount(pesel);
            Assert.AreEqual(true, result);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountYearOld1()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "55111892657";
            bool result = dicountCalculator.HasDiscount(pesel);
            Assert.AreEqual(true, result);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountYearOld2()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "55111677416";
            bool result = dicountCalculator.HasDiscount(pesel);
            Assert.AreEqual(true, result);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountYearOld3()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "57111854484";
            bool result = dicountCalculator.HasDiscount(pesel);
            Assert.AreEqual(false, result);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountOldLeapYear1()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "56022995323";
            bool result = dicountCalculator.HasDiscount(pesel);
            Assert.AreEqual(true, result);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountInvalidPeselControllSum1()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "57111854483";
            TestDelegate test = () => dicountCalculator.HasDiscount(pesel);
            Assert.Throws<InvalidPeselException>(test);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountInvalidPeselControllSum2()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "55111677413";
            TestDelegate test = () => dicountCalculator.HasDiscount(pesel);
            Assert.Throws<InvalidPeselException>(test);
        }
        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountInvalidPeselControllSum3()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "57111854483";
            TestDelegate test = () => dicountCalculator.HasDiscount(pesel);
            Assert.Throws<InvalidPeselException>(test);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountInvalidPeselControllSum4()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "03311666290";
            TestDelegate test = () => dicountCalculator.HasDiscount(pesel);
            Assert.Throws<InvalidPeselException>(test);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountInvalidPeselDate1() 
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "03313266297";
            TestDelegate test = () => dicountCalculator.HasDiscount(pesel);
            Assert.Throws<InvalidPeselException>(test);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountInvalidPeselDate2()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "55022995323";
            TestDelegate test = () => dicountCalculator.HasDiscount(pesel);
            Assert.Throws<InvalidPeselException>(test);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountInvalidPeselTooLong()
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "033116662900";
            TestDelegate test = () => dicountCalculator.HasDiscount(pesel);
            Assert.Throws<InvalidPeselException>(test);
        }

        [Test, Category("Zadanie 4")]
        public void CheckIfDiscountInvalidPeselNotNumberChar() 
        {
            var dicountCalculator = new DiscountFromPeselComputer();
            string pesel = "033116d6290";
            TestDelegate test = () => dicountCalculator.HasDiscount(pesel);
            Assert.Throws<InvalidPeselException>(test);
        }

        //rok przestepny

        #endregion Zadanie 4
    }
}