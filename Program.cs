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
            string eleccion = "";

            Console.WriteLine("\n\t\t\t |Artemisa - Tragos de Autor|\n");

            Console.WriteLine("\n\t\t\t |TRAGOS|\n");
            Console.WriteLine($"\nHola {nombre}, Bienvenide!!!. Por favor, realizá tu pedido por número de trago: \n");

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
                        Producto trago1 = new Trago(1, "Cascada Oriental", 3200, 15, new List<string> { "Vodka", "Lima", "Azúcar" }, "2 min.", true, 5, dia, true);

                        ticket.AgregarItem(trago1, cantidad);
                        
                        trago1.MostrarInfo(cantidad);


                        break;

                    case 2:
                        Producto trago2 = new Trago(2, "Exilio SurCoreano", 3100, 20, new List<string> { "Gin", "Campari", "Whisky" }, "3 min.", false, 7, dia, true);

                        ticket.AgregarItem(trago2, cantidad);
                        
                        trago2.MostrarInfo(cantidad);

                        break;

                    case 3:
                        Producto trago3 = new Trago(3, "Aguasturbias", 3000, 10, new List<string> { "Ron", "Lima", "Albúmina" }, "1.5 min.", true, 4, dia, true);

                        ticket.AgregarItem(trago3, cantidad);

                        trago3.MostrarInfo(cantidad);
                        
                        break;

                    case 4:
                        Producto trago4 = new Trago(4, "Colorado on the Rocks", 3400, 13, new List<string> { "Menta", "Limón", "Soda" }, "2.5 min.", true, 6, dia, false);

                        ticket.AgregarItem(trago4, cantidad);

                        trago4.MostrarInfo(cantidad);
                        
                        break;

                    case 5:
                        Producto trago5 = new Trago(5, "Cucumelo Indígena", 3500, 9, new List<string> { "Tequila", "Lima", "Azúcar" }, "1 min.", false, 3, dia, false);

                        ticket.AgregarItem(trago5, cantidad);

                        trago5.MostrarInfo(cantidad);
                        
                        break;
                    
                    case 6:
                        Producto trago6 = new Trago(6, "Jesus Christ Blood", 3700, 13, new List<string> { "Vodka", "Arándanos", "Float de Vino Tinto" }, "2 min.", true, 0, dia, true);

                        ticket.AgregarItem(trago6, cantidad);

                        trago6.MostrarInfo(cantidad);
                        
                        break;
                    
                    case 7:
                        Producto trago7 = new Trago(7, "Amnistía Internacional", 3800, 13, new List<string> { "Naranja", "Granadina", "Anís Estrellado" }, "1 min.", true, 8, dia, false);

                        ticket.AgregarItem(trago7, cantidad);

                        trago7.MostrarInfo(cantidad);
                        
                        break;
                    
                    default:
                        Console.WriteLine("\nPor favor, ingresá un número de trago válido: \n");
                        
                        break;
                }
                Console.WriteLine("\nDeseas agregar más tragos? s/n\n");
                eleccion = Console.ReadLine();
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

            Console.WriteLine($"\nDeseas algo de comer? s/n\n");
            eleccion = Console.ReadLine();

            if (eleccion.ToLower() == "s")
            {
                Console.WriteLine("\n\t\t\t |PLATOS|\n");
                Console.WriteLine($"\nPor favor, realizá tu pedido por número de plato: \n");

                do
                {
                    Console.WriteLine("\n1. Revolución a la Plancha\n");
                    Console.WriteLine("\n2. Hambre del Desierto\n");
                    Console.WriteLine("\n3. Buda Empanado\n");
                    Console.WriteLine("\n4. Sopa del Juicio Final\n");
                    Console.WriteLine("\n5. Parabellum\n");
                    Console.WriteLine("\n6. My Queen\n");
                    Console.WriteLine("\n7. Alea Jacta Est\n");
                    int plato = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nPor favor, ingresá la cantidad de unidades que desees: \n");
                    int cantidad2 = Convert.ToInt32(Console.ReadLine());

                    switch (plato)
                    {
                        case 1:
                            Producto plato1 = new Plato(1, "Revolución a la Plancha", 3200, 15, new List<string> { "Pollo", "Cebolla morada", "Pimiento rojo", "Salsa de soja", "Aceite de oliva" }, "15 min", true, 6, true, FormaDeCoccion.Frito, Guarnicion.PapasFritas, false);

                            ticket.AgregarItem(plato1, cantidad2);
                            
                            plato1.MostrarInfo(cantidad2);

                            break;

                        case 2:
                            Producto plato2 = new Plato(2, "Hambre del Desierto", 3100, 20, new List<string> { "Couscous", "Garbanzos tostados", "Harissa" }, "12 min", false, 5, false, FormaDeCoccion.Horneado, Guarnicion.PureDePapas, false);

                            ticket.AgregarItem(plato2, cantidad2);

                            plato2.MostrarInfo(cantidad2);

                            break;

                        case 3:
                            Producto plato3 = new Plato(3, "Buda Empanado", 3000, 10, new List<string> { "Kimchi", "Arroz blanco", "Tofu salteado", "Salsa de sésamo" }, "10 min", true, 2, false, FormaDeCoccion.ALaPlancha, Guarnicion.EnsaladaMixta, true);

                            ticket.AgregarItem(plato3, cantidad2);

                            plato3.MostrarInfo(cantidad2);
                            
                            break;

                        case 4:
                            Producto plato4 = new Plato(4, "Sopa del Juicio Final", 3400, 13, new List<string> { "Caldo picante", "Fideos", "Cebolla de verdeo" }, "8 min", true, 9, true, FormaDeCoccion.Hervido, Guarnicion.PapasAlHorno, true);

                            ticket.AgregarItem(plato4, cantidad2);

                            plato4.MostrarInfo(cantidad2);
                            
                            break;
                        
                        case 5:
                            Producto plato5 = new Plato(5, "Parabellum", 3500, 9, new List<string> { "Lentejas", "Calabaza asada", "Yogur natural" }, "16 min", true, 7, false, FormaDeCoccion.Horneado, Guarnicion.EnsaladaMixta, false);

                            ticket.AgregarItem(plato5, cantidad2);

                            plato5.MostrarInfo(cantidad2);
                            
                            break;
                        
                        case 6:
                            Producto plato6 = new Plato(6, "My Queen", 3700, 13, new List<string> { "Berenjena", "Panko", "Curry en polvo" }, "13 min", true, 4, false, FormaDeCoccion.Frito, Guarnicion.PureDePapas, true);

                            ticket.AgregarItem(plato6, cantidad2);

                            plato6.MostrarInfo(cantidad2);
                            
                            break;
                        
                        case 7:
                            Producto plato7 = new Plato(7, "Alea Jacta Est", 3800, 13, new List<string> { "Repollo", "Panceta", "Pimentón ahumado" }, "7 min", false, 4, false, FormaDeCoccion.Crudo, Guarnicion.PureDePapas, false);

                            ticket.AgregarItem(plato7, cantidad2);

                            plato7.MostrarInfo(cantidad2);
                            
                            break;
                        
                        default:
                            Console.WriteLine("\nPor favor, ingresá un número de plato válido: \n");
                            
                            break;
                    }

                    Console.WriteLine("\nDeseas agregar más platos? s/n\n");
                    eleccion = Console.ReadLine();
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
                //ticket.MostrarTicket();
            }
            ticket.MostrarTicket();
        }
    }
}

// mostrar una carta de tragos
//el usuario puede escribir el numero del trago o el nombre del trago
//el usuario ingresa el día, los tragos y la cantidad de cada uno.
//se le calcula el precio total con descuento por promoción (combinación de trago) y promoción (día de la semana)
//se muestran los nombres de los tragos, con la cantidad de cada uno, el subtotal por trago y el total final.