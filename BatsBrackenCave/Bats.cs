using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatsBrackenCave
{
    class Bats : IGuano, IConsumers
    {
        
        int Weight, Amount;
        public void Eat()
        {
            
        }

        //Got from Canvas https://canvas.colum.edu/courses/26162/pages/interfaces-final-project-example?module_item_id=1561392
        //Got help from Grace from Tutoring
        int IGuano.ProduceGuano()
        {
            return (Weight * Amount) + 1;
        }
    }
}
