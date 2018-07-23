using Prototype.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Interfaces
{
    interface ICloneable
    {
        string Color { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        Carroceria TipoCarroceria { get; set; }
        Rueda TipoRueda { get; set; }

        object Clone();
    }
}
