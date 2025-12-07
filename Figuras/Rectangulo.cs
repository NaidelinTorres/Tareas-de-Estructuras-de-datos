// La clase Rectangulo representa una figura geométrica con ancho y alto.
// Encapsula sus atributos y permite calcular el área y el perímetro.
public class Rectangulo
{
    // Atributos privados que guardan las dimensiones del rectángulo.
    private double ancho;
    private double alto;

    // Constructor de la clase Rectangulo.
    // Permite crear un rectángulo indicando su ancho y alto.
    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    // CalcularArea es un método que devuelve el área del rectángulo.
    // La fórmula del área es: ancho * alto
    public double CalcularArea()
    {
        return ancho * alto;
    }

    // CalcularPerimetro es un método que devuelve el perímetro del rectángulo.
    // La fórmula del perímetro es: 2 * (ancho + alto)
    public double CalcularPerimetro()
    {
        return 2 * (ancho + alto);
    }
}
