using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Clases
{
    public class Fiat1500 : Vehiculo
    {
        // Atributo propio
        private int capacidadMaletero;

        // La implementacion de los vehículos se desarrolla de forma independiente
        public Fiat1500(IMotor motor, int capacidadMaletero) : base(motor)
        {
            this.capacidadMaletero = capacidadMaletero;
        }

        // Implementación del método abstracto
        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Vehiculo de tipo Fiat 1500 con un maletero con una capacidad de " +
                capacidadMaletero + " litros.");
        }
    }
}
