using System.Diagnostics;
using System.Net.Sockets;

namespace Artemisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket();

            Console.WriteLine("\n\t\t\t |Artemisa - Tragos de Autor|\n");
            Console.WriteLine("\nIngresá tu nombre: \n");
            string nombre = Console.ReadLine();

            Console.WriteLine("\nIngresá el día de la semana actual: \n");
            string dia = Console.ReadLine();


            Console.Clear();

            bool agregarMas = true;

            Console.WriteLine("\n\t\t\t |Artemisa - Tragos de Autor|\n");

            Console.WriteLine("\n\t\t\t |TRAGOS|\n");
            Console.WriteLine($"\nHola {nombre}, Bienvenide!!!. Por favor, realizá tu pedido por número de  trago: \n");

            do
            {
                Console.WriteLine("\n1. Cascada Oriental\n");
                Console.WriteLine("\n2. Exilio SurCoreano\n");
                Console.WriteLine("\n3. Aguasturbias\n");
                Console.WriteLine("\n4. Colorado on the Rocks\n");
                Console.WriteLine("\n5. Cucumelo Indígena\n");
                Console.WriteLine("\n6. Jesus Christ Blood\n");
                Console.WriteLine("\n7. Amnistía Internacional\n");
                int trago = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPor favor, ingresá la cantidad de unidades que desees: \n");
                int cantidad = Convert.ToInt32(Console.ReadLine());


                switch (trago)
                {
                    case 1:
                        Producto trago1 = new Trago(1, "Cascada Oriental", 3200, dia, 0);

                        ticket.AgregarTrago(trago1);

                        Console.WriteLine($"\nValor del trago: {trago1.valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago1).valorDescuento}\n");

                        Console.WriteLine($"Subtotal: {(((Trago)trago1).valorDescuento) * cantidad}");


                        break;
                    case 2:
                        Producto trago2 = new Trago(2, "Exilio SurCoreano", 3100, dia, 0);

                        ticket.AgregarTrago(trago2);

                        Console.WriteLine($"\nValor del trago: {trago2.valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago2).valorDescuento}\n");

                        Console.WriteLine($"Subtotal: {(((Trago)trago2).valorDescuento) * cantidad}");
                        break;
                    case 3:
                        Producto trago3 = new Trago(3, "Aguasturbias", 3000, dia, 0);

                        ticket.AgregarTrago(trago3);

                        Console.WriteLine($"\nValor del trago: {trago3.valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago3).valorDescuento}\n");

                        Console.WriteLine($"Subtotal: {(((Trago)trago3).valorDescuento) * cantidad}");
                        break;
                    case 4:
                        Producto trago4 = new Trago(4, "Colorado on the Rocks", 3400, dia, 0);

                        ticket.AgregarTrago(trago4);

                        Console.WriteLine($"\nValor del trago: {trago4.valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago4).valorDescuento}\n");

                        Console.WriteLine($"Subtotal: {(((Trago)trago4).valorDescuento) * cantidad}");
                        break;
                    case 5:
                        Producto trago5 = new Trago(5, "Cucumelo Indígena", 3500, dia, 0);

                        ticket.AgregarTrago(trago5);

                        Console.WriteLine($"\nValor del trago: {trago5.valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago5).valorDescuento}\n");

                        Console.WriteLine($"Subtotal: {(((Trago)trago5).valorDescuento) * cantidad}");
                        break;
                    case 6:
                        Producto trago6 = new Trago(6, "Jesus Christ Blood", 3700, dia, 0);

                        ticket.AgregarTrago(trago6);

                        Console.WriteLine($"\nValor del trago: {trago6.valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago6).valorDescuento}\n");

                        Console.WriteLine($"Subtotal: {(((Trago)trago6).valorDescuento) * cantidad}");
                        break;
                    case 7:
                        Producto trago7 = new Trago(7, "Amnistía Internacional", 3800, dia, 0);

                        ticket.AgregarTrago(trago7);

                        Console.WriteLine($"\nValor del trago: {trago7.valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago7).valorDescuento}\n");

                        Console.WriteLine($"Subtotal: {(((Trago)trago7).valorDescuento) * cantidad}");
                        break;
                    default:
                        Console.WriteLine("\nPor favor, ingresá un número de Producto válido: \n");
                        break;
                }
                Console.WriteLine("\nDeseas agregar más tragos? s/n\n");
                string eleccion = Console.ReadLine();
                Console.Clear();

                if (eleccion.ToLower() == "s")
                {
                    agregarMas = true;
                }
                else
                {
                    agregarMas = false;
                }
            }

            while (agregarMas == true);

            Console.Clear();

            ticket.MostrarTicket();
        }
    }
}

// mostrar una carta de tragos
//el usuario puede escribir el numero del trago o el nombre del trago
//el usuario ingresa el día, los tragos y la cantidad de cada uno.
//se le calcula el precio total con descuento por promoción (combinación de trago) y promoción (día de la semana)
//se muestran los nombres de los tragos, con la cantidad de cada uno, el subtotal por trago y el total final.