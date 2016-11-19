using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            BestMethod();
            NotUsingMod();
        }

        public static void BestMethod()
        {
            int x = 0;
            Console.WriteLine(x);
            while (x != 100)
            {
                x++;

                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }

                if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }

                Console.WriteLine(x);
            }
            Console.ReadLine();
        }

        public static void NotUsingMod()
        {
            float y = 0;
            Console.WriteLine(y);
            while (y != 100)
            {
                y++;

                if (DivThree(y) == true)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }

                if (DivFive(y) == true)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }

        public static bool DivThree(float y)
        {
            for (int i = 3; i <= 100; i = i + 3)
            {
                if (i <= y)
                {
                    if (y / i == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool DivFive(float y)
        {
            for (int i = 5; i <= 100; i = i + 5)
            {
                if (i <= y)
                {
                    if (y / i == 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
