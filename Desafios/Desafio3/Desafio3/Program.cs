// O programa deve ler um valor inteiro D indefinidas vezes, ele só irá parar quando o valor de D for igual a 0.
// Para cada D lido, imprima a soma dos 5 pares consecutivos a partir de D, inclusive ele mesmo , se for par.
// Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 4+6+8+10+12,
// enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20.


using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = int.Parse(Console.ReadLine());
            int soma = 0;

            while (D != 0)
            {
                if(D % 2 != 0)
                {
                    D++;
                }

                soma = 5 * D + 20;
                Console.WriteLine(soma);

                D = int.Parse(Console.ReadLine());
            }
        }
    }
}
