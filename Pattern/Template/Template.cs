using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Template
{
    class Template
    {
        public static void Run()
        {
            CoffeeMaker maker = new TurkishCoffee();
            maker.Make();
            maker = new PressedCoffee();
            maker.Make();
        }
    }
}
