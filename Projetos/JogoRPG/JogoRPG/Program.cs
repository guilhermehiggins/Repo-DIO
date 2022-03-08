using System;
using JogoRPG.Entities;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 42, "Knight", 749, 72);
            Ninja ninja = new Ninja("Wedge", 42, "Ninja", 574, 89);
            WhiteWizard whiteWizard = new WhiteWizard("Jennica", 42, "White Wizard", 601, 482);
            BlackWizard blackWizard = new BlackWizard("Topapa", 42, "Black Wizard", 385, 641);

            //Exemplo de ataques dos Heroes

            Console.WriteLine(knight.Attack(0));
            Console.WriteLine(knight.Attack(7));
            Console.WriteLine(knight.Attack(15));

            Console.WriteLine(ninja.Attack(0));
            Console.WriteLine(ninja.Attack(5));
            Console.WriteLine(ninja.Attack(17));

            Console.WriteLine(whiteWizard.Attack(0));
            Console.WriteLine(whiteWizard.Attack(9));
            Console.WriteLine(whiteWizard.Attack(12));

            Console.WriteLine(blackWizard.Attack(0));
            Console.WriteLine(blackWizard.Attack(10));
            Console.WriteLine(blackWizard.Attack(14));
        }
    }
}
