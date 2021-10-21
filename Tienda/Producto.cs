using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Producto
    {
        private int codigo;
        private string nombre;
        private int precio;
        private int total;
        private int eliminar;
        private double descuento;

        //Encapsulamiento
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Total { get => total; set => total = value; }
        public int Eliminar { get => eliminar; set => eliminar = value; }
        public double Descuento { get => descuento; set => descuento = value; }
    }
}
