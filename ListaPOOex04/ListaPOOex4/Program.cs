using System;

class Triangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public double CalcularArea()
    {
        return Base * Altura / 2;

    }
}

class Program
{
    static void Main()
    {
        Triangulo triangulo = new Triangulo();

        Console.Write("Digite a base do triângulo: ");
        triangulo.Base = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do triângulo: ");
        triangulo.Altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"A área do triângulo é: {triangulo.CalcularArea()}");
    }
}