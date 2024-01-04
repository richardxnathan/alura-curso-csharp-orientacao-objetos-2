public class Dono
{
    public string NomeCompleto { get; set; }
    public string Contato { get;  set; }

    public Dono (string nomeCompleto, string contato)
    {
        NomeCompleto = nomeCompleto;
        Contato = contato;
    }
}