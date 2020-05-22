using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.FunctionalBuilder
{
    public class Person
    {
        public string Name;
        public string Position;

        public override string ToString() => $"{nameof(Name)}, {Name}, {nameof(Position)}: {Position}.";
    }
}
