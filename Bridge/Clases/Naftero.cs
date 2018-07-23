using Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Clases
{
    public class Naftero : IMotor
    {
        #region IMotor Members

        public void InyectarCombustible(double cantidad)
        {
            Console.WriteLine("Inyectando " + cantidad + " ml. de Nafta");
        }

        public void ConsumirCombustible()
        {
            RealizarCombustion();
        }

        #endregion

        private void RealizarCombustion()
        {
            Console.WriteLine("Realizada la combustión de la Nafta");
        }
    }
}
