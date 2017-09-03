using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Collatz__Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop going up to 1 million

            int CurrentLongestChain = 0;
            int currentNum = 0;
            int chain = 0;
            for (int i =0;i< 1000000; i++)
            {
                chain = collatz(i);
                if (chain > CurrentLongestChain)
                {
                    CurrentLongestChain = chain;
                    currentNum = i;
                }
            }
            Console.WriteLine(currentNum);
            Console.WriteLine(chain);
            Console.WriteLine(collatz(837799));
            Console.ReadLine();
            
        }

        static int collatz(int n)
        {
            int chain = 1;
            while (n > 1)
            {
                //When even
                if (n%2 == 0)
                {
                    n = n / 2;
                    chain++;
                }
                //When odd
                else
                {
                    n = 3 * n + 1;
                    chain++;
                }
            }
            return chain;
        }
    }
}
