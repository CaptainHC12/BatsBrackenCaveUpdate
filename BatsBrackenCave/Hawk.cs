using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatsBrackenCave
{
    class Hawk : IConsumers, IGuano
    {
        int Weight, Amount;
        public void Eat()
        {
            
        }

        int IGuano.ProduceGuano()
        {
            return (Weight * Amount) + 1;
        }
    }
}
