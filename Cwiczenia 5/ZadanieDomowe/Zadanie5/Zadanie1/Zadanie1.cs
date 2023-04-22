using System;

namespace Zadania
{
    public static class ConnectStringsClass
    {
        public static string ConnectStrings(string first, string second)
        {
            if (first == null || second == null)
                return null;
            else
                return first + second;
        }
    }

}
