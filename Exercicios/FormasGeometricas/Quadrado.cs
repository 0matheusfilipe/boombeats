namespace Exercicios.FormasGeometricas;

internal class Quadrado : FormaGeometrica
{
    public double Lado { get; set; }
    public override double CalcularArea()
    {
        return Lado * Lado;
    }
    public override double CalcularPerimetro()
    {
        return Lado * 4;
    }
}
