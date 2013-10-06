using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kaleidoscope
{
    public class RadialKaleidoscope : IKaleidoscope
    {
        private int n;
        private Point center;
        private AngleMode mode;

        private static void RectToPolar(double x, double y, out double r, out double theta)
        {
            theta = Math.Atan2(y, x);
            r = Math.Sqrt(x * x + y * y);
        }

        private static void PolarToRect(double r, double theta, out double x, out double y)
        {
            x = Math.Cos(theta) * r;
            y = Math.Sin(theta) * r;
        }

        /// <summary>
        /// Creates a new RadialKaleidoscope object.
        /// </summary>
        /// <param name="n">The number of rays of symmetry.</param>
        /// <param name="center">The location from where the rays are projected.</param>
        public RadialKaleidoscope(int n, Point center, AngleMode mode = AngleMode.TwoWay)
        {
            this.n = n;
            this.center = center;
            this.mode = mode;
        }

        public Point Center
        {
            get { return center; }
        }

        public Point[] GetReflectedPoints(Point location)
        {
            double x = (double)(location.X - center.X);
            double y = (double)(location.Y - center.Y);
            double r, theta; RectToPolar(x, y, out r, out theta);

            Point[] points;
            if (mode == AngleMode.TwoWay) {
                points = new Point[2 * n];
            } else {
                points = new Point[n];
            }

            double angle = 2.0 * Math.PI / n;

            for (int i = 0; i < n; i++) {
                double x1, y1, x2, y2;
                PolarToRect(r, theta + i * angle, out x1, out y1);
                PolarToRect(r, -theta - i * angle, out x2, out y2);

                switch (mode) {
                    case AngleMode.TwoWay:
                        points[2 * i] = new Point((int)x1 + center.X, (int)y1 + center.Y);
                        points[2 * i + 1] = new Point((int)x2 + center.X, (int)y2 + center.Y);
                        break;
                    case AngleMode.OneWay:
                        points[i] = new Point((int)x1 + center.X, (int)y1 + center.Y);
                        break;
                }
            }

            return points;
        }

        public enum AngleMode
        {
            TwoWay = 0,
            OneWay = 1,
        }
    }
}
