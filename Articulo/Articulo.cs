using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica3.Articulo
{
     class Articulo
    {

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public Articulo(int codigo, string descripcion, double precio, int cantidad)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
        }

        internal double CalcularIVA()
        {
            return Precio * 0.13;
        }

    }
}
