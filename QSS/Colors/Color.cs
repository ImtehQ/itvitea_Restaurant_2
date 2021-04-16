using System;
using System.Collections.Generic;
using System.Text;

namespace QsScriptExtentions.Colors
{
    public enum ColorAssistChannel
    {
        Red, Blue, Green, Alpha
    }

    /// <summary>
    /// Color class converted from Unity3D Project
    /// </summary>
    public class Color
    {
        public double r, g, b, a;
        public Color(double r, double g, double b, double a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }
        public Color(double r, double g, double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = 1;
        }

        // Solid red. RGBA is (1, 0, 0, 1).
        public static Color red { get { return new Color(1F, 0F, 0F, 1F); } }
        // Solid green. RGBA is (0, 1, 0, 1).
        public static Color green { get { return new Color(0F, 1F, 0F, 1F); } }
        // Solid blue. RGBA is (0, 0, 1, 1).
        public static Color blue { get { return new Color(0F, 0F, 1F, 1F); } }
        // Solid white. RGBA is (1, 1, 1, 1).
        public static Color white { get { return new Color(1F, 1F, 1F, 1F); } }
        // Solid black. RGBA is (0, 0, 0, 1).
        public static Color black { get { return new Color(0F, 0F, 0F, 1F); } }
        // Yellow. RGBA is (1, 0.92, 0.016, 1), but the color is nice to look at!
        public static Color yellow { get { return new Color(1F, 235F / 255F, 4F / 255F, 1F); } }
        // Cyan. RGBA is (0, 1, 1, 1).
        public static Color cyan { get { return new Color(0F, 1F, 1F, 1F); } }
        // Magenta. RGBA is (1, 0, 1, 1).
        public static Color magenta { get { return new Color(1F, 0F, 1F, 1F); } }
        // Gray. RGBA is (0.5, 0.5, 0.5, 1).
        public static Color gray { get { return new Color(.5F, .5F, .5F, 1F); } }
        // English spelling for ::ref::gray. RGBA is the same (0.5, 0.5, 0.5, 1).
        public static Color grey { get { return new Color(.5F, .5F, .5F, 1F); } }
        // Completely transparent. RGBA is (0, 0, 0, 0).
        public static Color clear { get { return new Color(0F, 0F, 0F, 0F); } }
    }
}
