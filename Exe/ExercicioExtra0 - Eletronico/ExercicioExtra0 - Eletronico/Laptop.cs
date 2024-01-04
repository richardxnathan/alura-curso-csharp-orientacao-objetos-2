namespace ExercicioExtra0___Eletronico;

internal class Laptop : Eletronico
{

    public string Processador { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Processador: {Processador}";
    }

}
