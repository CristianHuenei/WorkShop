using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Clases
{
    public abstract class Automovil : IVendible
    {
        public string GetDescripcion()
        {
            throw new NotImplementedException();
        }

        public double GetPrecio()
        {
            throw new NotImplementedException();
        }
    }
}
