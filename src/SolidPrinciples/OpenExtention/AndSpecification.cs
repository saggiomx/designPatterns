using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OpenExtention
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> _first;
        private ISpecification<T> _second;
        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            _first = first?? throw new ArgumentNullException(nameof(first));
            _second = second?? throw new ArgumentNullException(nameof(second));
        }

        public bool IsSatisfied(T t)
        {
            return _first.IsSatisfied(t) && _second.IsSatisfied(t);
        }
    }
}
