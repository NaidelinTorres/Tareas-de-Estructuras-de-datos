using System;
using System.Collections.Generic;
using System.Linq;

// Clase que representa una asignatura con su nombre y nota
public class Asignatura
{
    public string Nombre { get; set; }
    public double Nota { get; set; }

    public Asignatura (string nombre)
    {
        Nombre = nombre;
    }

    // Método para pedir la nota al usuario
    public void PedirNota()
    {
        Console.Write($"¿Qué nota has sacado en {Nombre}? ");
        Nota = Convert.ToDouble(Console.ReadLine());
    }
}

public class Evaluacion
{
    public List<Asignatura> Asignaturas { get; set; }

    public Evaluacion(List<Asignatura> asignaturas)
    {
        Asignaturas = asignaturas;
    }

    // Método que filtra las asignaturas reprobadas (nota < 5)
    public void MostrarReprobadas()
    {
        var reprobadas = Asignaturas.Where(a => a.Nota < 5).ToList();

        Console.WriteLine("Tienes que repetir:");
        foreach (var a in reprobadas)
        {
            Console.WriteLine($"- {a.Nombre}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Lista de asignaturas
        List<Asignatura> asignaturas = new List<Asignatura>
        {
            new Asignatura("Matemáticas"),
            new Asignatura("Física"),
            new Asignatura("Química"),
            new Asignatura("Historia"),
            new Asignatura("Lengua")
        };

        // Se pide la nota de cada asignatura
        foreach (var a in asignaturas)
            a.PedirNota();

        // Se evalúan las asignaturas y se muestran las reprobadas
        Evaluacion evaluacion = new Evaluacion(asignaturas);
        evaluacion.MostrarReprobadas();
    }
}