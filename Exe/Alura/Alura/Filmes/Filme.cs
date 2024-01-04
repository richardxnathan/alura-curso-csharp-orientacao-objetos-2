namespace Alura.Filmes;

class Filme
{
    public string Titulo { get; }
    public int Duracao { get; set; }
    public List<Artista> Elenco { get; set; } = [];

    public Filme(string titulo)
    {
        Titulo = titulo;
    }

    public void AdicionarArtista(Filme filme, Artista artista)
    {
        if (!Elenco.Contains(artista)) 
        {
            filme.Elenco.Add(artista);
            artista.FilmesAtuados.Add(filme);
            Console.WriteLine("Artista adicionado ao elenco do filme.");
        } 
        else
        {
            Console.WriteLine("Artista já foi adicionado ao elenco anteriormente.");
        }
    }
}