using System;

namespace Q10PruebaTecnica
{
    
    // Clase que representa una tarea individual en la lista de tareas
    internal class Tarea
    {
        // Propiedad que almacena la descripción de la tarea
        public string Descripcion {  get; private set; }
        
        // Propiedad que almacena la fecha límite de la tarea, si existe
        public DateTime? FechaLimite { get; private set; }
        
        // Propiedad que indica si la tarea ha sido completada o no
        public bool Completada { get; private set; }
        
        
        // Constructor que inicializa una nueva tarea con una descripción y una fecha límite opcional
        public Tarea (string descripcion, DateTime? fechalimite)
        {
            Descripcion = descripcion;
            FechaLimite = fechalimite;
            Completada = false;
        }

        // Método que marca la tarea como completada
        public void MarcarComoCompletada()
        {
            Completada = true;
        }
        
        // Método que sobrescribe el método ToString() para representar la tarea como una cadena de texto
        public override string ToString()
        {
            // Retorna una cadena con la descripción, fecha límite (si existe) y estado de la tarea
            return $"{Descripcion} (Fecha límite: {(FechaLimite.HasValue ? FechaLimite.Value.ToShortDateString() : "Sin fecha límite")}," +
                   $" Completada: {Completada})";

        }
    }
}
