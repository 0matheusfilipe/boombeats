namespace Exercicios.FormasGeometricas;

internal class Triangulo : FormaGeometrica
{
    public double Altura { get; set; }
    public double Base { get; set; }

    public override double CalcularArea()
    {
        return Base * Altura * 0.5;
    }

    public override double CalcularPerimetro()
    {
        // Um triângulo qualquer
       return Base + Altura + Math.Sqrt(Base * Base + Altura * Altura);
    }
}
