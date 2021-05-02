using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class Rectangle : IDrawable
    {
        public List<Point> Points => new List<Point>();

        public Rectangle(Point topLeftHandCorner, Point bottomRightHandCorner)
        {
            Points.Add(topLeftHandCorner);
            Points.Add(new Point(topLeftHandCorner.X, bottomRightHandCorner.Y));
            Points.Add(bottomRightHandCorner);
            Points.Add(new Point(bottomRightHandCorner.X, topLeftHandCorner.Y));
        }
    }
}
