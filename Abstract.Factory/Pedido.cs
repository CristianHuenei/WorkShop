using Abstract.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory
{
    public class Pedido
    {
        private List<IFactory> _pizzas;
        public Pedido(IFactory pizza)
        {
            _pizzas = new List<IFactory>();
            AddPizza(pizza);
        }

        public void AddPizza(IFactory pizza)
        {
            _pizzas.Add(pizza);
        }

        public void Print()
        {
            foreach (var pizza in _pizzas)
            {
                Console.WriteLine("**** \"{0}\" ****{1}", pizza.GetName(), Environment.NewLine);
                Console.WriteLine(pizza.GetIngredients());
                Console.WriteLine("************************************");
                Console.WriteLine("TOTAL\t\t\t${0}", pizza.GetTotal());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
