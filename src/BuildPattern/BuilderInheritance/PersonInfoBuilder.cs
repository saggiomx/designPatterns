using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.BuilderInheritance
{
    public class PersonInfoBuilder<SELF> : PersonBuilder where SELF : PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            person.Name = name;
            return (SELF)this;
        }
    }
}
