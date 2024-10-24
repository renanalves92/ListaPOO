using System;

public class Triangulo
{
    public double Lado1 { get; set; }
    public double Lado2 { get; set; }
    public double Lado3 { get; set; }

    public Triangulo(double lado1, double lado2, double lado3)
    {
        Lado1 = lado1;
        Lado2 = lado2;
        Lado3 = lado3;
    }

    public bool VerificarSeFormaTriangulo()
    {
        return (Lado1 + Lado2 > Lado3) && (Lado1 + Lado3 > Lado2) && (Lado2 + Lado3 > Lado1);
    }

    public string ClassificarTriangulo()
    {
        if (Lado1 == Lado2 && Lado2 == Lado3)
        {
            return "Equilátero";
        }
        else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)
        {
            return "Isósceles";
        }
        else
        {
            return "Escaleno";
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor do primeiro lado: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor do segundo lado: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor do terceiro lado: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        Triangulo triangulo = new Triangulo(lado1, lado2, lado3);
        if (triangulo.VerificarSeFormaTriangulo())
        {
            Console.WriteLine($"Os lados formam um triângulo {triangulo.ClassificarTriangulo()}.");
        }
        else
        {
            Console.WriteLine("Os valores não formam um triângulo.");
        }
    }
}
