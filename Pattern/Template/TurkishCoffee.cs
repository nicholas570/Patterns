using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Template
{
    public class TurkishCoffee : CoffeeMaker
    {
        protected override void AddCoffee()
        {
            Console.WriteLine("J'ajoute directement le café dans la tasse.");
        }

        protected override void AddWater()
        {
            Console.WriteLine("J'ajoute de l'eau chaude dans la tasse.");
        }

        protected override void BrewCoffee()
        {
            Console.WriteLine("J'attend que le café infuse");
        }

        protected override void ServeCoffee()
        {
            Console.WriteLine("Le café est déjà dans ma tasse et pret a etre bu.");
        }
    }
}
