using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Clases
{
    public class ChevroletPrisma : IVendible
    {
        public string GetDescripcion()
        {
            return "Chevrolet Prisma";
        }

        public double GetPrecio()
        {
            return 340000;
        }
    }
}
