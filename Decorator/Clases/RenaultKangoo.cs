using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Clases
{
    public class RenaultKangoo : IVendible
    {
        public string GetDescripcion()
        {
            return "Renaul Kangoo";
        }

        public double GetPrecio()
        {
            return 260000;
        }
    }
}
