namespace ExercicioExtra0___Formas_Geometricas;

internal class Círculo : FormaGeometrica
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
