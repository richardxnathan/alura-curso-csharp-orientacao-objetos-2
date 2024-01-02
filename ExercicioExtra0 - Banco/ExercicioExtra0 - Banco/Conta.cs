namespace ExercicioExtra0___Banco;

abstract class Conta
{

    public string Titular { get; set; }
    public int Numero { get; set; }
    public double Saldo { get; set; }

    public virtual void Depositar(double montante)
    {
        Saldo += montante;
    }

    public virtual void Sacar(double montante)
    {
        Saldo -= montante;
    }

    public virtual double VerSaldo()
    {
         return Saldo;
    }

}
