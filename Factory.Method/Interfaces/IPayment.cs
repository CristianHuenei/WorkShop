using Factory.Method.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Method.Interfaces
{
    public interface IPayment
    {

        bool isValidLogin(Login login);

        string doPayment(ShoppingList shoppingList);

    }
}
