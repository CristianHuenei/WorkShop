using Memento.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            CareTaker ct = new CareTaker();

            Persona p = new Persona();
            p.SetNombre("Matias");
            p.SetNombre("Juan");

            ct.AgregarMemento(p.SaveToMemento());

            p.SetNombre("Rodrigo");

            ct.AgregarMemento(p.SaveToMemento());

            p.SetNombre("Fede");

            MementoClass m1 = ct.GetMemento(0);
            MementoClass m2 = ct.GetMemento(1);

            Console.WriteLine("Memento 1: {0}", m1.GetSavedState());
            Console.WriteLine("Memento 2: {0}", m2.GetSavedState());

            Console.ReadLine();

        }
    }
}
