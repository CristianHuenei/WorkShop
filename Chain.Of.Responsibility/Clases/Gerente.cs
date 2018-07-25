using Chain.Of.Responsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Of.Responsibility.Clases
{
    public class Gerente : IAprobador
    {
        private IAprobador _next;

        public IAprobador GetNext()
        {
            return _next;
        }

        public void SetNext(IAprobador next)
        {
            _next = next;
        }

        public void SolicitudPrestamos(double monto)
        {
            if (monto >= 50000 && monto < 100000)
            {
                Console.WriteLine("Aprobado por Gerente");
            }
            else
            {
                _next.SolicitudPrestamos(monto);
            }
        }
    }
}
