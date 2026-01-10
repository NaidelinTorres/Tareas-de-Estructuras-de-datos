using System;
using System.Collections.Generic;

// Clase que representa una asignatura con su nombre y nota
public class Asignatura
{
    // Propiedades: nombre de la asignatura y nota obtenida
    public string Nombre { get; set; }
    public double Nota { get; set; }

    // Constructor: inicializa la asignatura con su nombre
    public Asignatura (string nombre)
    {
        Nombre = nombre;
    }

    // Método para pedir la nota al usuario
    public void PedirNota()
    {
        Console.Write($"¿Qué nota has sacado en {Nombre}? ");
        Nota = Convert.ToDouble(Console.ReadLine()); // Se convierte la entrada a número
    }

    // Método para mostrar la nota obtenida
    public void MostrarNota()
    {
        Console.WriteLine($"En {Nombre} has sacado {Nota}");
    }
}

class Program
{
    static void Main()
    {
        // Lista de asignaturas del curso
        List<Asignatura> asignaturas = new List<Asignatura>
        {
            new Asignatura("Matemáticas"),
            new Asignatura("Física"),
            new Asignatura("Química"),
            new Asignatura("Historia"),
            new Asignatura("Lengua")
        };

        // Se pide la nota de cada asignatura al usuario
        foreach (var a in asignaturas)
            a.PedirNota();

        // Se muestran los resultados en pantalla
        foreach (var a in asignaturas)
            a.MostrarNota();
    }
}