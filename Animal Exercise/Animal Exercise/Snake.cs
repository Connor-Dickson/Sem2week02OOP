using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Exercise
{
    class Snake : Reptile
    {
        public Snake(int life, string name, float hunger) 
            : base(life, name, hunger)
        {
            
        }

        public override string Move()
        {
            return "Slither";
        }
        public override string Poop()
        {
            return "Long and Brown with a White Tip";
        }
        public override string Feed()
        {
            return "Rodents";
        }
    }
}
