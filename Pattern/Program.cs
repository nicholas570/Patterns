
using Patterns.Factory;
using Patterns.Strategy;
using Patterns.Template;
using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategy.Run();
            Template.Run();
            Factory.Run();
        }   
    }
}
