using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Clases
{
    public class Persona
    {
        private string _nombre;

        public MementoClass SaveToMemento()
        {
            return new MementoClass(_nombre);
        }

        public void RestoreFromMemento(MementoClass m)
        {
            _nombre = m.GetSavedState();
        }

        public string GetNombre()
        {
            return _nombre;
        }

        public void SetNombre(String nombre)
        {
            _nombre = nombre;
        }
    }
}
