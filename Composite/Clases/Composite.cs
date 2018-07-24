using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Clases
{
    public class Composite : ISueldo
    {
        private List<ISueldo> _empleados;

        public Composite()
        {
            _empleados = new List<ISueldo>();
        }
        public double GetSueldo()
        {
            double suma = 0;
            foreach (ISueldo empleado in _empleados)
            {
                suma += empleado.GetSueldo();
            }


            return suma;
        }

        public void Agregar(ISueldo p)
        {
            _empleados.Add(p);
        }
    }
}
