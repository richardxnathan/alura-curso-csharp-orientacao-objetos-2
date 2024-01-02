namespace ExercicioExtra0___Eletronico;

internal class Smartphone : Eletronico
{

    public string SistemaOperacional { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, SO: {SistemaOperacional}";
    }

}
