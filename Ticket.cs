using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisa
{
    class Ticket
    {
        private List<Producto> lista = new List<Producto>();
        public List<Producto> Lista => lista;

        public void MostrarTicket()
        {
            foreach (Producto producto in Lista)
            {
                {
                    Console.WriteLine($"\nTrago: {producto.Nombre}, Precio Final: {producto.CalcularPrecioFinal():C}");

                }
            }
            Console.WriteLine($"\nTotal: {Program.subTotal}");
        }
        public void AgregarTrago(Producto producto)
        {
            lista.Add(producto);
        }
    }
}
