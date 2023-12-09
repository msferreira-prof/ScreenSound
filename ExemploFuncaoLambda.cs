public class ExemploFuncaoLambda
{

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    bool BuscarNumerosQueSaoPares(int numero)
    {
        return numero % 2 == 0;
    }



    public void Main()
    {
        // nao utilizando Lambda
        List<int> numerosPares = numeros.FindAll(BuscarNumerosQueSaoPares);

        foreach (int numero in numerosPares)
        {
            Console.WriteLine(numero);
        }

        // utilizando Lambda
        List<int> numerosParesLambda = numerosPares.FindAll(numero => numero % 2 == 0);
        numerosPares.ForEach(numero => Console.WriteLine(numero));
    }
}