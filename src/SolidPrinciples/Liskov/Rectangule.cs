using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.Liskov
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(int width, int heith)
        {
            Width = width;
            Height = heith;
        }

        public override string ToString() => $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";

    }
}
