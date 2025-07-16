using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisa
{
    abstract class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Valor { get; set; }
        public int Stock { get; set; }
        public List<string> Ingredientes { get; set; } = new List<string>();
        public Producto(int id, string nombre, int valor, int stock, List<string> ingredientes)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Valor = valor;
            this.Stock = stock;
            this.Ingredientes = Ingredientes;

        }
        public abstract double CalcularPrecioFinal();

    }
}
