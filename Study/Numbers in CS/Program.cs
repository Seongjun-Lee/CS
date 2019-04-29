using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 29;
            int c = a + b;
            int d = (a + b) / c;
            int e = (a + b) % c;

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"Max : {max} and Min : {min}");

            int over = max + 3;

            Console.WriteLine(over);

            double z = 5;
            double x = 10;
            double v = 8;
            double y = (z + x) / v;
            Console.WriteLine(y);

            double maxd = double.MaxValue;
            double mind = double.MinValue;

            Console.WriteLine($"Max : {maxd} and Min : {mind}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            decimal mindec = decimal.MinValue;
            decimal maxdec = decimal.MaxValue;

            Console.WriteLine($"Decimal : {mindec} ~ {maxdec}");

            double ad = 1.0;
            double bd = 3.0;

            decimal adec = 1.0M;
            decimal bdec = 3.0M;

            Console.WriteLine($"double : {ad / bd} and decimal : {adec / bdec}");

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }
    }
}
