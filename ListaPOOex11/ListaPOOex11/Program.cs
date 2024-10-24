using System;

public class Pessoa
{
    public double Peso { get; set; }
    public double Altura { get; set; }

    public Pessoa(double peso, double altura)
    {
        Peso = peso;
        Altura = altura;
    }

    public double CalcularRelacaoPesoAltura()
    {
        return Peso / (Altura * Altura);
    }

    public string VerificarPesoIdeal()
    {
        double relacao = CalcularRelacaoPesoAltura();
        if (relacao < 20)
        {
            return "Abaixo do peso";
        }
        else if (relacao >= 20 && relacao < 25)
        {
            return "Peso ideal";
        }
        else
        {
            return "Acima do peso";
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o peso da pessoa (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura da pessoa (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Pessoa pessoa = new Pessoa(peso, altura);
        Console.WriteLine($"A relação peso/altura² é: {pessoa.CalcularRelacaoPesoAltura()}");
        Console.WriteLine(pessoa.VerificarPesoIdeal());
    }
}
