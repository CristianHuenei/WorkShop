using Abstract.Factory.Clases.Adicionales;
using Abstract.Factory.Clases.Masas;
using Abstract.Factory.Clases.Salsas;
using Abstract.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Factories
{
    public class PizzaMuzzarellaPiedraFactory : FactoryBase
    {

        public PizzaMuzzarellaPiedraFactory()
        {
            _name = "PIZZA DE MUZARELLA A LA PIEDRA";
            _masa = new MasaPiedra();
            _salsa = new SalsaDeTomate();
            _adicionales = new List<IAdicional>();
            _adicionales.Add(new Aceituna());
            _adicionales.Add(new Aceituna());
            _adicionales.Add(new Aceituna());
            _adicionales.Add(new Aceituna());
            _adicionales.Add(new Aceituna());
            _adicionales.Add(new Aceituna());
            _adicionales.Add(new Aceituna());
            _adicionales.Add(new Aceituna());
        }
    
    }
}
