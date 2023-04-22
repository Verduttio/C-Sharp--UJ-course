using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    public interface IDiscountFromPeselComputer
    {
        bool HasDiscount(String pesel);
    }

    public class InvalidPeselException : Exception
    {
        public InvalidPeselException(string message) : base(message) { }
    }


    public class DiscountFromPeselComputer : IDiscountFromPeselComputer
    {

        public bool HasDiscount(string pesel)
        {
            if (!CheckPeselCorrectness(pesel)) throw new InvalidPeselException("Invalid pesel.");

            if (!(HasLessThan18Years(pesel) || HasMoreThan65Years(pesel))) return false; 

            return true;
        }

        public bool CheckPeselCorrectness(string pesel)
        {
            if (!CheckLength(pesel)) return false;
            if (!OnlyDigitsInPesel(pesel)) return false;
            if (!CheckControllSum(pesel)) return false;
            if (!CheckDateCorrectness(pesel)) return false;
            return true;
        }

        public bool CheckControllSum(string pesel)
        {
            return (GetDigit(pesel, 10) == CalculateControllSum(pesel));
        }

        public int GetDigit(string pesel, int position)
        {
            // First position is position No. 0
            return int.Parse(pesel.Substring(position, 1));
        }

        public bool OnlyDigitsInPesel(string pesel)
        {
            foreach(char letter in pesel)
            {
                if(!(letter >= '0' && letter <= '9')) return false;
            }
            return true;
        }

        public int CalculateControllSum(string pesel)
        {
            var weights = new int[10] {1,3,7,9,1,3,7,9,1,3};
            int wageSum = 0;
            for(int i = 0; i <= 9; i++)
            {
                wageSum += weights[i] * GetDigit(pesel, i);
            }

            int m = wageSum % 10;

            if (m == 0)
                return 0;
            else
                return 10 - m;
        }

        public bool CheckDateCorrectness(string pesel)
        {
            // Dates correctness since 1900 to 2099
            int year = int.Parse(pesel.Substring(0, 2));
            int month = int.Parse(pesel.Substring(2, 2));
            int day = int.Parse(pesel.Substring(4, 2));

            if (month <= 12) {
                year += 1900;
            }
            else if (month >= 21 && month <= 32) {
                year += 2000;
                month -= 20;
            }
            else
            {
                return false;
            }

            bool leapYear = IsLeapYear(year);
            if (leapYear && month == 2 && day > 29) return false;

            if (!leapYear && month == 2 && day > 28) return false;

            if (month <= 7 && month % 2 == 0 && day > 30) return false;

            if (month % 2 == 1 && day > 30) return false;

            if (day > 31) return false;

            // Pesel's date cannot be from the future
            DateTime currentDate = DateTime.Now;
            DateTime peselDate = new DateTime(year, month, day);
            if (DateTime.Compare(currentDate, peselDate) < 0) return false;

            return true;

        }

        public bool IsLeapYear(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));
        }

        public bool CheckLength(string pesel)
        {
            return pesel.Length == 11;
        }

        public (int year, int month, int day) GetDate(string pesel)
        {
            int year = int.Parse(pesel.Substring(0, 2));
            int month = int.Parse(pesel.Substring(2, 2));
            int day = int.Parse(pesel.Substring(4, 2));

            if (month <= 12)
            {
                year += 1900;
            }
            else if (month >= 21 && month <= 32)
            {
                year += 2000;
                month -= 20;
            }

            return (year: year, month: month, day: day);
        }

        public bool HasMoreThan65Years(string pesel)
        {
            (int year, int month, int day) personBirthday = GetDate(pesel);
            DateTime currentDate = DateTime.Now;

            if (personBirthday.year < currentDate.Year - 65) return true;
            else if (personBirthday.year == currentDate.Year - 65)
            {
                if (personBirthday.month < currentDate.Month) return true;
                else if (personBirthday.month == currentDate.Month)
                {
                    if (personBirthday.day <= currentDate.Day) return true;
                    else return false;
                }
                else return false;
            }
            else return false;
        }

        public bool HasLessThan18Years(string pesel)
        {
            (int year, int month, int day) personBirthday = GetDate(pesel);
            DateTime currentDate = DateTime.Now;

            if (personBirthday.year > currentDate.Year - 18) return true;
            else if (personBirthday.year == currentDate.Year - 18)
            {
                if (personBirthday.month < currentDate.Month) return true;
                else if (personBirthday.month == currentDate.Month)
                {
                    if (personBirthday.day > currentDate.Day) return true;
                    else return false;
                }
                else return false;
            }
            else return false;
        }


    }
}
