using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Of.Responsibility.Interfaces
{
    public interface IAprobador
    {
        void SetNext(IAprobador next);
        IAprobador GetNext();
        void SolicitudPrestamos(double monto);
    }
}
