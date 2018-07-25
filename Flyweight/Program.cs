using Flyweight.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_arboles = 25;

            String[] tipos = { "pino", "abeto", "sauce", "roble", "algarrobo" };

            FabricaDeArboles fabrica = new FabricaDeArboles();

            Random rand = new Random();

            Random coord = new Random();


            for (int i = 0; i < numero_arboles; i++)
            {
                fabrica.GetArbol(tipos[rand.Next(0, tipos.Length - 1)])

                .Dibujar(

                    coord.Next(),

                    coord.Next(),

                    coord.Next()
                    );
            }

            Console.ReadLine();
        }
    }
}
