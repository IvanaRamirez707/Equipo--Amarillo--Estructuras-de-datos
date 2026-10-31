using System;

namespace EstructurasDatos
{
    // 1. Definición del Nodo que representa un cuento en "Uniendo Historias"
    public class NodoCuento
    {
        public string TituloCuento;
        public string DescripcionEscena;
        public NodoCuento Siguiente;
        public NodoCuento Anterior;

        public NodoCuento(string titulo, string descripcion)
        {
            TituloCuento = titulo;
            DescripcionEscena = descripcion;
            Siguiente = null;
            Anterior = null;
        }
    }

    // 2. Definición de la Lista Doblemente Enlazada
    public class ListaDoblementeEnlazada
    {
        private NodoCuento cabeza;
        private NodoCuento cola;

        public ListaDoblementeEnlazada()
        {
            cabeza = null;
            cola = null;
        }

        // OPERACIÓN 1: Insertar un nuevo cuento al final de la lista
        public void InsertarCuento(string titulo, string descripcion)
        {
            NodoCuento nuevoNodo = new NodoCuento(titulo, descripcion);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                cola.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = cola;
                cola = nuevoNodo;
            }
            Console.WriteLine($"[Biblioteca de Doc]: Se ha registrado el cuento '{titulo}'.");
        }

        // OPERACIÓN 2A: Recorrer y mostrar la lista hacia adelante
        public void MostrarCuentosAdelante()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La biblioteca de cuentos está vacía.");
                return;
            }

            Console.WriteLine("\n=== SELECCIÓN DE CUENTOS (Adelante) ===");
            NodoCuento actual = cabeza;
            int contador = 1;
            while (actual != null)
            {
                Console.WriteLine($"{contador}. Cuento: {actual.TituloCuento} -> Escena: {actual.DescripcionEscena}");
                actual = actual.Siguiente;
                contador++;
            }
        }

        // OPERACIÓN 2B: Recorrer y mostrar la lista hacia atrás
        public void MostrarCuentosAtras()
        {
            if (cola == null)
            {
                Console.WriteLine("La biblioteca de cuentos está vacía.");
                return;
            }

            Console.WriteLine("\n=== SELECCIÓN DE CUENTOS (Atrás) ===");
            NodoCuento actual = cola;
            int contador = 1;
            while (actual != null)
            {
                Console.WriteLine($"{contador}. Cuento: {actual.TituloCuento} -> Escena: {actual.DescripcionEscena}");
                actual = actual.Anterior;
                contador++;
            }
        }

        // OPERACIÓN 3: Buscar un cuento por su título
        public void BuscarCuento(string tituloBuscado)
        {
            if (cabeza == null)
            {
                Console.WriteLine("No hay cuentos para buscar.");
                return;
            }

            NodoCuento actual = cabeza;
            bool encontrado = false;

            while (actual != null)
            {
                if (actual.TituloCuento.Equals(tituloBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\n[¡Cuento Encontrado!]: '{actual.TituloCuento}'");
                    Console.WriteLine($"Descripción: {actual.DescripcionEscena}");
                    encontrado = true;
                    break;
                }
                actual = actual.Siguiente;
            }

            if (!encontrado)
            {
                Console.WriteLine($"\n[Aviso]: El cuento '{tituloBuscado}' no fue encontrado en los registros de Doc.");
            }
        }
    }
}