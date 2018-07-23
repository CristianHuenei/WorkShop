using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Clases.Masas
{
    public class MasaMolde : IMasa
    {
        public string GetName()
        {
            return "Masa de pizza al molde";
        }

        public float GetPrice()
        {
            return 8.95f;
        }
    }
}
