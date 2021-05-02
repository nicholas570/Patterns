using Patterns.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory
{
    public enum CoffeeType
    {
        Pressed,
        Turkish
    }
    public static class CoffeeMakerFactory
    {
        public static CoffeeMaker Create(CoffeeType coffeeType)
        {
            Console.WriteLine($"Je veux un café de type \"{coffeeType}\"");
            switch (coffeeType)
            {
                case CoffeeType.Pressed:
                    return new PressedCoffee();

                case CoffeeType.Turkish:
                    return new TurkishCoffee();

                default:
                    throw new Exception($"Le type de café '{coffeeType}' n'est pas réalisable");
            }
        }
    }
}
