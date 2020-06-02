using System;
using System.Collections.Generic;
using System.Linq;

namespace LastQuestion
{
    class Program
    {
        public static Func<string, int, bool> pred = (string s, int i) => s.Length >= i; 
        static void Main(string[] args)
        {
            IEnumerable<string> lst = new List<string>{ "a", "ab", "abc" };

            Console.WriteLine(ReturnFirstStrSatisfyingCond(2, lst, pred).GetType());
        }

        public static string ReturnFirstStrSatisfyingCond(int n, IEnumerable<string> lst, Func<string, int, bool> pred)
        {
           return lst.Where(s => pred(s, n)).First(); 
        }
    }
}
