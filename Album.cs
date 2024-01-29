public class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }

    // Lambda para pegar a duração de cada musica e somar para ter a duração total
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);


    public Album(string nome)
    {
        Nome = nome;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"\nLista de músicas do álbum {Nome}:\n");
        foreach(var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este álbum inteiro você precisa de {DuracaoTotal} minutos");
    }
}