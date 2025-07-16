using System.Diagnostics;
using System.Net.Sockets;

namespace Artemisa
{
    internal class Program
    {
        public static double subTotal = 0;
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
                        Producto trago1 = new Trago(1, "Cascada Oriental", 3200, 15, new List<string> { "Vodka", "Lima", "Azúcar" }, dia, true);

                        ticket.AgregarTrago(trago1);

                        Console.WriteLine($"\nValor del trago: {trago1.Valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago1).CalcularPrecioFinal()}\n");

                        Program.subTotal = Program.subTotal + (((Trago)trago1).CalcularPrecioFinal()) * cantidad;

                        Console.WriteLine($"Subtotal: " + Program.subTotal);
                        


                        break;
                    case 2:
                        Producto trago2 = new Trago(2, "Exilio SurCoreano", 3100, 20, new List<string> { "Gin", "Campari", "Whisky" }, dia, true);

                        ticket.AgregarTrago(trago2);

                        Console.WriteLine($"\nValor del trago: {trago2.Valor}\n");


                        Console.WriteLine($"\nValor con descuento: {((Trago)trago2).CalcularPrecioFinal()}\n");
                        
                        Program.subTotal = Program.subTotal + (((Trago)trago2).CalcularPrecioFinal()) * cantidad;

                        Console.WriteLine($"Subtotal: " + Program.subTotal);

                        break;
                    case 3:
                        Producto trago3 = new Trago(3, "Aguasturbias", 3000, 10, new List<string> { "Ron", "Lima", "Albúmina" }, dia, true);

                        ticket.AgregarTrago(trago3);

                        Console.WriteLine($"\nValor del trago: {trago3.Valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago3).CalcularPrecioFinal()}\n");

                        Program.subTotal = Program.subTotal + (((Trago)trago3).CalcularPrecioFinal()) * cantidad;

                        Console.WriteLine($"Subtotal: " + Program.subTotal);
                        break;
                    case 4:
                        Producto trago4 = new Trago(4, "Colorado on the Rocks", 3400, 13, new List<string> { "Menta", "Limón", "Soda" }, dia, false);

                        ticket.AgregarTrago(trago4);

                        Console.WriteLine($"\nValor del trago: {trago4.Valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago4).CalcularPrecioFinal()}\n");

                        Program.subTotal = Program.subTotal + (((Trago)trago4).CalcularPrecioFinal()) * cantidad;

                        Console.WriteLine($"Subtotal: " + Program.subTotal);
                        break;
                    case 5:
                        Producto trago5 = new Trago(5, "Cucumelo Indígena", 3500, 9, new List<string> { "Tequila", "Lima", "Azúcar" }, dia, false);

                        ticket.AgregarTrago(trago5);

                        Console.WriteLine($"\nValor del trago: {trago5.Valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago5).CalcularPrecioFinal()}\n");

                        Program.subTotal = Program.subTotal + (((Trago)trago5).CalcularPrecioFinal()) * cantidad;

                        Console.WriteLine($"Subtotal: " + Program.subTotal);
                        break;
                    case 6:
                        Producto trago6 = new Trago(6, "Jesus Christ Blood", 3700, 13, new List<string> { "Vodka", "Arándanos", "Float de Vino Tinto" }, dia, true);

                        ticket.AgregarTrago(trago6);

                        Console.WriteLine($"\nValor del trago: {trago6.Valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago6).CalcularPrecioFinal()}\n");

                        Program.subTotal = Program.subTotal + (((Trago)trago6).CalcularPrecioFinal()) * cantidad;

                        Console.WriteLine($"Subtotal: " + Program.subTotal);
                        break;
                    case 7:
                        Producto trago7 = new Trago(7, "Amnistía Internacional", 3800, 13, new List<string> { "Naranja", "Granadina", "Anís Estrellado" }, dia, false);

                        ticket.AgregarTrago(trago7);

                        Console.WriteLine($"\nValor del trago: {trago7.Valor}\n");

                        Console.WriteLine($"\nValor con descuento: {((Trago)trago7).CalcularPrecioFinal()}\n");
                        
                        Program.subTotal = Program.subTotal + (((Trago)trago7).CalcularPrecioFinal()) * cantidad;

                        Console.WriteLine($"Subtotal: " + Program.subTotal);
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