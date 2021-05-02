using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Template
{
    public class PressedCoffee : CoffeeMaker
    {
        protected override void AddCoffee()
        {
            Console.WriteLine("J'enlève le pressoir et j'ajoute le café dans le récipient.");
        }

        protected override void AddWater()
        {
            Console.WriteLine("J'ajoute de l'eau chaude dans le récipient.");
        }

        protected override void BrewCoffee()
        {
            Console.WriteLine("J'infuse le café et presse délicatement le café");
        }
    }
}
