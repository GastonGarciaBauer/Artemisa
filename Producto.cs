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
        public string TiempoPreparacion { get; set; }
        public bool AptoCeliacos { get; set; }
        public int NivelPicante { get; set; }
        public Producto(int id, string nombre, int valor, int stock, List<string> ingredientes, string tiempoPreparacion, bool aptoCeliacos, int nivelPicante)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Valor = valor;
            this.Stock = stock;
            this.Ingredientes = Ingredientes;
            this.TiempoPreparacion = tiempoPreparacion;
            this.AptoCeliacos = aptoCeliacos;
            this.NivelPicante = nivelPicante;
        }
        public abstract double CalcularPrecioFinal();
        public virtual void MostrarInfo(int cantidad)
        {
            Console.WriteLine($"\nValor del producto: {Valor}\n");
            
            Program.subTotal += CalcularPrecioFinal() * cantidad;
            
            Console.WriteLine($"Subtotal: {Program.subTotal}\n");
        }

    }
}
