using System;

public class ConversaoMoeda
{
    public double CotacaoDolar { get; set; }

    public ConversaoMoeda(double cotacao)
    {
        CotacaoDolar = cotacao;
    }

    public double ConverterParaReais(double valorDolares)
    {
        return valorDolares * CotacaoDolar;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite a cotação do dólar: ");
        double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor em dólares: ");
        double valorDolares = Convert.ToDouble(Console.ReadLine());

        ConversaoMoeda conversao = new ConversaoMoeda(cotacaoDolar);
        Console.WriteLine($"O valor em reais é: R${conversao.ConverterParaReais(valorDolares)}");
    }
}
