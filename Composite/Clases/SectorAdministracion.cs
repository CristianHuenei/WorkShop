using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Clases
{
    public class SectorAdministracion : Composite
    {
        private int _cajeros;
        public int GetCantidadCajeros()
        {
            return _cajeros;
        }

        public void SetCantidadCajeros(int cant)
        {
            _cajeros = cant;
        }
    }
}
