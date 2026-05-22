using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto[] productos =
            {
                new Producto("Coca Cola", 22f, 10),
                new Producto("Sabritas", 18f, 8),
                new Producto("Pepsi", 20f, 5),
                new Producto("Agua", 12f, 12)
            };

            int opcion ;
            char continuar ;
            do
            {
                Console.Clear();

                Console.WriteLine("===== MAQUINA EXPENDEDORA =====");
                Console.WriteLine();

                // Mostrar productos
                for (int i = 0; i < productos.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + productos[i].Nombre + "  Precio: $" + productos[i].Precio + "  Existencia: " + productos[i].Existencia);

                }

                Console.WriteLine();
                Console.WriteLine("1. Comprar");
                Console.WriteLine("2. Abastecer");

                Console.Write("Seleccione opcion: ");
                opcion = int.Parse(Console.ReadLine());

               
                switch (opcion)
                {
                    // Compra
                    case 1:
                        int indice;
                        int cantidad;
                        Console.Write("Seleccione producto: ");
                        indice = int.Parse(Console.ReadLine()) - 1;


                        Console.Write("Cantidad: ");
                        cantidad = int.Parse(Console.ReadLine());

                        //la cantidad elegida es menor o igual a lo que hay almacenado Y
                        //la cantidad elegida es mayor a 0 
                        if (cantidad <= productos[indice].Existencia && cantidad > 0)
                        {
                            float total = cantidad * productos[indice].Precio;

                            productos[indice].Existencia = productos[indice].Existencia - cantidad;

                            Console.WriteLine("Compra realizada");
                            Console.WriteLine("Total: $" + total);
                        }
                        else
                        {
                            Console.WriteLine("No hay suficiente inventario");

                        }
                        break;
                    // Agregar Productos
                    case 2:
                        
                        int agregar;
                        Console.Write("Seleccione producto: ");
                        indice = int.Parse(Console.ReadLine()) - 1;


                        Console.Write("Cantidad a agregar: ");
                        agregar = int.Parse(Console.ReadLine());


                        if (agregar > 0)
                        {
                            productos[indice].Existencia = productos[indice].Existencia + agregar;

                            Console.WriteLine("Inventario actualizado");

                        }
                        break;
                }
                Console.WriteLine("¿Desea continuar? (S/N)");
                continuar = char.Parse(Console.ReadLine().ToUpper());
            } while (continuar == 'S');

        }
    }
}
    


