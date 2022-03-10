using System;
using System.Globalization;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0], CI);
            b = Convert.ToDouble(valor[1], CI);
            c = Convert.ToDouble(valor[2], CI);

            double soma = a + b;

            if((a < b + c) && (b < a + c) && (c < b + a))
            {
                double perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1", CI)}");
            }
            else
            {
                double area = ((a + b) * c) / 2.0;
                Console.WriteLine($"Area = {area.ToString("F1", CI)}");
            }

        }
    }
}
