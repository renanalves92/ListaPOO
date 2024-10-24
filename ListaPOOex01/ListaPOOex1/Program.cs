using System;

public class Retangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Retangulo(double baseRetangulo, double altura)
    {
        Base = baseRetangulo;
        Altura = altura;
    }

    public double CalcularArea()
    {
        return Base * Altura;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite a base do retângulo: ");
        double baseRetangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Retangulo retangulo = new Retangulo(baseRetangulo, altura);
        Console.WriteLine($"A área do retângulo é: {retangulo.CalcularArea()}");
    }
}
