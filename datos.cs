using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final_en_C_sharp_1
{
    internal class datos
    {
          public int codigo { get; set; }

        public string nombre { get; set; }

        public double precio { get; set; }

        public int cantidad { get; set; }

        public datos(int codigo, string nombre, double precio, int cantidad)

        { 
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }
    }
}
