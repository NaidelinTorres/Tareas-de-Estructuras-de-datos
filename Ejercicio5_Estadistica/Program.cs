using System;
using System.Collections.Generic;
using System.Linq; // Para usar Average()

// Clase que representa un conjunto de datos estadísticos
public class Estadistica
{
    // Lista que almacena la muestra de números
    public List<double> Muestra { get; set; } = new List<double>();

    // Método para pedir la muestra al usuario
    public void PedirMuestra()
    {
        Console.WriteLine("Introduce los números separados por comas:");
        string[] entrada = Console.ReadLine().Split(',');

        // Convertir cada valor a número y añadirlo a la lista
        foreach (var n in entrada)
            Muestra.Add(double.Parse(n));
    }

    // Método para calcular y mostrar la media y desviación típica
    public void CalcularEstadisticas()
    {
        // Calcular la media
        double media = Muestra.Average();

        // Calcular la suma de cuadrados de las diferencias respecto a la media
        double sumaCuadrados = Muestra.Sum(x => Math.Pow(x - media, 2));

        // Calcular la desviación típica
        double desviacion = Math.Sqrt(sumaCuadrados / Muestra.Count);

        // Mostrar resultados
        Console.WriteLine($"La media es {media:F2}, y la desviación típica es {desviacion:F2}");
    }
}

class Program
{
    static void Main()
    {
        // Crear objeto de la clase Estadistica
        Estadistica estadistica = new Estadistica();

        // Pedir muestra al usuario
        estadistica.PedirMuestra();

        // Calcular y mostrar resultados
        estadistica.CalcularEstadisticas();
    }
}