using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator.Clases
{
    public class CubreCarter : AutomovilDecorator
    {
        public CubreCarter(IVendible vendible) : base(vendible)
        {
            SetDescripcion("Chapón cubre carter");
            SetPrecio(4350);
        }
    }
}
