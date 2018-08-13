using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Exercise
{
    class Cat : Mammal
    {
        public int Legs { get; set; }

        public Cat(int life, string name, float hunger, int legs) : base(life, name, hunger)
        {

        }
        public override string Move()
        {
            return "Walk";
        }

        public override string Poop()
        {
            return "Cat Poop";
        }

        public override string Feed()
        {
            return "Cat Food";
        }
    }
}
