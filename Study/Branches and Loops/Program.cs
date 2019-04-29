using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branches_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;

            while(num <= 20)
            {
                if (num % 3 == 0)
                    sum += num;
                num++;
            }

            Console.WriteLine(sum);
        }
    }
}
