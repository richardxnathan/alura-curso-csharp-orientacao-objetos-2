public class Veterinario
{
    public string NomeCompleto { get; set; }
    public string Especialidade { get; set; }

    public Veterinario(string nomeCompleto, string especialidade) 
    {
        NomeCompleto = nomeCompleto;
        Especialidade = especialidade;
    }
}