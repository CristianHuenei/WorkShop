using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Clases
{

    public class RenaultKangoo : Vehiculo
    {
        // Atributo propio
        private bool puertaCorrediza;

        // La implementacion de los vehículos se desarrolla de forma independiente
        public RenaultKangoo(IMotor motor, bool puertaCorrediza)
            : base(motor)
        {
            this.puertaCorrediza = puertaCorrediza;
        }

        // Implementación del método abstracto
        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Vehiculo de tipo Renault Kangoo " + (puertaCorrediza ? "con" : "sin") +
                " puerta corrediza.");
        }
    }
}
