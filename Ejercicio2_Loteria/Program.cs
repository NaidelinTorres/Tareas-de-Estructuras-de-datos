using System;
using System.Collections.Generic;

public class Loteria
{
    // Lista que almacenará los números ganadores
    public List<int> Numeros { get; set; } = new List<int>();

    // Método para pedir los números al usuario
    public void PedirNumeros()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Introduce un número ganador: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Numeros.Add(numero);
        }
    }

    // Método para mostrar los números ordenados
    public void MostrarOrdenados()
    {
        Numeros.Sort(); // Ordena de menor a mayor
        Console.WriteLine("Los números ganadores son: " + string.Join(", ", Numeros));
    }
}

class Program
{
    static void Main()
    {
        // Crear objeto de la clase Loteria
        Loteria loteria = new Loteria();

        // Pedir números al usuario
        loteria.PedirNumeros();

        // Mostrar números ordenados
        loteria.MostrarOrdenados();
    }
}