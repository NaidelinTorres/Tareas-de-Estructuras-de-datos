using System;
using System.Collections.Generic;
using System.Linq; // Para usar Min() y Max()

// Clase que representa una colección de precios
public class Precios
{
    // Lista de precios iniciales
    public List<int> ListaPrecios { get; set; } = new List<int> { 50, 75, 46, 22, 80, 65, 8 };

    // Método para calcular y mostrar el precio menor y mayor
    public void MostrarExtremos()
    {
        // Se obtiene el menor y el mayor usando LINQ
        int menor = ListaPrecios.Min();
        int mayor = ListaPrecios.Max();

        // Se muestran los resultados en consola
        Console.WriteLine($"El mínimo es {menor}");
        Console.WriteLine($"El máximo es {mayor}");
    }
}

class Program
{
    static void Main()
    {
        // Crear objeto de la clase Precios
        Precios precios = new Precios();

        // Mostrar el precio menor y mayor
        precios.MostrarExtremos();
    }
}