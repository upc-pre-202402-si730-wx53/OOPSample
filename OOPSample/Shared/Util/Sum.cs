using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample.Shared.Util
{
    public delegate void SumDelegate(int a, int b);
    public class Sum
    {
        public static void _Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void _Sum2(int a, int b)
        {
            Console.WriteLine(a + b + 3);
        }

        public static void _Sum3(Func<int, int, int> func)
        {
            Console.WriteLine(func.Invoke(1,2));
        }
    }
}
