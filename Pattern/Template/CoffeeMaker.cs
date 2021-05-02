using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Template
{
    public abstract class CoffeeMaker
    {
        public void Make()
        {
            AddCoffee();
            AddWater();
            BrewCoffee();
            ServeCoffee();
        }

        protected abstract void AddCoffee();
        protected abstract void AddWater();
        protected abstract void BrewCoffee();
        // We can override it but this step will often be the same
        protected virtual void ServeCoffee()
        {
            Console.WriteLine("Je verse le café dans la tasse.");
        }
    }
}
