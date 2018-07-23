using Bridge.Clases;
using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotor naftero = new Naftero();
            Vehiculo Fiat1500 = new Fiat1500(naftero, 300);
            Fiat1500.MostrarCaracteristicas();
            Fiat1500.Acelerar(5.9d);
            Fiat1500.Frenar();            
            Console.ReadLine();

            IMotor motorDiesel = new Diesel();
            Vehiculo kangoo = new RenaultKangoo(motorDiesel, true);
            kangoo.MostrarCaracteristicas();
            kangoo.Acelerar(2.4d);
            kangoo.Frenar();
            Console.ReadLine();
        }
    }
}
