using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator.Clases
{
    public class LlantasAleacion : AutomovilDecorator
    {
        public LlantasAleacion(IVendible vendible) : base(vendible)
        {
            SetDescripcion("Llantas de aleación");
            SetPrecio(9500);
        }
    }
}
