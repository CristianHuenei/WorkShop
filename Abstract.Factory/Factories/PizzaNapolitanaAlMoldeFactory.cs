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
    public class PizzaNapolitanaAlMoldeFactory:FactoryBase
    {
        public PizzaNapolitanaAlMoldeFactory()
        {
            _name = "PIZZA NAPOLITANA AL MOLDE";
            _masa = new MasaMolde();
            _salsa = new SalsaDeTomate();
            _adicionales = new List<IAdicional>();
            _adicionales.Add(new Jamon());
            _adicionales.Add(new Jamon());
            _adicionales.Add(new Jamon());
            _adicionales.Add(new Jamon());
            _adicionales.Add(new Jamon());
            _adicionales.Add(new Jamon());
            _adicionales.Add(new Tomate());
            _adicionales.Add(new Tomate());
            _adicionales.Add(new Tomate());
            _adicionales.Add(new Tomate());
            _adicionales.Add(new Tomate());
            _adicionales.Add(new Tomate());
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
