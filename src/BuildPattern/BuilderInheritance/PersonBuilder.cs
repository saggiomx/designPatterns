using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.BuilderInheritance
{
    public class PersonBuilder
    {
        protected Person person = new Person();
        public Person Build() => person;
    }
}
