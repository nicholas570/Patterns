using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class Pencil : IBrush
    {
        public void Draw(int x, int y)
        {
            // En réalité, on aurait un algo pour définir le tracé fin d'un crayon
            Console.WriteLine($"I use a PEN to draw at position {x}; {y}");
        }
    }

    public class PaintBrush : IBrush
    {
        public void Draw(int x, int y)
        {
            // En réalité, on aurait un algo pour définir comment les poils du pinceau aj
            Console.WriteLine($"I use a BRUSH to draw at position  {x}; {y}");
        }
    }
}
