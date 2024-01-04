namespace ExercicioExtra0___Venda___Interface;

internal class Servico
{

    public string Nome { get; set; }
    public decimal PrecoHora { get; set; }
    public int QuantidadeHoras { get; set; }

    public decimal CalcularPagamento()
    {
        return QuantidadeHoras * PrecoHora;
    }

}
