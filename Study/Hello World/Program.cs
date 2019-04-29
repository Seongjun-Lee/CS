using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow Wolrd");

            string name = "Bill";
            Console.WriteLine(name);

            name = "What";
            Console.WriteLine(name);

            Console.WriteLine("SHIT " + name);

            Console.WriteLine($"SHIT {name}");

            string enemy1 = "bob";
            string enemy2 = "king";

            Console.WriteLine($"{enemy1} and {enemy2}");

            Console.WriteLine($"{enemy1} has {enemy1.Length}");

            string test = "                       a h                             ";
            Console.WriteLine($"[{test}]");

            string trimmedtest = test.TrimStart();
            Console.WriteLine($"[{trimmedtest}]");

            trimmedtest = test.TrimEnd();
            Console.WriteLine($"[{trimmedtest}]");

            trimmedtest = test.Trim();
            Console.WriteLine($"[{trimmedtest}]");

            string hello = "hello ww";
            Console.WriteLine(hello.ToLower());
            hello = hello.Replace("hello", "what");
            Console.WriteLine(hello.ToUpper());

            Console.WriteLine(hello.Contains("what"));
            Console.WriteLine(hello.Contains("hello"));


        }
    }
}
