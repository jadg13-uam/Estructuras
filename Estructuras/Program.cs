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
        static Stack<Producto> pila = new Stack<Producto>();
        static Queue<Producto> cola = new Queue<Producto>();

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

        public static void Apilar()
        {
            Producto producto = new Producto();
            Console.WriteLine("Escribe los siguientes datos:");
            Console.WriteLine("Nombre: ");
            producto.nombre = Console.ReadLine();
            Console.WriteLine("Precio: ");
            producto.precio = Double.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad: ");
            producto.cantidad = int.Parse(Console.ReadLine());

            //apilar
            pila.Push(producto);
        }

        public static void MostrarPila()
        {
            foreach(Producto prod in pila)
            {
                Console.Write(prod.nombre + " |");
            }
        }

        public static void Encolar()
        {
            Producto producto = new Producto();
            Console.WriteLine("Escribe los siguientes datos:");
            Console.WriteLine("Nombre: ");
            producto.nombre = Console.ReadLine();
            Console.WriteLine("Precio: ");
            producto.precio = Double.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad: ");
            producto.cantidad = int.Parse(Console.ReadLine());

            cola.Enqueue(producto);

        }

        public static void Desencolar()
        {
            foreach(Producto prod in cola)
            {
                Console.Write(prod.nombre + "|");
            } 
        }

        
        static void Main(string[] args)
        {
            

            int op = 0;
            while(op != 3)
            {
                Console.WriteLine();
                Console.WriteLine("1. Ingresar ");
                Console.WriteLine("2. Mostrar ");
                Console.WriteLine("3. Salir ");
                Console.WriteLine("4. Apilar ");
                Console.WriteLine("5. Mostrar Pila ");
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
                    case 4:
                        Apilar();
                        break;
                    case 5:
                        MostrarPila();
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;

                }
            }

        }
    }
}
