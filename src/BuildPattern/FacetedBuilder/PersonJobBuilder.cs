using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.FacetedBuilder
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }

        public PersonJobBuilder At(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder As(string jobPosition)
        {
            person.Position = jobPosition;
            return this;
        }

        public PersonJobBuilder With(int anual)
        {
            person.AnualIncome = anual;
            return this;
        }
    }
}
