using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descending_order_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 2, 4, 1, 6 };
            Array.Sort(a);
            Array.Reverse(a);
            foreach(var str in a)
            {
                Console.Write(str.ToString());
            }
        }
    }
}
