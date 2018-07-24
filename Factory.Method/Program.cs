using Factory.Method.Clases;
using Factory.Method.Factory;
using Factory.Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Method
{
    class Program
    {
        static void Main(string[] args)

        {
            IFactory factory = null;
            IPayment payment = null;
            ConsoleKey keyPressed;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese una opción:  [C] Credit Card     [P] PayPal      [W] WireTransfer        [Esc] Salir");
                keyPressed = Console.ReadKey(true).Key;
                switch (keyPressed)
                {
                    case ConsoleKey.C:
                        factory = new CreditCardFactory();
                        break;
                    case ConsoleKey.P:
                        factory = new PaypalFactory();
                        break;
                    case ConsoleKey.W:
                        factory = new WireTransferFactory();
                        break;
                    default:
                        return;                        
                }
                payment = factory.CreatePayment();
                ProcessPayment(payment);
            } while (keyPressed != ConsoleKey.Escape); 

        }

        private static void ProcessPayment(Interfaces.IPayment payment)
        {
            if (payment.isValidLogin(new Login()))
            {
                Console.WriteLine("Operación OK: {0}", payment.doPayment(new ShoppingList()));
            }
            else
            {
                Console.WriteLine("El usuario no está logueado");
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadLine();
        }
    }
}
