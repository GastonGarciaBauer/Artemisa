using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisa
{
    internal class ItemPedido
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public ItemPedido(Producto producto, int cantidad)
        {
            this.Producto = producto;
            this.Cantidad = cantidad;
        }
        public double PrecioFinalPorItem()
        {
            return Producto.CalcularPrecioFinal() * Cantidad;
        }
    }
}
