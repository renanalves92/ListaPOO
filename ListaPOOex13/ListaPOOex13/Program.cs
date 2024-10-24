using System;

public class TrianguloRetangulo
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public TrianguloRetangulo(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public bool VerificarTrianguloRetangulo()
    {
        double hipotenusa = Math.Max(A, Math.Max(B, C));
        double somaDosCatetos = A == hipotenusa ? B * B + C * C : (B == hipotenusa ? A * A + C * C : A * A + B * B);
        return hipotenusa * hipotenusa == somaDosCatetos;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor do primeiro lado: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor do segundo lado: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor do terceiro lado: ");
        double c = Convert.ToDouble(Console.ReadLine());

        TrianguloRetangulo triangulo = new TrianguloRetangulo(a, b, c);
        if (triangulo.VerificarTrianguloRetangulo())
        {
            Console.WriteLine("Os valores formam um triângulo retângulo.");
        }
        else
        {
            Console.WriteLine("Os valores não formam um triângulo retângulo.");
        }
    }
}
