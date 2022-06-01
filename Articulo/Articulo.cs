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

        public Articulo()
        {

        }
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

        public string CalcularPrecio(double precio, double iva, double descuento)
        {

            string preciosArticulo = "";

            preciosArticulo += "Precio Original:" + precio.ToString() + Environment.NewLine;

            double precioConDescuento = precio - (precio * (descuento / 100));

            preciosArticulo += "Descuento:" + descuento.ToString() + " %    Valor de descuento:" + (precio * (descuento / 100)).ToString()
                            + Environment.NewLine;

            preciosArticulo += "Precio con descuento:" + precioConDescuento.ToString() + Environment.NewLine;

            double precioFinal = precioConDescuento + (precioConDescuento * (iva / 100));

            preciosArticulo += "Precio con Final:" + precioFinal.ToString() + Environment.NewLine;

            return preciosArticulo;
        }

    }
}
