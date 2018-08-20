using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            List<int> digits = new List<int>();



            try
            {
                if(int.Parse(num) <= 0)
                {
                    throw new LessThanZeroException();
                }
                if(int.Parse(num) > 15)
                {
                    throw new AboveException();
                }
                foreach (char var in num)
                {
                    int digit = int.Parse(var.ToString());
                    digits.Add(digit);
                }
                /*foreach(int digit in digits)
                {
                    Console.WriteLine(digit);
                }*/
                
                int sum = digits.Sum();
                Console.WriteLine(sum);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (LessThanZeroException lzex)
            {
                Console.WriteLine(lzex.Message);
            }
            catch (AboveException abex)
            {
                Console.WriteLine(abex.Message);
            }
            finally
            {
                Console.WriteLine(DateTime.Now);
                Console.ReadLine();
            }
            
        }

        public class LessThanZeroException : Exception
        {
            public LessThanZeroException() : base("Input was Zero or Less")
            {

            }
        }
        public class AboveException : Exception
        {
            public AboveException() : base("Input was above 15")
            {

            }
        } 

        
    }
}
