using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Clases.Adicionales
{
    public class Acelga : IAdicional
    {
        public string GetName()
        {
            return "Acelga";
        }

        public float GetPrice()
        {
            return 7.90f;
        }
    }
}
