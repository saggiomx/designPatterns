using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.BuilderInheritance
{
    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>> where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorkAs(string position)
        {
            person.Position = position;
            return (SELF)this;
        }
    }
}
