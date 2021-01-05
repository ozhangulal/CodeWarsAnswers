using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsMultiplesof3or5
{
    class Program
    {
        public static int Solution(int value)
        {
            return Enumerable.Range(0, value).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));
            Console.ReadLine();
        }
    }
}
