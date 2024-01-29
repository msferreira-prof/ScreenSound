public class Conta
{
    public int Agencia { get; set; }
    public int Numero { get; set; }
    public float Saldo { get; set; }
    public float Limite { get; set; }

    public Titular Titular { get; set; }

    public string Informacoes => $"Conta no. {this.Numero}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

    public Conta (int agencia, int numero, float saldo, float limite, Titular titular)
    {
        Agencia = agencia;
        Numero = numero;
        Saldo = saldo;
        Limite = limite;
        Titular = titular;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Agencia: {Agencia}");
        Console.WriteLine($"Conta..: {Numero}");
        Console.WriteLine($"Saldo..: {Saldo}");
        Console.WriteLine($"Limite.: {Limite}");
        Console.WriteLine($"Titular:");
        Console.WriteLine($"\tNome..: {Titular.Nome}");
        Console.WriteLine($"\tGênero: {Titular.Genero}");
    }
}