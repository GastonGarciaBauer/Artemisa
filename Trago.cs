using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisa
{
    class Trago : Producto
    {
        public string Dia { get; set; }
        public bool ConAlcohol {  get; set; }
        public Trago(int id, string nombre, int valor, int stock, List<string> ingredientes, string tiempoPreparacion, bool aptoCeliacos, int nivelPicante, string dia, bool conAlcohol) : base(id, nombre, valor, stock, ingredientes, tiempoPreparacion, aptoCeliacos, nivelPicante)
        {
            this.Dia = dia;
            this.ConAlcohol = conAlcohol;
        }
        public override double CalcularPrecioFinal()
        {
            return DescuentoDia();
        }
        public override void MostrarInfo(int cantidad)
        {
            Console.WriteLine($"\nValor del trago: {Valor}\n");

            Console.WriteLine($"\nValor con descuento: {CalcularPrecioFinal()}\n");

            Program.subTotal += CalcularPrecioFinal() * cantidad;

            Console.WriteLine($"Subtotal: " + Program.subTotal);
        }
        private double DescuentoDia()
        {
            string d = Dia.ToLower();

            if (d == "lunes")
                return Valor - (0.3 * Valor);
            else if (d == "martes")
                return Valor - (0.4 * Valor);
            else if (d == "miercoles" || d == "miércoles")
                return Valor - (0.5 * Valor);
            else if (d == "jueves")
                return Valor - (0.2 * Valor);
            else if (d == "viernes")
                return Valor - (0.1 * Valor);
            else if (d == "sabado" || d == "sábado")
                return Valor - (0.7 * Valor);
            else
                return Valor;
        }
    }
}
