using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Clases
{
    public class CareTaker
    {
        private List<MementoClass> _estados = new List<MementoClass>();

        public void AgregarMemento(MementoClass m)
        {
            _estados.Add(m);
        }

        public MementoClass GetMemento(int index)
        {
            return _estados[index];
        }
    }
}
