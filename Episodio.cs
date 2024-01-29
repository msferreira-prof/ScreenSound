public class Episodio
{
    public int Numero { get; set; }
    public int Duracao { get; set; }
    public string Titulo { get; set; }

    private List<string> convidados = new List<string>();

    public string Resumo => $"{this.Numero}. {this.Titulo} ({this.Duracao} min) : {string.Join(", ", this.convidados)}";


    public Episodio(int numero, string titulo, int duracao)
    {
        Numero = numero;
        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}
