namespace Exercicios.FormasGeometricas;

internal class Circulo : FormaGeometrica
{
    public double Raio { get; set; }
    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }

}
