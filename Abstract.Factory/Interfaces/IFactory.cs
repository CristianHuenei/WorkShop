using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Interfaces
{
    public interface IFactory
    {
        string GetName();
        string GetIngredients();
        float GetTotal();
    }
}
