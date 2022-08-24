using Soma.Calculo;
using System;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            var numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um número inteiro: ");
            var numero2 = int.Parse(Console.ReadLine());

            SomaImpares resultado = new SomaImpares(numero1, numero2);
            Console.WriteLine(resultado.SomaDeImpares());
        }
    }
}
