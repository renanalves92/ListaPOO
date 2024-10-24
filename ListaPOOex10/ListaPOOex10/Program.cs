using System;

public class RetanguloVerificado
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public RetanguloVerificado(double baseRetangulo, double altura)
    {
        Base = baseRetangulo;
        Altura = altura;
    }

    public double CalcularArea()
    {
        return Base * Altura;
    }

    public string VerificarTamanho()
    {
        double area = CalcularArea();
        return area > 100 ? "Terreno grande" : "Terreno pequeno";
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

        RetanguloVerificado retangulo = new RetanguloVerificado(baseRetangulo, altura);
        Console.WriteLine($"A área do retângulo é: {retangulo.CalcularArea()}");
        Console.WriteLine(retangulo.VerificarTamanho());
    }
}
