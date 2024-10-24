using System;

public class Quadrado
{
    public double Aresta { get; set; }

    public Quadrado(double aresta)
    {
        Aresta = aresta;
    }

    public double CalcularArea()
    {
        return Aresta * Aresta;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor da aresta do quadrado: ");
        double aresta = Convert.ToDouble(Console.ReadLine());

        Quadrado quadrado = new Quadrado(aresta);
        Console.WriteLine($"A área do quadrado é: {quadrado.CalcularArea()}");
    }
}
