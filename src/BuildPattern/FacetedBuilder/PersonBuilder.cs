using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.FacetedBuilder
{
    public class PersonBuilder //Facade
    {
        protected Person person = new Person();
        public PersonJobBuilder Works => new PersonJobBuilder(person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

        public static implicit operator Person(PersonBuilder personBuilder)
        {
            return personBuilder.person;
        }
    }
}
