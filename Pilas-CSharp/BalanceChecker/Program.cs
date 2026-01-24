using System;
using System.Collections.Generic;

// Clase para verificar si una expresión matemática está balanceada
class BalanceChecker
{
    // Método que verifica si los paréntesis, llaves y corchetes están balanceados
    public static bool EstaBalanceada(string expression)
    {
        // Diccionario que relaciona símbolos de cierre con símbolos de apertura
        Dictionary<char, char> mapa = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        // Pila para almacenar los símbolos de apertura
        Stack<char> pila = new Stack<char>();

        // Recorrer cada carácter de la expresión
        foreach (char c in expression)
        {
            // Si el carácter es de apertura, se agrega a la pila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si el carácter es de cierre, se valida la pila
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía, la expresión no está balanceada
                if (pila.Count == 0)
                {
                    return false;
                }

                // Se obtiene el último símbolo de apertura
                char apertura = pila.Pop();

                // Se verifica que el símbolo de apertura coincida con el de cierre
                if (apertura != mapa[c])
                {
                    return false;
                }
            }
        }

        // La expresión es balanceada si la pila queda vacía
        return pila.Count == 0;
    }

    static void Main()
    {
        // Expresión de prueba
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
        Console.WriteLine("Expresión: " + expresion);

        // Evaluar si la expresión está balanceada
        if (EstaBalanceada(expresion))
        {
            Console.WriteLine("Fórmula balanceada.");
        }
        else
        {
            Console.WriteLine("Fórmula NO balanceada.");
        }
    }
}
