using System;

namespace Q10PruebaTecnica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Crea una instancia del gestor de tareas para manejar las operaciones
            GestorDeTareas gestorDeTareas = new GestorDeTareas();
            bool salir = false; //Controlador del ciclo del menu

            // Ciclo que muestra el menú hasta que el usuario decida salir
            while (!salir)
            {
                // Muestra las opciones del menú
                Console.WriteLine("\nAplicación de Lista de Tareas");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Listar Tareas");
                Console.WriteLine("3. Marcar Tarea como Completada");
                Console.WriteLine("4. Eliminar Tarea");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");

                // Lee la opción seleccionada por el usuario
                switch (Console.ReadLine())
                {
                    case "1":
                        AgregarTarea(gestorDeTareas);
                        break;
                    case "2":
                        gestorDeTareas.ListarTareas();
                        break;
                    case "3":
                        MarcarTareaComoCompletada(gestorDeTareas);
                        break;
                    case "4":
                        EliminarTarea(gestorDeTareas);
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo.");
                        break;
                }
            }
        }

        // Método para agregar una tarea nueva
        static void AgregarTarea(GestorDeTareas gestorDeTareas)
        {
            Console.Write("Introduce la descripción de la tarea: ");
            string descripcion = Console.ReadLine();
            Console.Write("Introduce la fecha límite (opcional, formato: yyyy-mm-dd): ");
            DateTime? fechaLimite = null;

            // Intenta convertir la entrada de fecha a un valor de DateTime
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaParseada))
            {
                fechaLimite = fechaParseada; // Si la conversión es exitosa, asigna la fecha límite
            }
            // Agrega la tarea al gestor de tareas
            gestorDeTareas.AgregarTarea(descripcion, fechaLimite);
        }

        // Método para marcar una tarea como completada
        static void MarcarTareaComoCompletada(GestorDeTareas gestorDeTareas)
        {
            gestorDeTareas.ListarTareas();
            Console.Write("Introduce el número de la tarea a marcar como completada: ");

            // Intenta convertir la entrada a un índice de tarea
            if (int.TryParse(Console.ReadLine(), out int indice))
            {
                // Llama al método para marcar la tarea como completada
                gestorDeTareas.MarcarTareaComoCompletada(indice - 1);
            }
            else
            {
                // Muestra un mensaje de error si la entrada es inválida
                Console.WriteLine("Entrada inválida.");
            }
        }

        // Método para eliminar una tarea de la lista
        static void EliminarTarea(GestorDeTareas gestorDeTareas)
        {
            gestorDeTareas.ListarTareas();
            Console.Write("Introduce el número de la tarea a eliminar: ");

            // Intenta convertir la entrada a un índice de tarea
            if (int.TryParse(Console.ReadLine(), out int indice))
            {
                // Llama al método para eliminar la tarea
                gestorDeTareas.EliminarTarea(indice - 1);
            }
            else
            {
                // Muestra un mensaje de error si la entrada es inválida1
                
                Console.WriteLine("Entrada inválida.");
            }
        }
    
    }
}
