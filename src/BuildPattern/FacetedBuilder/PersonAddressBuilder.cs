using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.FacetedBuilder
{
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder Address(string address)
        {
            person.SteetAddress = address;
            return this;
        }

        public PersonAddressBuilder Postal(string postal)
        {
            person.PostalCode = postal;
            return this;
        }
        public PersonAddressBuilder City(string city)
        {
            person.City = city;
            return this;
        }

    }
}
