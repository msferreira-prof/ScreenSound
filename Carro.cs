public class Carro
{
    public string placa;
    public string modelo;
    public double anoFabricacao;

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

