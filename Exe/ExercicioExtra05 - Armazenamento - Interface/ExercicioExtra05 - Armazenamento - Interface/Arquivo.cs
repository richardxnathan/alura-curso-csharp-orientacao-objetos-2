namespace ExercicioExtra05___Armazenamento___Interface;

internal class Arquivo : IArmazenavel
{

    public string Nome { get; set; }

    public void Salvar(string nome)
    {
        Console.WriteLine($"Arquivo {nome} salvo com sucesso!");
    }

    public void Recuperar(string nome)
    {
        Console.WriteLine($"Arquivo {nome} recuperado com sucesso!");
    }

}
