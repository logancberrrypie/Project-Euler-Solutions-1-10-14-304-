using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i =0;i<1000;i++)
            {
                if (i%3 == 0)
                {
                    total += i;
                } 
                else if (i%5 == 0)
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
