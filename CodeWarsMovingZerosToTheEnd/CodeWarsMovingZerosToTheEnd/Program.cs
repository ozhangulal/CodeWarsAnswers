using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsMovingZerosToTheEnd
{
    class Program
    {

        public static int[] MoveZeroes(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            foreach (var item in MoveZeroes(arr))
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }
    }
}
