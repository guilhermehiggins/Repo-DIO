using System;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nota, quociente, resto;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            resto = n;

            while (resto != 0)
            {
                quociente = resto / 100;
                nota = resto / (int)100;
                Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
                resto = resto % 100;
            }

            

        }
    }
}
