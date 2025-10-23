using System.Reflection.Metadata.Ecma335;

namespace Estructuras
{
    public struct Producto {
        public string nombre;
        public double precio;
        public int cantidad;
    } 
    internal class Program
    {
        static Producto[] productos = new Producto[10];
        static int pos = 0;

        private static void Ingresar()
        {
            Producto producto = new Producto();
            Console.WriteLine("Escribe los siguientes datos:");
            Console.WriteLine("Nombre: ");
            producto.nombre = Console.ReadLine();
            Console.WriteLine("Precio: ");
            producto.precio = Double.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad: ");
            producto.cantidad = int.Parse(Console.ReadLine());
            productos[pos++] = producto;
        }

        private static void Mostrar()
        {
            for(int i = 0; i < pos; i++) {
                Console.WriteLine($"Nombre: {productos[i].nombre}");
                Console.WriteLine($"Precio: {productos[i].precio}");
                Console.WriteLine($"Cantidad: {productos[i].cantidad}");
            }
        }

        
        static void Main(string[] args)
        {
            

            int op = 0;
            while(op != 3)
            {
                Console.WriteLine("1. Ingresar ");
                Console.WriteLine("2. Mostrar ");
                Console.WriteLine("3. Salir ");
                op = int.Parse(Console.ReadLine());
                switch(op)
                {
                    case 1:
                        Ingresar();
                        break;
                    case 2:
                        Mostrar();
                        break;
                    case 3:
                        
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;

                }
            }

        }
    }
}
