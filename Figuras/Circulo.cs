// La clase Circulo representa una figura geométrica de tipo círculo.
// Encapsula el atributo radio y permite calcular su área y perímetro.
public class Circulo
{
    // Atributo privado que guarda el valor del radio del círculo
    private double radio;

    // Constructor que recibe el radio y lo asigna al atributo de la clase
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método que calcula y devuelve el área del círculo usando la fórmula: π * r²
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Método que calcula y devuelve el perímetro (circunferencia) usando la fórmula: 2 * π * r
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}
