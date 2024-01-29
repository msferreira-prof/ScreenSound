public class Podcast
{
    public string Nome { get; set; }
    public string Host { get; set; }
    public int TotalEpisodios => this.episodios.Count();

    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine("\n");
        Console.WriteLine($"Podcast {this.Nome} apresentado por {this.Host}");
        foreach(Episodio episodio in episodios.OrderBy(x => x.Numero))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este Podcast tem {this.TotalEpisodios} episódios");
    }
}


