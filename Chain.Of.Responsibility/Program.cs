using Chain.Of.Responsibility.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Of.Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            int monto = 1;
            Banco banco = new Banco();

            while (end == false)
            {
                Console.Clear();
                Console.WriteLine("Ingrese una monto para el prestamo [0 para salir]:");
                monto = Convert.ToInt32(Console.ReadLine());
                if(monto != 0)
                {
                    banco.SolicitudPrestamos(monto);
                    Console.WriteLine();
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadLine();
                }
                else
                {
                    end = true;
                }
            }
        }
    }
}
