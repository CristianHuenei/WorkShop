using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Clases
{
    public abstract class AutomovilDecorator : IVendible
    {
        private IVendible _vendible;
        private string _descripcion;
        private double _precio;

        public AutomovilDecorator(IVendible vendible)
        {
            SetVendible(vendible);
        }

        internal void SetPrecio(double precio)
        {
            _precio = precio;
        }

        internal void SetDescripcion(string descripcion)
        {
            _descripcion = descripcion;
        }

        public IVendible GetVendible()
        {
            return _vendible;
        }

        public void SetVendible(IVendible vendible)
        {
            _vendible = vendible;
        }
        public string GetDescripcion()
        {
            return GetVendible().GetDescripcion() + " - " + _descripcion;
        }

        public double GetPrecio()
        {
            return GetVendible().GetPrecio() + _precio;
        }
    }
}
