using System;
using System.Collections.Generic;
using System.Text;
using static SolidPrinciples.OpenExtention.Enums;

namespace SolidPrinciples.OpenExtention
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }

        public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Color color, Size size)
        {
            foreach (var p in products)
                if (p.Color == color && p.Size == size)
                    yield return p;
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> spec)
        {
            foreach (var item in products)
                if (spec.IsSatisfied(item))
                    yield return item;
        }
    }
}
