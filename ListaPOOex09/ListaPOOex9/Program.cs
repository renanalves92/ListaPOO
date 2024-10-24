using System;

public class ComparadorValores
{
    public double Valor1 { get; set; }
    public double Valor2 { get; set; }

    public ComparadorValores(double valor1, double valor2)
    {
        Valor1 = valor1;
        Valor2 = valor2;
    }

    public string Comparar()
    {
        if (Valor1 > Valor2)
            return $"O maior valor é: {Valor1}";
        else if (Valor2 > Valor1)
            return $"O maior valor é: {Valor2}";
        else
            return "Os números são idênticos.";
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

        ComparadorValores comparador = new ComparadorValores(valor1, valor2);
        Console.WriteLine(comparador.Comparar());
    }
}
