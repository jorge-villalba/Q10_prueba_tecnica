using System;
using System.Collections.Generic;

namespace Q10PruebaTecnica
{
    // Clase que gestiona la lista de tareas y las operaciones asociadas
    internal class GestorDeTareas
    {
        // Lista que almacena todas las tareas
        private List<Tarea> tareas = new List<Tarea>();

        // Método para agregar una nueva tarea a la lista
        public void AgregarTarea(string descripcion, DateTime? fechaLimite = null)
        {
            // Crea una nueva tarea y la agrega a la lista de tareas
            tareas.Add(new Tarea(descripcion, fechaLimite));
        }

        // Método para listar todas las tareas en la consola
        public void ListarTareas()
        {
            if (tareas.Count == 0)
            {
                // Si no hay tareas, muestra un mensaje indicando que la lista está vacía
                Console.WriteLine("No hay tareas disponibles.");
                return;
            }

            // Itera sobre la lista de tareas y las imprime en la consola
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }

        // Método para marcar una tarea específica como completada
        public void MarcarTareaComoCompletada(int indice)
        {
            if (indice >= 0 && indice < tareas.Count)
            {
                // Si el índice es válido, marca la tarea como completada
                tareas[indice].MarcarComoCompletada();
            }
            else
            {
                // Si el índice no es válido, muestra un mensaje de error
                Console.WriteLine("Índice de tarea inválido.");
            }
        }

        // Método para eliminar una tarea de la lista
        public void EliminarTarea(int indice)
        {
            if (indice >= 0 && indice < tareas.Count)
            {
                // Si el índice es válido, elimina la tarea de la lista
                tareas.RemoveAt(indice);
            }
            else
            {
                // Si el índice no es válido, muestra un mensaje de error
                Console.WriteLine("Índice de tarea inválido.");
            }
        }
    }
}
