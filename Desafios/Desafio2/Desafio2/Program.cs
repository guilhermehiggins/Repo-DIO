// Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000).
// Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double nAoQuadrado = Math.Pow(i, 2);
                int total = i * (int)nAoQuadrado;

                Console.WriteLine($"{i} {nAoQuadrado} {total}");
            }
        }
    }
}