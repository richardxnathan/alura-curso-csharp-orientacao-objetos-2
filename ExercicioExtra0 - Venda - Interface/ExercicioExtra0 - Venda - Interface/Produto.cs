namespace ExercicioExtra0___Venda___Interface;

internal class Produto : IPagavel
{

    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public decimal CalcularPagamento()
    {
        return Quantidade * Preco;
    }

}
