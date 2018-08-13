using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake Scott = new Snake(4, "Scott", 0.7f);
            Console.WriteLine("Snake Age: " + Convert.ToString(Scott.Life) + ", " + "Name: " + (Scott.Name) + ", " + "Hunger: "
                + (Scott.Hunger));

            Dog Doug = new Dog(8, "Doug", 0.1f, 4);
            Console.WriteLine("Dog Age: " + Convert.ToString(Doug.Life) + ", " + "Name: " + (Doug.Name) + ", " + "Hunger: "
                + (Doug.Hunger) + ", " + "Legs: " + (Doug.Legs));

            Cat Kat = new Cat(10, "Kat", 1f, 4);
            Console.WriteLine("Cat Age: " + Convert.ToString(Kat.Life) + ", "  + "Name: " + (Kat.Name) + ", " + "Hunger: " 
                + (Kat.Hunger) + ", " + "Legs: " + (Kat.Legs));

            
            Console.ReadLine();
        }
    }
}
