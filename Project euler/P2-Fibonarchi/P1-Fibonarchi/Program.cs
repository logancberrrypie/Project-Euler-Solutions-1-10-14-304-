using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Fibonarchi
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 2;
            int total = 0;
            while (first < 4000000)
            {
                if (first % 2 == 0)
                {
                    total += first;
                }
                //Console.WriteLine(first);
                int temp = second;
                second = first + second;
                first = temp;
                
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
        
    }
}
