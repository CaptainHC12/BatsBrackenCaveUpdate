using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatsBrackenCave
{
    class Person
    {
        public string Name = "Player";
        // Got help from Janell with the tutoring 
        List<Items> Inventory = new List<Items>() {
            new Items() {Name = "Corn", Description = "Food that the bats can eat", Value = 5 },
                        new Items() {Name = "Cotton", Description = "The player can give to the bats", Value = 3 }

        };
    }
}
