using System;
using System.Linq;

namespace Training
{
    class Program
    {
        private static int[] Numbers = { 4, 8, 15, 16, 23, 42, 108 };

        static void Main(string[] args)
        {
            LinqQuerySyntax();
        }

        private static void LinqQuerySyntax() 
        {
            var even = 
                from n in Numbers
                where n % 2 == 0
                orderby n descending
                select n;

            Console.WriteLine("----- LINQ Query Syntax -----");
            Console.WriteLine(string.Join(", ", even));
            Console.WriteLine();
        }
    }
}
