using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    public interface IBuilder
    {
        PizzaBuilder CreateMasa(IMasa masa);
        PizzaBuilder CreateSalsa(ISalsa salsa);
        PizzaBuilder CreateAdicional(IAdicional adicional);
        PizzaBuilder CreateAdicionales(List<IAdicional> adicional);
        IPizza Build();
    }
}
