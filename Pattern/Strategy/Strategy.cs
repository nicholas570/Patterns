using Patterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class Strategy
    {
        //https://www.dofactory.com/net/strategy-design-pattern
        public static void Run()
        {
            var canvas = new Canvas();

            canvas.SetBrush(new Pencil());
            canvas.DrawLine(3, 7, 2, 5);

            canvas.SetBrush(new PaintBrush());
            canvas.DrawLine(7, 3, 15, 2);

            var rect = new Rectangle(new Point(2, 3), new Point(10, 10));
            canvas.DrawShape(rect);
        }
    }

    

 

  


}
