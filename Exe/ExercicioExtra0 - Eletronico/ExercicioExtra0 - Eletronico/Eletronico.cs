namespace ExercicioExtra0___Eletronico;

abstract class Eletronico
{

    public string Modelo { get; set; }
    public double Preco { get; set; }

    public virtual string ExibirInformacoes()
    {
        return $"Modelo: {Modelo}, Preço: {Preco}";
    }

}
