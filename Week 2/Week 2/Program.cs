using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 0;
            int primeSum = 0;
            for (int i = 0; i <= 7;)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                if (sum != 0 && sum != 1)
                {
                    for (int divisor = 2; divisor < 10; divisor++)
                    {
                        if (sum % divisor != 0)
                        {
                            primeSum += sum;
                            i++;
                        }
                        
                    }
                }
            }
               
            Console.WriteLine(primeSum);
            Console.ReadLine();
        }
    }
}
