using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    public static class ConnectStringsExceptionClass
    {
        public static string ConnectStrings(string first, string second)
        {
            if (first == null || second == null)
                throw new ArgumentException("Arguments should not be null");
            else
                return first + second;
        }
    }
}
