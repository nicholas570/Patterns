using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    class Factory
    {
        public static void Run()
        {
            var type = CoffeeType.Turkish;
            var maker = CoffeeMakerFactory.Create(type);
            maker.Make();
        }
    }
}
