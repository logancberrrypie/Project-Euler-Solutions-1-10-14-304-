using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_LargestPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 600851475143;
            //long number = 13195;
            //Only need to check up to the square root fo the number and going down from that value
            for (long i=(long)Math.Ceiling(Math.Sqrt(number)); i>1;i--)
            {
                //a integer multiple and odd
                if ((number % i ==0) && (i%2 != 0))
            {
                    if (IsPrime(i))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    
            }

            }
            Console.WriteLine("ended");
            Console.ReadLine();
        }
        //Checks if the input number is prime and returns a boolean based on its outcome
        static Boolean IsPrime(long number)
        {
            switch(number)
            {
                case 1:
                    return false;
                case 2:
                    return true;
                default:
                    for (long i =2;i<(long)Math.Ceiling(Math.Sqrt(number));i++)
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
