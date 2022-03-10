using System;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, quociente;
            int[] notas = new int[] { 100, 50, 20, 10, 5, 2, 1 };

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            foreach (var nota in notas)
            {
                quociente = n / nota;
                Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
                n = n % nota;
            }
        }
    }
}
