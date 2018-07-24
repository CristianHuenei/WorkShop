using Decorator.Clases;
using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IVendible kangoo = new RenaultKangoo();
            kangoo = new CubreCarter(kangoo);

            Console.WriteLine(kangoo.GetDescripcion());
            Console.WriteLine("Su precio es ${0}", kangoo.GetPrecio());
            Console.WriteLine();
            Console.WriteLine("***********************************************************");

            IVendible prisma = new ChevroletPrisma();
            prisma = new LlantasAleacion(prisma);
            prisma = new CubreCarter(prisma);

            Console.WriteLine(prisma.GetDescripcion());
            Console.WriteLine("Su precio es ${0}", prisma.GetPrecio());
            Console.WriteLine();
            Console.WriteLine("***********************************************************");

            prisma = new AsientoCuero(prisma);
            prisma = new Polarizado(prisma);

            Console.WriteLine(prisma.GetDescripcion());
            Console.WriteLine("Su precio es ${0}", prisma.GetPrecio());
            Console.WriteLine();
            Console.WriteLine("***********************************************************");

            IVendible focus = new FordFocus();
            focus = new LlantasAleacion(focus);
            focus = new AsientoCuero(focus);
            focus = new Polarizado(focus);
            focus = new CajaAutomatica(focus);

            Console.WriteLine(focus.GetDescripcion());
            Console.WriteLine("Su precio es ${0}", focus.GetPrecio());
            Console.WriteLine();
            Console.WriteLine("***********************************************************");

            Console.ReadLine();


        }
    }
}
