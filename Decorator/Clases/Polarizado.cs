using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator.Clases
{
    public class Polarizado : AutomovilDecorator
    {
        public Polarizado(IVendible vendible) : base(vendible)
        {
            SetDescripcion("Polarizado");
            SetPrecio(3200);            
        }
    }
}
