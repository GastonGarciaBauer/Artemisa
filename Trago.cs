using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemisa
{
    class Trago : Producto
    {
        public string dia { get; set; }
        public Trago(int id, string nombre, int valor, string dia) : base(id, nombre, valor)
        {
            this.dia = dia;
        }
        public override double CalcularPrecioFinal()
        {
            return DescuentoDia();
        }
        private double DescuentoDia()
        {
            string d = dia.ToLower();

            if (d == "lunes")
                return valor - (0.3 * valor);
            else if (d == "martes")
                return valor - (0.4 * valor);
            else if (d == "miercoles" || d == "miércoles")
                return valor - (0.5 * valor);
            else if (d == "jueves")
                return valor - (0.2 * valor);
            else if (d == "viernes")
                return valor - (0.1 * valor);
            else if (d == "sabado" || d == "sábado")
                return valor - (0.7 * valor);
            else
                return valor;
        }
    }
}
