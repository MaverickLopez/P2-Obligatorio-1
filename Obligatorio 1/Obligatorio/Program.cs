using Dominio;

namespace Obligatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema s = new Sistema();

            //  --MENU COMPLETO--
            int op = -1;

            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("1 - Listar Clientes");
                Console.WriteLine("2 - Listar Articulos Filtrados con Categoria");
                Console.WriteLine("3 - Alta Articulo");
                Console.WriteLine("4 - Listar publicaciones entre x y x fecha");
                Console.WriteLine("0 - Salir");

                op = int.Parse(Console.ReadLine());

                //  --LISTAR TODOS LOS CLIENTES--
                if (op == 1)
                {
                    //  --Valida que no este vacia la lista de clientes y muestra mensaje--
                    if (s.GetClientes().Count == 0)
                    {
                        Console.WriteLine("No hay Clientes Registrados");
                    }
                    else
                    {
                        foreach (Cliente c in s.GetClientes())
                        {
                            Console.WriteLine("Nombre: " + c.Nombre + " - Apellido: " + c.Apellido + " - Email: " + c.Email + " - Saldo: " + c.Saldo);
                        }
                    }
                }
                //  --LISTAR ARTICULOS POR CATEGORIA INGRESADA--
                else if (op == 2)
                {
                    //  --Muestra todas las categorias disponibles--
                    Console.WriteLine("Categorias Disponibles: ");
                    foreach (string item in s.GetCategorias())
                    {
                        Console.WriteLine(item);
                    }

                    //  --Solicita categoria--
                    Console.WriteLine("Ingrese categoria");
                    string cat = Console.ReadLine();

                    //  --Valida la categoria y muestra mensaje--
                    if (!s.GetCategorias().Contains(cat))
                    {
                        Console.WriteLine("La Categoria ingresada no existe");
                    }
                    else
                    {
                        foreach (Articulo a in s.GetArticulosPorCategoria(cat))
                        {
                            Console.WriteLine("Nombre: " + a.Nombre + " - Categoria: " + a.Categoria + " - Precio: " + a.Precio);
                        }
                    }
                }
                //  --ALTA DE ARTICULO--
                else if (op == 3)
                {
                    //  --Solicita datos, valida y muestra mensaje--
                    try
                    {
                        Console.WriteLine("Nombre:");
                        string nom = Console.ReadLine();

                        Console.WriteLine("Categoria:");
                        string cat = Console.ReadLine();

                        Console.WriteLine("Precio:");
                        int pre = int.Parse(Console.ReadLine());


                        Articulo a = new Articulo(nom, cat, pre);

                        s.AltaArticulo(a);
                        Console.WriteLine("Alta correcta");
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
                //  --LISTAR PUBLICACIONES DADAS 2 FECHAS--
                else if (op == 4)
                {
                    //  --Solicita 2 fechas, valida y muestra mensaje--
                    try
                    {
                        Console.WriteLine("Fecha 1:");
                        DateTime f1 = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Fecha 2:");
                        DateTime f2 = DateTime.Parse(Console.ReadLine());

                        //  --Valida que la lista no este vacia y muestra mensaje--
                        if (s.GetPublicacionesPor2Fechas(f1, f2).Count == 0)
                        {
                            Console.WriteLine("No hay publicaciones publicadas entre esas fechas");
                        }
                        else
                        {
                            foreach (Publicacion p in s.GetPublicacionesPor2Fechas(f1, f2))
                            {
                                Console.WriteLine("ID:" + p.Id + ", Nombre: " + p.Nombre + ", Estado: " + p.Estado + ", Fecha de Publicacion: " + p.FechaPublicacion);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
