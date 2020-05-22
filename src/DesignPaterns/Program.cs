using BuildPattern;
using BuildPattern.BuilderInheritance;
using SolidPrinciples;
using SolidPrinciples.DependencyInversion;
using SolidPrinciples.Liskov;
using SolidPrinciples.OpenExtention;
using SolidPrinciples.SingleResponsability;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using PersonInheritBuilder = BuildPattern.BuilderInheritance.Person;
using PersonDependencyInversion = SolidPrinciples.DependencyInversion.Person;
using FunctionalPersonBuilder = BuildPattern.FunctionalBuilder.PersonBuilder;
using BuildPattern.FunctionalBuilder;
using BuildPattern.FacetedBuilder;
using FaceteedPersonBuilder = BuildPattern.FacetedBuilder.PersonBuilder;

namespace DesignPaterns
{
    public class Program : IRelationShipBrowser
    {
        static public int Area(Rectangle r) => r.Width * r.Height;
        public static Relationships rS = new Relationships();

        //Program(Relationships rS)
        //{
        //   var relations = rS.Relations;
        //    foreach (var r in relations.Where(x => x.Item1.Name.Equals("Otman") && x.Item2 == RelationShip.Parent))
        //    {
        //        Console.WriteLine($"OTman is parent of {r.Item3.Name}");
        //    }
        //}

        Program(IRelationShipBrowser relationBrowser)
        {
            foreach (var p in relationBrowser.FindAllChildren("Otman"))
            {
                Console.WriteLine($"{p.Name} is Otman's child ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SolidPrinciples();
            BuildPattern();
            BuilderInheritance();
            FunctionalBuilder();
            FacetedBuilder();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        #region Solid
        private static void SolidPrinciples()
        {
            var journal = new Journal();
            journal.AddEntry("I Started today Udemy.");
            journal.AddEntry("I started with Solid.");
            Console.WriteLine(journal);

            var persistence = new Persistence();
            var fileName = @"C:\dev\designPatterns\journal.txt";
            persistence.SaveToFile(journal, fileName, true);

            var apple = new Product("apple", Enums.Color.Green, Enums.Size.Small);
            var orange = new Product("orange", Enums.Color.Red, Enums.Size.Small);
            var tree = new Product("tree", Enums.Color.Blue, Enums.Size.Large);
            var house = new Product("house", Enums.Color.Blue, Enums.Size.Large);

            Product[] products = { apple, tree, house, orange };

            var productFilter = new ProductFilter();

            Console.WriteLine("Blue products (old): ");
            foreach (var p in productFilter.FilterByColor(products, Enums.Color.Blue))
            {
                Console.WriteLine($" - {p.Name} is Blue");
            }

            var betterFilter = new BetterFilter();
            var colorSpec = new ColorSpecification(Enums.Color.Blue);
            Console.WriteLine("Blue products (new): ");
            foreach (var p in betterFilter.Filter(products, colorSpec))
            {
                Console.WriteLine($" - {p.Name} is Blue");
            }
            var sizeSpec = new SizeSpecification(Enums.Size.Large);
            var doubleSpec = new AndSpecification<Product>(colorSpec, sizeSpec);

            Console.WriteLine("Blue and Large products (new): ");
            foreach (var p in betterFilter.Filter(products, doubleSpec))
            {
                Console.WriteLine($" - {p.Name} is Blue and large");
            }

            var rectangle = new Rectangle(2, 3);
            Console.WriteLine($"{rectangle} has area {Area(rectangle)}");

            Rectangle square = new Square();
            square.Width = 3;
            Console.WriteLine($"{square} has area {Area(square)}");

            var parent = new PersonDependencyInversion { Name = "Otman" };
            var child1 = new PersonDependencyInversion { Name = "Loreto" };
            var child2 = new PersonDependencyInversion { Name = "Emilio" };

            rS.AddParentChild(parent, child1);
        }

        public IEnumerable<PersonDependencyInversion> FindAllChildren(string name)
        {
            foreach (var r in rS.Relations.Where(x => x.Item1.Name.Equals(name) && x.Item2 == RelationShip.Parent))
            {

                yield return r.Item3;
            }
        }
        #endregion

        #region BuildPattern
        private static void BuildPattern()
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world").AddChild("li", "!!!!!");
            Console.WriteLine(builder.ToString());
        }

        private static void BuilderInheritance()
        {
            var me = PersonInheritBuilder
                .New
                .Called("Otman")
                .WorkAs("Software Engineer")
                .Build();
            Console.WriteLine(me);
        }

        private static void FunctionalBuilder()
        {
            var personBuilder = new FunctionalPersonBuilder();
            personBuilder
                .Called("Otman")
                .WorkAs("dev")
                .Build();

            Console.WriteLine(personBuilder);
        }

        private static void FacetedBuilder()
        {
            var pb = new FaceteedPersonBuilder();
            var person = pb
                .Works.At("softtek")
                .As("Software Engineer")
                .With(120)
                .Lives.Address("Molineda")
                .City("Ags")
                .Postal("12345");

            Console.WriteLine(person);
        }
        #endregion
    }
}
