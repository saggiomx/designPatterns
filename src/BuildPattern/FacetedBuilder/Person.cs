using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.FacetedBuilder
{
    public class Person
    {
        public string SteetAddress;
        public string PostalCode;
        public string City;

        public string CompanyName;
        public string Position;
        public int AnualIncome;

        public override string ToString() => $"{nameof(SteetAddress)}:{SteetAddress}, {nameof(PostalCode)}:{PostalCode}, {nameof(City)}:{City}," +
            $" {nameof(CompanyName)}:{CompanyName}, {nameof(Position)}:{Position}, {nameof(AnualIncome)}:{AnualIncome}";
    }
}
