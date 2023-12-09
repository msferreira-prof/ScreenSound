public class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    // usando lambda para casos de propriedade get apenas
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Nome da música: {Duracao}");
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
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }
}
    