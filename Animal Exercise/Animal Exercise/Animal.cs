using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Exercise
{
    public abstract class Animal
    {
        public Animal(int life, string name, float hunger)
        {
            Life = life;
            Name = name;
            Hunger = hunger;
        }
        public int Life { get; set; }
        public string Name { get; set; }
        public float Hunger { get; set; }
        public abstract string Move();

        public abstract string Poop();

        public abstract string Feed();

    }
}
