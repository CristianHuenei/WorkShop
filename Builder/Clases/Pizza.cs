using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builders;

namespace Builder.Clases
{
    public class Pizza : IPizza
    {
        internal IMasa _masa;
        internal ISalsa _salsa;
        internal List<IAdicional> _adicionales = new List<IAdicional>();
        internal string _name;
        internal PizzaBuilder pizzaBuilder;

        public Pizza(PizzaBuilder pizzaBuilder)
        {
            this.pizzaBuilder = pizzaBuilder;
            this._name = pizzaBuilder.Name;
            this._masa = pizzaBuilder.masa;
            this._salsa = pizzaBuilder.salsa;
            this._adicionales = pizzaBuilder.adicionales;

        }

        public Pizza(string _name, IMasa _masa, ISalsa _salsa, List<IAdicional> _adicionales)
        {
            this._name = _name;
            this._masa = _masa;
            this._salsa = _salsa;
            this._adicionales = _adicionales;
        }

        public string GetIngredients()
        {
            string ret = "";

            ret += _masa.GetName() + "\t\t ($" + _masa.GetPrice() + ")" + Environment.NewLine;
            ret += _salsa.GetName() + "\t\t ($" + _salsa.GetPrice() + ")" + Environment.NewLine;
            foreach (var adicional in _adicionales)
            {
                ret += adicional.GetName() + "\t\t ($" + adicional.GetPrice() + ")" + Environment.NewLine;
            }

            return ret;
        }

        public float GetTotal()
        {
            float ret = 0f;

            ret += _masa.GetPrice();
            ret += _salsa.GetPrice();
            foreach (var adicional in _adicionales)
            {
                ret += adicional.GetPrice();
            }

            return ret;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
