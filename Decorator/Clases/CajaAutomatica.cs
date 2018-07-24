using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator.Clases
{
    public class CajaAutomatica : AutomovilDecorator
    {
        public CajaAutomatica(IVendible vendible) : base(vendible)
        {
            SetDescripcion("Caja automática");
            SetPrecio(21000);
        }
    }
}
