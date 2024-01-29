public class Musica
{

    public string Nome { get; }
    public Banda Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    // usando lambda para casos de propriedade get apenas
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome da música: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Nome da música: {Duracao}");
        Console.WriteLine($"Gênero musical: {Genero.Nome}");
        if (Disponivel) {
            Console.WriteLine($"Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }

        Console.WriteLine($"Descrição Resumida: {DescricaoResumida}");
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista.Nome}");
    }
}
    