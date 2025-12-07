using System; // Permite usar funciones básicas como Console.WriteLine

// Clase principal del programa.
// Aquí es donde se ejecutan las pruebas de las clases Circulo y Rectangulo.
class Program
{
    // Método Main: punto de inicio de la ejecución del programa.
    static void Main()
    {
        Console.WriteLine("=== Cálculo de Figuras Geométricas ===");

        // Crear un objeto de tipo Circulo con un radio de 5
        // Esto utiliza el constructor de la clase Circulo
        Circulo c = new Circulo(5);

        // Mostrar en pantalla el área del círculo
        Console.WriteLine("Área del círculo: " + c.CalcularArea());

        // Mostrar en pantalla el perímetro del círculo
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

        Console.WriteLine(); // Línea en blanco para separar resultados

        // Crear un objeto de tipo Rectangulo con ancho 4 y alto 6
        Rectangulo r = new Rectangulo(4, 6);

        // Mostrar en pantalla el área del rectángulo
        Console.WriteLine("Área del rectángulo: " + r.CalcularArea());

        // Mostrar en pantalla el perímetro del rectángulo
        Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
    }
}
