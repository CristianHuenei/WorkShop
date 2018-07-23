using Abstract.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Clases.Adicionales
{
    public class Muzzarella : IAdicional
    {
        public string GetName()
        {
            return "Muzzarella";
        }

        public float GetPrice()
        {
            return 4.25f;
        }
    }
}
