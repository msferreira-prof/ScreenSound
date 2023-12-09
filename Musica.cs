public class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel;

    public void EscreveDisponivel(bool disponivel)
    {
        this.disponivel = disponivel;
    }

    public bool LeDisponivel()
    {
        return disponivel;
    }



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Nome da música: {duracao}");
        if (disponivel) {
            Console.WriteLine($"Disponível no plano.");
        } else
        {
            Console.Write("Adquira o plano Plus+");
        }
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {nome} - {artista}");
    }
}
    