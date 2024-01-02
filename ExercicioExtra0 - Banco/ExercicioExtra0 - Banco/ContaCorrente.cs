namespace ExercicioExtra0___Banco;

internal class ContaCorrente : Conta
{

    public double Taxa { get; set; }

    public override void Sacar(double montante)
    {
        base.Sacar(montante - Taxa);
    }

}
