using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisa
{
    abstract class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int valor { get; set; }
        public Producto(int id, string nombre, int valor)
        {
            this.id = id;
            this.nombre = nombre;
            this.valor = valor;

        }
        public abstract double CalcularPrecioFinal();

    }
}
}
