using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Clases.Adicionales
{
    public class Aceituna : IAdicional
    {
        public string GetName()
        {
            return "Aceituna";
        }

        public float GetPrice()
        {
            return 0.3f;
        }
    }
}
