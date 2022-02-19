using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void funcshion(int x)
        {
            int r = 0;
            while (x != 0)
            {
                double a = x % 10;
                x /= 10;
                double s = x % 10;
                if (s < a) { r = 1; } else { r = 0; }
                if (r == 0) { break; }
            }
            if (r == 1) { Console.WriteLine("Yes"); } else { Console.WriteLine("No"); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = int.Parse(Console.ReadLine());
            funcshion(x);
            Console.ReadLine();
        }
    }
}
