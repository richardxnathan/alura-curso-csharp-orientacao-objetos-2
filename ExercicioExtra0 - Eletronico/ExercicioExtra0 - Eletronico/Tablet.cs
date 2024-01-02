namespace ExercicioExtra0___Eletronico;

internal class Tablet : Eletronico
{

    public double TamanhoTela { get; set; }

    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Tamanho da Tela: {TamanhoTela}\"";
    }

}
