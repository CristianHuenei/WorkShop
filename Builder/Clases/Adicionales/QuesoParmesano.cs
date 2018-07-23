using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Clases.Adicionales
{
    public class QuesoParmesano : IAdicional
    {
        public string GetName()
        {
            return "Queso Parmesano";
        }

        public float GetPrice()
        {
            return 12.30f;
        }
    }
}
