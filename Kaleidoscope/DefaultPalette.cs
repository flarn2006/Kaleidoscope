using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Kaleidoscope
{
    static class DefaultPalette
    {
        private static Color[] colors = null;

        private static Color Gray(int level)
        {
            return Color.FromArgb(level, level, level);
        }

        public static Color[] Palette
        {
            get
            {
                if (colors == null) {
                    colors = new Color[] {
                        Color.Black,            Gray(32),
                        Gray(64),               Gray(96),
                        Gray(128),              Gray(160),
                        Gray(192),              Gray(224),
                        Gray(240),              Color.White,
                        Color.Maroon,           Color.Red,
                        Color.SaddleBrown,      Color.Orange,
                        Color.DarkGoldenrod,    Color.Gold,
                        Color.Olive,            Color.Yellow,
                        Color.Green,            Color.Lime,
                        Color.Teal,             Color.Cyan,
                        Color.RoyalBlue,        Color.DeepSkyBlue,
                        Color.Navy,             Color.Blue,
                        Color.Indigo,           Color.DarkViolet,
                        Color.Purple,           Color.Magenta,
                        Color.MediumVioletRed,  Color.DeepPink,
                    };
                }
                return colors;
            }
        }
    }
}
