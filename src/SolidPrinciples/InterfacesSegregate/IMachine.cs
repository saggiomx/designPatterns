using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.InterfacesSegregate
{
    public interface IScanner
    {
        void Scan(Document document);
    }

    public interface IPrinter
    {
        void Print(Document document);
    }

    public interface IFax
    {
        void Fax(Document document);
    }

    public interface IMultifunction : IScanner, IPrinter, IFax
    {
    }
}
