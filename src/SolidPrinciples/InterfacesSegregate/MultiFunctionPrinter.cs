using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.InterfacesSegregate
{
    public class MultiFunctionPrinter : IMultifunction
    {
        private IPrinter _printer;
        private IScanner _scanner;
        private IFax _fax;

        public MultiFunctionPrinter(IPrinter printer, IScanner scanner, IFax fax)
        {
            if (printer == null) throw new ArgumentNullException(nameof(printer));
            _printer = printer;
            if (scanner == null) throw new ArgumentNullException(nameof(scanner));
            _scanner = scanner;
            if (fax == null) throw new ArgumentNullException(nameof(fax));
            _fax = fax;
        }

        public void Print(Document d)
        {
            _printer.Print(d);
        }
        public void Fax(Document d)
        {
            _fax.Fax(d);
        }
        public void Scan(Document d)
        {
            _scanner.Scan(d);
        }
    }

    public class OldFashionPrinter : IPrinter
    {
        public void Print(Document d)
        {
            //
        }
    }

    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            //
        }
        public void Fax(Document d)
        {
            //
        }
        public void Scan(Document d)
        {
            //
        }
    }
}
