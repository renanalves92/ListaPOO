using System;

public class ConversaoTemperatura
{
    public double Celsius { get; set; }

    public ConversaoTemperatura(double celsius)
    {
        Celsius = celsius;
    }

    public double ConverterParaFahrenheit()
    {
        return (Celsius * 9 / 5) + 32;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite a temperatura em Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        ConversaoTemperatura conversao = new ConversaoTemperatura(celsius);
        Console.WriteLine($"A temperatura em Fahrenheit é: {conversao.ConverterParaFahrenheit()}");
    }
}
