using System;

class Quadrado

{
    public double Diagonal { get; set; }

    public double CalcularArea()
    {
        return (Diagonal * Diagonal) / 2;
    }

}

class Program
{
     static void Main()
    {
        Quadrado quadrado = new Quadrado();

        Console.Write("Digite a diagonal do quadrado: ");
        quadrado.Diagonal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"A área do quadrado é: {quadrado.CalcularArea()}");
    }
}