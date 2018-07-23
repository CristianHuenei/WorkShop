using Abstract.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Clases.Salsas
{
    public class SalsaBlanca : ISalsa
    {
        public string GetName()
        {
            return "Salsa Blanca";
        }

        public float GetPrice()
        {
            return 5.25f;
        }
    }
}
