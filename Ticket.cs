using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisa
{
    class Ticket
    {
        private List<ItemPedido> lista = new List<ItemPedido>();
        public List<ItemPedido> Lista => lista;
        
        public void AgregarItem(Producto producto, int cantidad)
        {
            lista.Add(new ItemPedido(producto, cantidad));
        }
        public void MostrarTicket()
        {
            foreach (ItemPedido item in Lista)
            {
                Producto producto = item.Producto;
                string tipo = producto is Trago ? "Trago" : "Plato";
                Console.WriteLine($"\n{tipo}: {producto.Nombre} x{item.Cantidad} - Precio Final unitario: {producto.CalcularPrecioFinal():C} - Total: {item.PrecioFinalPorItem():C}");
            }
            Console.WriteLine($"\nTotal: {Program.subTotal}");
        }
    }
}
