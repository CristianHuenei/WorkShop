using Abstract.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Clases.Salsas
{
    public class SalsaDeTomate : ISalsa
    {
        public string GetName()
        {
            return "Salsa de Tomate";
        }

        public float GetPrice()
        {
            return 4.90f;
        }
    }
}
