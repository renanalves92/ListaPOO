using System;

public class Comparador
{
    public double Valor1 { get; set; }
    public double Valor2 { get; set; }

    public Comparador(double valor1, double valor2)
    {
        Valor1 = valor1;
        Valor2 = valor2;
    }

    public double ExibirMaior()
    {
        return Valor1 > Valor2 ? Valor1 : Valor2;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro valor: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        Comparador comparador = new Comparador(valor1, valor2);
        Console.WriteLine($"O maior valor é: {comparador.ExibirMaior()}");
    }
}
