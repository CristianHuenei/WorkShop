using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Clases
{
    public class FordFocus : IVendible
    {
        public string GetDescripcion()
        {
            return "Ford Focus";
        }

        public double GetPrecio()
        {
            return 390000;
        }
    }
}
