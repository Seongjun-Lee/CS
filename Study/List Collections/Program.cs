using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Lee", "John", "Felix" };
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name}");
            }

            names.Add("Satan");
            names.Add("Oh");

            foreach(var name in names)
            {
                Console.WriteLine($"Bye {name}");
            }

            Console.WriteLine(names.Count);

            var notfound = names.IndexOf("Not Found");
            Console.WriteLine(notfound);

            names.Sort();
            
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            var number = new List<int> {1, 1};

            while (number.Count <= 20)
            {
                var prev1 = number[number.Count - 1];
                var prev2 = number[number.Count - 2];

                number.Add(prev1 + prev2);
            }

            foreach (var num in number)
                Console.WriteLine(num);




        }
    }
}
