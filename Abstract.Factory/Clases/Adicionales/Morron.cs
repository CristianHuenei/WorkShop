using Abstract.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Clases.Adicionales
{
    public class Morron : IAdicional
    {
        public string GetName()
        {
            return "Morrón";
        }

        public float GetPrice()
        {
            return 5f;
        }
    }
}
