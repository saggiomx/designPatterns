using System;
using System.Collections.Generic;
using System.Text;
using static SolidPrinciples.OpenExtention.Enums;

namespace SolidPrinciples.OpenExtention
{
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Color = color;
            Size = size;
        }
    }
}
