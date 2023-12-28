namespace Alura.Filmes;

class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> FilmesAtuados { get; set; }

    public void AdicionarFilme(Filme filme, Artista artista)
    {
        if (!FilmesAtuados.Contains(filme))
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