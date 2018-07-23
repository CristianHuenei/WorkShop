using Abstract.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Factories
{
    public abstract class FactoryBase : IFactory
    {
        internal IMasa _masa;
        internal ISalsa _salsa;
        internal List<IAdicional> _adicionales;
        internal string _name;

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
