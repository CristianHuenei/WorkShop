using Flyweight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Clases
{
    public class FabricaDeArboles
    {
        private Dictionary<string, IArbolLigero> _arboles;

        public FabricaDeArboles()
        {
            _arboles = new Dictionary<string, IArbolLigero>();
        }

        public IArbolLigero GetArbol(String tipo)
        {
            if(!_arboles.ContainsKey(tipo))
            {
                _arboles.Add(tipo, new Arbol(tipo));
            }

            return _arboles.Where(x => x.Key == tipo).FirstOrDefault().Value;
        }
    }
}
