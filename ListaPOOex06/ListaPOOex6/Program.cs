using System;

public class ConversaoDistancia
{
    const double MetrosPorMilhaMaritima = 1852;
    const double MetrosPorQuilometro = 1000;

    public double ConverterMilhasParaQuilometros(double milhasMaritimas)
    {
        double metros = milhasMaritimas * MetrosPorMilhaMaritima;
        return metros / MetrosPorQuilometro;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor em milhas marítimas: ");
        double milhas = Convert.ToDouble(Console.ReadLine());

        ConversaoDistancia conversao = new ConversaoDistancia();
        Console.WriteLine($"O valor em quilômetros é: {conversao.ConverterMilhasParaQuilometros(milhas)} km");
    }
}
