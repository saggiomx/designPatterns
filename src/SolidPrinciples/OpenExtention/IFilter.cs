using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenExtention
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
