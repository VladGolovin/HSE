using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.MyPaint
{
    using System.Drawing;

    public static class GraphicsExtensions
    {
        public static void DrawStar(this Graphics graphics, Pen pen, int pointCount, int radius, int ox, int oy, bool filled)
        {
            var points = new List<Point>();

            var points1 = new List<Point>();

            double angle = Math.PI * 2 / pointCount;

            double inner = angle;

            for (double outer = angle / 2; outer < Math.PI*2 + (angle / 2); outer = outer + angle)
            {
                double xOuter = ox + radius * Math.Sin(outer);

                double yOuter = oy + radius * Math.Cos(outer);

                double xInner = ox + radius / 3 * Math.Sin(inner);

                double yInner = oy + radius / 3 * Math.Cos(inner);

                points.Add(new Point(Convert.ToInt32(xOuter), Convert.ToInt32(yOuter)));

                points.Add(new Point(Convert.ToInt32(xInner), Convert.ToInt32(yInner)));

                inner += angle;
            }

            if (filled)
                graphics.FillPolygon(new SolidBrush(pen.Color), points.ToArray());
            else
                graphics.DrawPolygon(pen, points.ToArray());
        }
    }
}
