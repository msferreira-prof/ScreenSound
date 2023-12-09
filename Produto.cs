public class Produto
{
    private double preco;
    private int estoque;

    private int resultado, a, b;

    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Preco
    {
        get => preco;

        set
        {
            if (value > 0)
            {
                preco = value;
            }
            else
            {
                preco = 10;
            }
        }
    }

    public int Estoque
    {
        get => estoque;

        set
        {
            if (value > 0)
                estoque = value;
            else
                estoque = 0;
        }
    }

    public string DescricaoProduto => $"{this.Nome} {this.Marca} - {this.Preco}";

    // somar dois numeros utilizando funcoes Lambda
    public int Somar(int a, int b) => a + b;
}


