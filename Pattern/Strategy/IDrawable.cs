using Patterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public interface IDrawable
    {
        List<Point> Points { get; }
    }
}
