namespace ExercicioExtra0___Banco;

internal class ContaPoupanca : Conta
{

    public double Rendimento { get; set; }

    public override double VerSaldo()
    {
        return base.VerSaldo() * (1 + Rendimento);
    }

}
