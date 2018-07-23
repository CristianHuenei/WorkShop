using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Clases.Adicionales
{
    public class Jamon : IAdicional
    {
        public string GetName()
        {
            return "Feta de Jamón";
        }

        public float GetPrice()
        {
            return 1.26f;
        }
    }
}
