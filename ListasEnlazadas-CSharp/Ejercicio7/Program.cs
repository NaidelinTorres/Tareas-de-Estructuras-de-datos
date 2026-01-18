//Crear un programa que permita llevar el registro de los vehículos del estacionamiento del Área de Ingeniería de Sistemas de la Universidad utilizando como estructura de almacenamiento listas enlazadas.//
using System;

/// <summary>
/// Clase Vehiculo
/// Almacena la información de cada vehículo
/// </summary>
public class Vehiculo
{
    // Placa del vehículo
    public string Placa { get; set; }

    // Marca del vehículo
    public string Marca { get; set; }

    // Modelo del vehículo
    public string Modelo { get; set; }

    // Año de fabricación
    public int Año { get; set; }

    // Precio del vehículo
    public decimal Precio { get; set; }

    // Constructor de la clase Vehiculo
    public Vehiculo(string placa, string marca, string modelo, int año, decimal precio)
    {
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
        Año = año;
        Precio = precio;
    }
}

/// <summary>
/// Clase NodoVehiculo
/// Representa cada nodo de la lista enlazada
/// </summary>
public class NodoVehiculo
{
    // Dato almacenado en el nodo
    public Vehiculo Dato { get; set; }

    // Referencia al siguiente nodo (puede ser null)
    public NodoVehiculo? Siguiente { get; set; }

    // Constructor del nodo
    public NodoVehiculo(Vehiculo dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

/// <summary>
/// Clase ListaEnlazadaVehiculos
/// Maneja las operaciones de la lista enlazada
/// </summary>
public class ListaEnlazadaVehiculos
{
    // Primer nodo de la lista (puede ser null si está vacía)
    public NodoVehiculo? Cabeza { get; set; }

    /// <summary>
    /// Agrega un vehículo al final de la lista
    /// </summary>
    public void Agregar(Vehiculo vehiculo)
    {
        NodoVehiculo nuevo = new NodoVehiculo(vehiculo);

        // Si la lista está vacía, el nuevo nodo será la cabeza
        if (Cabeza == null)
        {
            Cabeza = nuevo;
        }
        else
        {
            // Recorrer la lista hasta el último nodo
            NodoVehiculo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            // Enlazar el nuevo nodo al final
            actual.Siguiente = nuevo;
        }
    }

    /// <summary>
    /// Busca un vehículo por su placa
    /// </summary>
    public Vehiculo? BuscarPorPlaca(string placa)
    {
        NodoVehiculo? actual = Cabeza;

        // Recorrer la lista hasta encontrar la placa
        while (actual != null)
        {
            if (actual.Dato.Placa == placa)
                return actual.Dato;

            actual = actual.Siguiente;
        }

        // Retorna null si no se encuentra
        return null;
    }

    /// <summary>
    /// Muestra los vehículos que pertenecen a un año específico
    /// </summary>
    public void MostrarVehiculosPorAño(int año)
    {
        NodoVehiculo? actual = Cabeza;

        while (actual != null)
        {
            if (actual.Dato.Año == año)
            {
                Console.WriteLine($"{actual.Dato.Placa} - {actual.Dato.Marca} {actual.Dato.Modelo} - ${actual.Dato.Precio}");
            }
            actual = actual.Siguiente;
        }
    }

    /// <summary>
    /// Muestra todos los vehículos registrados
    /// </summary>
    public void MostrarTodos()
    {
        NodoVehiculo? actual = Cabeza;

        // Verificar si la lista está vacía
        if (actual == null)
        {
            Console.WriteLine("No hay vehículos registrados");
            return;
        }

        // Recorrer y mostrar todos los nodos
        while (actual != null)
        {
            Console.WriteLine($"{actual.Dato.Placa} - {actual.Dato.Marca} {actual.Dato.Modelo} - Año: {actual.Dato.Año} - ${actual.Dato.Precio}");
            actual = actual.Siguiente;
        }
    }

    /// <summary>
    /// Elimina un vehículo de la lista según su placa
    /// </summary>
    public bool EliminarPorPlaca(string placa)
    {
        // Si la lista está vacía
        if (Cabeza == null) return false;

        // Si el vehículo a eliminar está en la cabeza
        if (Cabeza.Dato.Placa == placa)
        {
            Cabeza = Cabeza.Siguiente;
            return true;
        }

        // Buscar el vehículo en los siguientes nodos
        NodoVehiculo actual = Cabeza;
        while (actual.Siguiente != null)
        {
            if (actual.Siguiente.Dato.Placa == placa)
            {
                // Saltar el nodo eliminado
                actual.Siguiente = actual.Siguiente.Siguiente;
                return true;
            }
            actual = actual.Siguiente;
        }

        // Retorna false si no se encontró
        return false;
    }
}

/// <summary>
/// Clase principal del programa
/// </summary>
class Program
{
    static void Main()
    {
        // Crear la lista enlazada de vehículos
        ListaEnlazadaVehiculos lista = new ListaEnlazadaVehiculos();

        // Agregar vehículos a la lista
        lista.Agregar(new Vehiculo("ABC123", "Toyota", "Corolla", 2015, 18000));
        lista.Agregar(new Vehiculo("DEF456", "Honda", "Civic", 2019, 22000));
        lista.Agregar(new Vehiculo("GHI789", "Ford", "Focus", 2013, 14000));

        // Mostrar todos los vehículos
        Console.WriteLine("Vehículos registrados:");
        lista.MostrarTodos();

        // Mostrar vehículos de un año específico
        Console.WriteLine("\nVehículos del año 2015:");
        lista.MostrarVehiculosPorAño(2015);

        // Buscar un vehículo por placa
        Console.WriteLine("\nBuscar vehículo DEF456:");
        Vehiculo? v = lista.BuscarPorPlaca("DEF456");
        Console.WriteLine(v != null ? $"{v.Marca} {v.Modelo}" : "No encontrado");

        // Eliminar un vehículo
        Console.WriteLine("\nEliminar vehículo DEF456:");
        Console.WriteLine(lista.EliminarPorPlaca("DEF456") ? "Eliminado" : "No existe");

        // Mostrar la lista final
        Console.WriteLine("\nLista final:");
        lista.MostrarTodos();
    }
}
