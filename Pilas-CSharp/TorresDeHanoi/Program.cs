using System;
using System.Collections.Generic;

// Clase que resuelve el problema de las Torres de Hanoi utilizando pilas
class TorresDeHanoi
{
    // Método recursivo para resolver el problema de las Torres de Hanoi
    public static void ResolverHanoi(
        int n,
        Stack<int> origen,
        Stack<int> destino,
        Stack<int> auxiliar,
        string nombreOrigen,
        string nombreDestino,
        string nombreAuxiliar)
    {
        // Caso base: cuando solo hay un disco
        if (n == 1)
        {
            // Mover el disco desde la torre origen a la torre destino
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
        }
        else
        {
            // Mover n-1 discos desde la torre origen a la torre auxiliar
            ResolverHanoi(n - 1, origen, auxiliar, destino,
                          nombreOrigen, nombreAuxiliar, nombreDestino);

            // Mover el disco restante desde la torre origen a la torre destino
            ResolverHanoi(1, origen, destino, auxiliar,
                          nombreOrigen, nombreDestino, nombreAuxiliar);

            // Mover los n-1 discos desde la torre auxiliar a la torre destino
            ResolverHanoi(n - 1, auxiliar, destino, origen,
                          nombreAuxiliar, nombreDestino, nombreOrigen);
        }
    }

    static void Main()
    {
        // Número de discos
        int numDiscos = 3;

        // Validar que el número de discos sea mayor que cero
        if (numDiscos <= 0)
        {
            Console.WriteLine("El número de discos debe ser mayor a 0.");
            return;
        }

        // Crear las tres torres como pilas
        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> torreC = new Stack<int>();

        // Inicializar la torre A con los discos (del mayor al menor)
        for (int i = numDiscos; i >= 1; i--)
        {
            torreA.Push(i);
        }

        // Mostrar el inicio del proceso
        Console.WriteLine("Resolviendo Torres de Hanoi con " + numDiscos + " discos:");

        // Llamar al método que resuelve el problema
        ResolverHanoi(numDiscos, torreA, torreC, torreB, "A", "C", "B");
    }
}
