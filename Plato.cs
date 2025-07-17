using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisa
{
    public enum FormaDeCoccion
    {
        Frito,
        Hervido,
        Horneado,
        ALaPlancha,
        Crudo
    }

    public enum Guarnicion
    {
        PapasFritas,
        PapasAlHorno,
        PureDePapas,
        EnsaladaMixta
    }
    class Plato : Producto
    {
        public bool EsCaliente { get; set; }
        public FormaDeCoccion TipoCoccion { get; set; }
        public Guarnicion Guarnicion { get; set; }
        public bool TieneSalsa {  get; set; }
        public Plato(int id, string nombre, int valor, int stock, List<string> ingredientes, string tiempoPreparacion, bool aptoCeliacos, int nivelPicante, bool esCaliente, FormaDeCoccion tipoCoccion, Guarnicion guarnicion, bool tieneSalsa) : base(id, nombre, valor, stock, ingredientes, tiempoPreparacion, aptoCeliacos, nivelPicante)
        {
            this.EsCaliente = esCaliente;
            this.TipoCoccion = tipoCoccion;
            this.Guarnicion = guarnicion;
            this.TieneSalsa = tieneSalsa;
        }

        public override double CalcularPrecioFinal()
        {
            return Valor;
        }
        public override void MostrarInfo(int cantidad)
        {
            Console.WriteLine($"\nValor del plato: {Valor}\n");

            Program.subTotal += CalcularPrecioFinal() * cantidad;

            Console.WriteLine($"Subtotal: {Program.subTotal}\n");
        }

    }
}
