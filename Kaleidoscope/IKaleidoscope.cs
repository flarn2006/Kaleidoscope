using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kaleidoscope
{
    public interface IKaleidoscope
    {
        Point[] GetReflectedPoints(Point location);
    }
}
