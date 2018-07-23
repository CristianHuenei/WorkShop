using Abstract.Factory.Factories;
using Abstract.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory pizzaMuzza = new PizzaMuzzarellaPiedraFactory();
            IFactory pizzaNapo = new PizzaNapolitanaAlMoldeFactory();

            Pedido pedido = new Pedido(pizzaMuzza);
            pedido.AddPizza(pizzaNapo);

            pedido.Print();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadLine();
        }
    }
}
