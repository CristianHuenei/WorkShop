using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Clases
{
    public class MementoClass
    {
        private string _estado;

        public MementoClass(string estado)
        {
            _estado = estado;
        }

        public string GetSavedState()
        {
            return _estado;
        }
    }
}
