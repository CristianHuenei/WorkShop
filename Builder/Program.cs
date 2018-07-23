using Builder.Builders;
using Builder.Clases.Adicionales;
using Builder.Clases.Masas;
using Builder.Clases.Salsas;
using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder pizzaBuilder = new PizzaBuilder("PIZZA DE VERDURAS A LA PIEDRA");

            IPizza pizza = pizzaBuilder.CreateMasa(new MasaPiedra())
            .CreateSalsa(new SalsaBlanca())
            .CreateAdicional(new Acelga())
            .CreateAdicional(new QuesoParmesano())
            .Build();

            Pedido pedido = new Pedido(pizza);
            pedido.Print();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadLine();
        }
    }
}
