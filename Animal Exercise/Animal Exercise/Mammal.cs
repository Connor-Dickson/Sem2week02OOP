﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Exercise
{
    public abstract class Mammal : Animal
    {
        public Mammal(int life, string name, float hunger) 
            : base(life, name, hunger)
        {

        }
    }
}
