public class Pet
{
    public string Nome { get; set; }
    public string Raca { get; set;}

    public Pet (string nome, string raca) 
    {
        Nome = nome;
        Raca = raca;
    }
}