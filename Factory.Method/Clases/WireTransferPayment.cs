using Factory.Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Method.Clases
{
    public class WireTransferPayment : IPayment
    {
        public string doPayment(ShoppingList shoppingList)
        {
            return "Pagado con Wire Transfer";
        }

        public bool isValidLogin(Login login)
        {
            return true;
        }
    }
}
