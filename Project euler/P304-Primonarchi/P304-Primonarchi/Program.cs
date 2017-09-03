using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P304_Primonarchi
{
    class Program
    {
        static void Main(string[] args)
        {
            long total = 0;
            for (int i=0;i<1000;i++)
            {
               // total += b(i);
                Console.WriteLine(b(2));
            }

        }
        static long prime(long n)
        {
            bool flag = false;
            while (!flag)
            {
                flag = true;
                n++;
                if (!IsPrime(n))
                {
                    flag = false;
                }
            }
            //Console.WriteLine(n);
            return n;
        }

        static long a(long n)
        {
            if (n==1)
            {
                return prime(Convert.ToInt64(Math.Pow(10, 14)));
            }
            else
            {
                return prime(a(n - 1));
            }
        }

        static long fib(long n)
        {
            switch(n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    long a = 0;
                    long b = 1;
                    // In N steps compute Fibonacci sequence iteratively.
                    for (long i = 0; i < n; i++)
                    {
                        long temp = a;
                        a = b;
                        b = temp + b;
                        Console.WriteLine(a);
                    }
                    return a;

            }
        }
        static long b(long n)
        {
            return fib(a(n));
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
                    for (long i = 2; i < (long)Math.Ceiling(Math.Sqrt(number)); i++)
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
