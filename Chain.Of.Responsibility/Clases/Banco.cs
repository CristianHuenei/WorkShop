using Chain.Of.Responsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Of.Responsibility.Clases
{
    public class Banco : IAprobador
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
            EjecutivoDeCuentas ejecutivo = new EjecutivoDeCuentas();
            TeamLeaderEjecutivo teamLeader = new TeamLeaderEjecutivo();
            Gerente gerente = new Gerente();
            Director director = new Director();

            //Encadenamiento
            SetNext(ejecutivo);
            ejecutivo.SetNext(teamLeader);
            teamLeader.SetNext(gerente);
            gerente.SetNext(director);

            _next.SolicitudPrestamos(monto);

        }
    }
}
