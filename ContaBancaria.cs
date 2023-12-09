public class ContaBancaria
{
	public int numero;
	public string titular;
	public double saldo;
	public string senha;

	public void ExibirContaBancaria()
	{
		Console.WriteLine($"Numero: {numero}");
		Console.WriteLine($"Titula: {titular}");
		Console.WriteLine($"Saldo: {saldo}");
	}

}


