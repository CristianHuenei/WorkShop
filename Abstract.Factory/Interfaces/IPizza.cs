using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Interfaces
{
    public interface IPizza
    {
            IMasa GetMasa();
            ISalsa GetSalsa();

            IEnumerable<IAdicional> GetAdicionales();
    }

}
