using Builder.Clases;
using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class PizzaBuilder : IBuilder
    {
        internal IMasa masa;
        internal ISalsa salsa;
        internal List<IAdicional> adicionales;
        internal string Name;

        public PizzaBuilder(String name)
        {
            Name = name;
            adicionales = new List<IAdicional>();
        }

        public PizzaBuilder CreateAdicionales(List<IAdicional> adicionales)
        {
            this.adicionales = adicionales;
            return this;
        }

        public PizzaBuilder CreateMasa(IMasa masa)
        {
            this.masa = masa;
            return this;
        }

        public PizzaBuilder CreateSalsa(ISalsa salsa)
        {
            this.salsa = salsa;
            return this;
        }

        public IPizza Build()
        {
            return new Pizza(this);
        }

        public PizzaBuilder CreateAdicional(IAdicional adicional)
        {
            adicionales.Add(adicional);
            return this;
        }
    }
}
