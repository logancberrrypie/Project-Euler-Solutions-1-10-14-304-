using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_10001Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            long running = 2;
            int i = 2;
            while (i <= 2000000)
            {
                i++;
                if (IsPrime(i))
                {
                    running += i;
                    total++;
                }

            }
            Console.WriteLine(running);
            Console.ReadLine();
        }
        static Boolean IsPrime(long number)
        {
            switch (number)
            {
                case 1:
                    return false;
                case 2:
                    return true;
                default:
                    for (long i = 2; i <= (long)Math.Ceiling(Math.Sqrt(number)); i++)
                    {
                        if (number % i == 0)
                        {
                            return false;
                        }
                    }
                    return true;
            }
        }



    }
}
