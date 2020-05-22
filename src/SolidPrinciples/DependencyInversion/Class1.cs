using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.DependencyInversion
{
    public enum RelationShip
    {
        Parent, Child, Sibling
    }

    public class Person
    {
        public string Name;
        //public DateTime Birthday;
    }

    public class Relationships
    {
        private static List<(Person, RelationShip, Person)> _relations = new List<(Person, RelationShip, Person)>();
        public void AddParentChild(Person parent, Person child)
        {
            _relations.Add((parent, RelationShip.Parent, child));
            _relations.Add((child, RelationShip.Child, parent));
        }

        public List<(Person, RelationShip, Person)> Relations = _relations;
    }

    public interface IRelationShipBrowser
    {
        IEnumerable<Person> FindAllChildren(string name);
    }
}
