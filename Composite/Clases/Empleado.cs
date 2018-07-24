using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Clases
{
    public class Empleado : ISueldo
    {
        private string _cargo;
        private string _nombre;
        private double _sueldo;

        public Empleado(string nombre, string cargo, double sueldo)
        {
            _nombre = nombre;
            _cargo = cargo;
            _sueldo = sueldo;
        }
        public double GetSueldo()
        {
            return _sueldo;
        }
    }
}
