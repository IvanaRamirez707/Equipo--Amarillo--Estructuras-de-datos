using System;
using System.Collections.Generic;

namespace EstructurasDatos
{
    public class PiezaRompecabezas
    {
        public int IdPieza { get; set; }
        public string NombrePieza { get; set; }
        public string CuentoAsociado { get; set; }

        public PiezaRompecabezas(int id, string nombre, string cuento)
        {
            IdPieza = id;
            NombrePieza = nombre;
            CuentoAsociado = cuento;
        }
    }

    public class InventarioPiezas
    {
        private List<PiezaRompecabezas> piezas;

        public InventarioPiezas()
        {
            piezas = new List<PiezaRompecabezas>();
        }

        // Operación 1: Agregar elemento a la lista
        public void AgregarPieza(int id, string nombre, string cuento)
        {
            piezas.Add(new PiezaRompecabezas(id, nombre, cuento));
            Console.WriteLine($"[Inventario]: Se guardó la pieza #{id} ({nombre}) para '{cuento}'.");
        }

        // Operación 2: Mostrar todos los elementos de la lista
        public void MostrarInventario()
        {
            if (piezas.Count == 0)
            {
                Console.WriteLine("El inventario de piezas está vacío.");
                return;
            }

            Console.WriteLine("\n=== INVENTARIO DE PIEZAS DE DOC (List<T>) ===");
            foreach (var pieza in piezas)
            {
                Console.WriteLine($"ID: #{pieza.IdPieza} | Pieza: {pieza.NombrePieza} | Cuento: {pieza.CuentoAsociado}");
            }
        }

        // Operación 3: Eliminar elemento por su ID
        public void EliminarPieza(int id)
        {
            PiezaRompecabezas piezaEncontrada = piezas.Find(p => p.IdPieza == id);
            if (piezaEncontrada != null)
            {
                piezas.Remove(piezaEncontrada);
                Console.WriteLine($"[Inventario]: Se ha encajado/eliminado la pieza #{id} del inventario.");
            }
            else
            {
                Console.WriteLine($"[Aviso]: No se encontró la pieza con ID #{id}.");
            }
        }
    }
}