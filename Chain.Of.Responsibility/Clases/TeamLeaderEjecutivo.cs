using Chain.Of.Responsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Of.Responsibility.Clases
{
    public class TeamLeaderEjecutivo : IAprobador
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
            if (monto >= 10000 && monto < 50000)
            {
                Console.WriteLine("Aprobado por Team Leader Ejecutivo de Cuentas");
            }
            else
            {
                _next.SolicitudPrestamos(monto);
            }
        }
    }
}
