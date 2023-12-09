public class Musica
{
    public string Nome;
    public string Artista;
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Nome da música: {Duracao}");
        if (Disponivel) {
            Console.WriteLine($"Disponível no plano.");
        } else
        {
            Console.Write("Adquira o plano Plus+");
        }
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }
}
    