using System;
namespace RegistroEstudiante
{
    // Definición de la clase Estudiante
    class Estudiante
    {
        // Atributos utilizando propiedades autoimplementadas
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        // Array para almacenar los números de teléfono
        public string[] Telefonos { get; set; }
        // Constructor para inicializar los datos del estudiante
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            ID = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = telefonos;
        }
        // Método para mostrar la información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("=== Registro del Estudiante ===");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            // Recorrer el array de teléfonos
            foreach (string tel in Telefonos)
            {
                Console.WriteLine($"- {tel}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de registro de estudiante
            // Creación del array con tres números de teléfono
            string[] telefonos = new string[3];
            telefonos[0] = "0969286102";
            telefonos[1] = "0997977817";
            telefonos[2] = "0921004753";
            // Crear un objeto de la clase Estudiante utilizando el constructor
            Estudiante estudiante1 = new Estudiante(
                1,
                "Naidelin",
                "Sanmartin",
                "Av. A los Fundadores",
                telefonos
            );
            // Mostrar información del estudiante en consola
            estudiante1.MostrarInformacion();
            Console.ReadKey();
        }
    }
}
