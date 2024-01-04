namespace ExercicioExtra0___Veiculo___Interface;

internal class Veiculo : IPilotavel, IVoavel
{
    public void Pilotar()
    {
        Console.WriteLine("O veículo está sendo pilotado!");
    }

    public void Voar()
    {
        Console.WriteLine("O veículo está voando!");
    }

}
