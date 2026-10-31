using System;

namespace EstructurasDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos las tres estructuras del Paquete 2
            ListaDoblementeEnlazada bibliotecaCuentos = new ListaDoblementeEnlazada();
            InventarioPiezas inventario = new InventarioPiezas();
            SistemaRetos colaRetos = new SistemaRetos();

            // Carga inicial de datos de prueba para "Uniendo Historias"
            bibliotecaCuentos.InsertarCuento("Hansel y Gretel", "Casa de dulces y la bruja.");
            bibliotecaCuentos.InsertarCuento("Alicia en el Pais de las Maravillas", "Fiesta del te con el Sombrerero Loco.");

            inventario.AgregarPieza(101, "Espejo Magico", "Alicia en el Pais de las Maravillas");
            inventario.AgregarPieza(102, "Llave Dorada", "Hansel y Gretel");

            colaRetos.AgregarReto("Encontrar el camino de migas de pan.");
            colaRetos.AgregarReto("Resolver el acertijo del Sombrerero.");

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n=============================================");
                Console.WriteLine("    UNIENDO HISTORIAS - PAQUETE 2 (KEVIN)   ");
                Console.WriteLine("=============================================");
                Console.WriteLine("1. Probar Lista Doblemente Enlazada (Selector de Cuentos)");
                Console.WriteLine("2. Probar List<T> (Inventario de Piezas)");
                Console.WriteLine("3. Probar Queue<T> (Sistema de Retos)");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opcion (1-4): ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MenuListaDoblementeEnlazada(bibliotecaCuentos);
                        break;
                    case "2":
                        MenuInventario(inventario);
                        break;
                    case "3":
                        MenuRetos(colaRetos);
                        break;
                    case "4":
                        salir = true;
                        Console.WriteLine("\nSaliendo del modulo de Paquete 2...");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida, intenta de nuevo.");
                        break;
                }
            }
        }

        // Submenú 1: Lista Doblemente Enlazada
        static void MenuListaDoblementeEnlazada(ListaDoblementeEnlazada biblioteca)
        {
            Console.WriteLine("\n--- MENU: LISTA DOBLEMENTE ENLAZADA ---");
            Console.WriteLine("1. Mostrar cuentos hacia adelante");
            Console.WriteLine("2. Mostrar cuentos hacia atras");
            Console.WriteLine("3. Buscar cuento por titulo");
            Console.Write("Elige una opcion: ");
            string subOp = Console.ReadLine();

            if (subOp == "1") biblioteca.MostrarCuentosAdelante();
            else if (subOp == "2") biblioteca.MostrarCuentosAtras();
            else if (subOp == "3")
            {
                Console.Write("Ingresa el titulo a buscar: ");
                string busqueda = Console.ReadLine();
                biblioteca.BuscarCuento(busqueda);
            }
        }

        // Submenú 2: Inventario (List<T>)
        static void MenuInventario(InventarioPiezas inventario)
        {
            Console.WriteLine("\n--- MENU: INVENTARIO DE PIEZAS (List<T>) ---");
            Console.WriteLine("1. Ver inventario completo");
            Console.WriteLine("2. Eliminar/Encajar pieza por ID");
            Console.Write("Elige una opcion: ");
            string subOp = Console.ReadLine();

            if (subOp == "1") inventario.MostrarInventario();
            else if (subOp == "2")
            {
                Console.Write("Ingresa el ID de la pieza a remover: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    inventario.EliminarPieza(id);
                }
            }
        }

        // Submenú 3: Sistema de Retos (Queue<T>)
        static void MenuRetos(SistemaRetos retos)
        {
            Console.WriteLine("\n--- MENU: SISTEMA DE RETOS (Queue<T>) ---");
            Console.WriteLine("1. Ver proximo reto activo (Peek)");
            Console.WriteLine("2. Completar reto actual (Dequeue)");
            Console.Write("Elige una opcion: ");
            string subOp = Console.ReadLine();

            if (subOp == "1") retos.VerProximoReto();
            else if (subOp == "2") retos.CompletarRetoActual();
        }
    }
}