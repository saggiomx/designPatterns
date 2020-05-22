using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenExtention
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
