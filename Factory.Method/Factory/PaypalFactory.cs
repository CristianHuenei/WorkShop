using Factory.Method.Clases;
using Factory.Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Method.Factory
{
    public class PaypalFactory : IFactory
    {

        public IPayment CreatePayment()
        {
            return new PaypalPayment();

        }
    }
}
