namespace ExercicioExtra05___Armazenamento___Interface;

internal class BancoDeDados : IArmazenavel
{

    public string Nome { get; set; }

    public void Salvar(string nome)
    {
        Console.WriteLine($"Salvo informações no banco de dados {nome} com sucesso!");
    }

    public void Recuperar(string nome)
    {
        Console.WriteLine($"Recuperado informações do banco de dados {nome} com sucesso!");
    }

}
