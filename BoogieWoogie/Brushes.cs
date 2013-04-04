using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoogieWoogie
{
    using System.Drawing;

    public class Brushes
    {
        public static Brush White { get { return new SolidBrush(Color.White); } }
        public static Brush Yellow { get { return new SolidBrush(Color.FromArgb(255, 251, 199, 2)); } }
        public static Brush DarkYellow { get { return new SolidBrush(Color.FromArgb(255, 202, 151, 6)); } }
        public static Brush Red { get { return new SolidBrush(Color.FromArgb(255, 236, 4, 2)); } }
        public static Brush Gray { get { return new SolidBrush(Color.FromArgb(255, 172, 171, 175)); } }
        public static Brush LightGray { get { return new SolidBrush(Color.FromArgb(255, 233, 233, 233)); } }
        public static Brush Blue { get { return new SolidBrush(Color.FromArgb(255, 69, 85, 137)); } }
        public static Brush Black { get { return new SolidBrush(Color.FromArgb(255, 50, 39, 37)); } }
        public static Brush Beige { get { return new SolidBrush(Color.FromArgb(255, 233, 205, 168)); } }
        public static Brush DarkRed { get { return new SolidBrush(Color.FromArgb(255, 127, 42, 22)); } }

        public static Brush Invisible { get { return new SolidBrush(Color.FromArgb(0, 0, 0, 0)); } }
    }
}
