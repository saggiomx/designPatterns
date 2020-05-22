using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenExtention
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Enums.Color _color;

        public ColorSpecification(Enums.Color color)
        {
            _color = color;
        }
        public bool IsSatisfied(Product t)
        {
            return t.Color == _color;
        }
    }
}
