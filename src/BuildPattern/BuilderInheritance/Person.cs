using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.BuilderInheritance
{
    public class Person
    {
        public string Name;
        public string Position;

        public class Builder : PersonJobBuilder<Builder>
        {

        }

        public static Builder New => new Builder();
        public override string ToString() => $"{nameof(Name)}, {Name},{nameof(Position)}: {Position}.";
    }
}
