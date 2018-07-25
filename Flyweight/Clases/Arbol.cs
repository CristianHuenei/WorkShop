using Flyweight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Clases
{
    public class Arbol : IArbolLigero
    {
        private string _tipo;

        public Arbol(String tipo)
        {
            _tipo = tipo;
        }
        public void Dibujar(long x, long y, long z)
        {
            Console.WriteLine("Árbol [{0}] dibujado en las coordenadas ({1}, {2}, {3})", GetTipo(), x, y, z);
        }

        public string GetTipo()
        {
            return _tipo;
        }
    }
}
