using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Clases.Adicionales
{
    public class Tomate : IAdicional
    {
        public string GetName()
        {
            return "Rodaja de tomate";
        }

        public float GetPrice()
        {
            return .56f;
        }
    }
}
