//Crear un programa que maneje dos listas enlazadas de elementos que almacenan datos de tipo enteros.//
using System;

// CLASE NODO
// Representa cada elemento de la lista enlazada

public class Nodo
{
    // Dato que almacena el nodo
    public int Dato { get; set; }

    // Referencia al siguiente nodo (puede ser null)
    public Nodo? Siguiente { get; set; }

    // Constructor del nodo
    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

// CLASE LISTA ENLAZADA
// Maneja las operaciones de la lista

public class ListaEnlazada
{
    // Primer nodo de la lista (puede ser null si está vacía)
    public Nodo? Inicio { get; set; }

    // Inserta un nodo al final de la lista
    public void AgregarAlFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        // Si la lista está vacía
        if (Inicio == null)
        {
            Inicio = nuevo;
        }
        else
        {
            // Recorrer hasta el último nodo
            Nodo actual = Inicio;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            // Enlazar el nuevo nodo
            actual.Siguiente = nuevo;
        }
    }

    // Inserta un nodo al inicio de la lista
    public void AgregarAlInicio(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = Inicio;
        Inicio = nuevo;
    }

    // Cuenta la cantidad de elementos de la lista
    public int ContarElementos()
    {
        int contador = 0;
        Nodo? actual = Inicio;

        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    // Muestra los elementos de la lista
    public void MostrarElementos()
    {
        Nodo? actual = Inicio;

        if (actual == null)
        {
            Console.WriteLine("La lista está vacía");
            return;
        }

        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}

// CLASE PRINCIPAL

class Program
{
    // Verifica si un número es primo
    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    }

    // Verifica si un número es Armstrong
    static bool EsArmstrong(int numero)
    {
        int original = numero;
        int suma = 0;
        int digitos = numero.ToString().Length;

        while (numero > 0)
        {
            int digito = numero % 10;
            suma += (int)Math.Pow(digito, digitos);
            numero /= 10;
        }
        return suma == original;
    }

    // Método principal
    static void Main()
    {
        // Crear las dos listas enlazadas
        ListaEnlazada listaPrimos = new ListaEnlazada();
        ListaEnlazada listaArmstrong = new ListaEnlazada();

        Random rand = new Random();

        // Generar 50 números aleatorios entre 1 y 999
        for (int i = 0; i < 50; i++)
        {
            int numero = rand.Next(1, 1000);

            // Agregar números primos al final
            if (EsPrimo(numero))
                listaPrimos.AgregarAlFinal(numero);

            // Agregar números Armstrong al inicio
            if (EsArmstrong(numero))
                listaArmstrong.AgregarAlInicio(numero);
        }

        // Mostrar resultados
        Console.WriteLine("Lista de números primos:");
        listaPrimos.MostrarElementos();

        Console.WriteLine("Lista de números Armstrong:");
        listaArmstrong.MostrarElementos();

        // Contar elementos
        int totalPrimos = listaPrimos.ContarElementos();
        int totalArmstrong = listaArmstrong.ContarElementos();

        Console.WriteLine($"Total primos: {totalPrimos}");
        Console.WriteLine($"Total Armstrong: {totalArmstrong}");

        // Comparación de listas
        if (totalPrimos > totalArmstrong)
            Console.WriteLine("La lista de primos tiene más elementos");
        else if (totalPrimos < totalArmstrong)
            Console.WriteLine("La lista de Armstrong tiene más elementos");
        else
            Console.WriteLine("Ambas listas tienen la misma cantidad");
    }
}
