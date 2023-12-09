public class Carro
{
    private int ano;
    public string Modelo { get; set; }
    public string Fabricante { get; set; }

    // exemplo utilizando lambda para get e set
    // ano do carro deve ser >= 1960 e <= 2023
    public int AnoFabricacao
    {
        get => ano;
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }
            else
            {
                ano = value;
            }

        }
    }
    public string DescricaoDetalhada => $"O fabricante {Fabricante} produziu o modelo {Modelo} em {AnoFabricacao}";



    public void Acelerar()
    {
        Console.WriteLine($"Carro acelerando");
    }
    public void Frear()
    {
        Console.WriteLine($"Carro freando");
    }
    public void Buzinar()
    {
        Console.WriteLine($"Carro buzinando");
    }
}

