using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Exercise
{
    class Dog : Mammal
    {
        public int Legs { get; set; }

        public Dog(int life, string name, float hunger, int legs) : base(life, name, hunger)
        {

        }
        public override string Move()
        {
            return "Walk";
        }

        public override string Poop()
        {
            return "Dog Poop";
        }

        public override string Feed()
        {
            return "Dog Food";
        }
    }
}
