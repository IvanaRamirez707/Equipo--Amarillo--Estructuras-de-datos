using System;
using System.Collections.Generic;

namespace EstructurasDatos
{
    public class SistemaRetos
    {
        private Queue<string> colaRetos;

        public SistemaRetos()
        {
            colaRetos = new Queue<string>();
        }

        // Operación 1: Agregar reto a la fila (Enqueue)
        public void AgregarReto(string descripcionReto)
        {
            colaRetos.Enqueue(descripcionReto);
            Console.WriteLine($"[Sistema de Retos]: Nuevo reto añadido a la lista.");
        }

        // Operación 2: Completar/Procesar el reto actual (Dequeue)
        public void CompletarRetoActual()
        {
            if (colaRetos.Count == 0)
            {
                Console.WriteLine("¡No hay retos pendientes por completar!");
                return;
            }

            string retoCompletado = colaRetos.Dequeue();
            Console.WriteLine($"\n[¡Reto Completado!]: Doc ha superado: \"{retoCompletado}\"");
            Console.WriteLine($"(Quedan {colaRetos.Count} retos pendientes en la cola).");
        }

        // Operación 3: Ver el próximo reto sin eliminarlo (Peek)
        public void VerProximoReto()
        {
            if (colaRetos.Count == 0)
            {
                Console.WriteLine("La cola de retos está vacía.");
                return;
            }

            Console.WriteLine($"\n[Próximo Reto Activo (Peek)]: \"{colaRetos.Peek()}\"");
        }
    }
}