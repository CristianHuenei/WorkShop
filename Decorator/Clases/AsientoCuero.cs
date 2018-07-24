using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator.Clases
{
    public class AsientoCuero : AutomovilDecorator
    {
        public AsientoCuero(IVendible vendible) : base(vendible)
        {
            SetDescripcion("Asiento de cuero");
            SetPrecio(17000);
        }

    }
}
