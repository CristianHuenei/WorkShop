using Abstract.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Clases.Masas
{
    public class MasaPiedra : IMasa
    {
        public string GetName()
        {
            return "Masa de pizza a la piedra";
        }

        public float GetPrice()
        {
            return 8.1f;
        }
    }
}
