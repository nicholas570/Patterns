using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class Canvas
    {
        private IBrush _brush;
        public void SetBrush(IBrush brush)
        {
            _brush = brush;
        }

        public void DrawDot(int x, int y)
        {
            _brush.Draw(x, y);
        }

        public void DrawShape(IDrawable drawable)
        {
            for (int i = 0; i < drawable.Points.Count - 1; i++)
            {
                DrawLine(drawable.Points[i].X, drawable.Points[i + 1].X,
                    drawable.Points[i].Y, drawable.Points[i + 1].Y);
            }
        }
        public void DrawLine(int x1, int x2, int y1, int y2)
        {
            decimal deltaX = x2 - x1;
            int xSign = GetSignedValue(deltaX);
            decimal deltaY = y2 - y1;
            int ySign = GetSignedValue(deltaY);

            if (deltaX != 0)
            {
                DrawLineAccordingToX(x1, y1, y2, deltaX, xSign, deltaY, ySign);
            }
            else if (deltaY != 0)
            {
                DrawLineAccordingToY(x1, x2, y1, deltaX, xSign, deltaY, ySign);
            }
            else
            {
                DrawDot(x1, y1);
            }
        }

        private void DrawLineAccordingToX(int x1, int y1, int y2, decimal deltaX, int xSign, decimal deltaY, int ySign)
        {
            int y;
            int slope = (int)Math.Round(Math.Abs(deltaY / deltaX));
            for (int i = 0; i <= Math.Abs(deltaX); i++)
            {
                if (i < Math.Abs(deltaX))
                    y = y1 + ySign * slope * i;
                else
                    y = y2;
                DrawDot(x1 + xSign * i, y);
            }
        }

        private void DrawLineAccordingToY(int x1, int x2, int y1, decimal deltaX, int xSign, decimal deltaY, int ySign)
        {
            int x;
            int slope = (int)Math.Round(Math.Abs(deltaX / deltaY));
            for (int i = 0; i <= Math.Abs(deltaY); i++)
            {
                if (i < Math.Abs(deltaY))
                    x = x1 + xSign * slope * i;
                else
                    x = x2;
                DrawDot(x, y1 + ySign * i);
            }
        }

        private int GetSignedValue(decimal v)
        {
            return (int)(v / Math.Abs(v));
        }
    }
}
