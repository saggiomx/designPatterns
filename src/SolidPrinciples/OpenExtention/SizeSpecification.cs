using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenExtention
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Enums.Size _size;

        public SizeSpecification(Enums.Size size)
        {
            _size = size;
        }
        public bool IsSatisfied(Product t)
        {
            return t.Size == _size;
        }
    }
}
