using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    public interface IPizza
    {
        string GetName();
        float GetTotal();

        string GetIngredients();
    }

}
