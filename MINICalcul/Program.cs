using System;

namespace MiniCalculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Mini Calculatrice C# ===");

            Console.Write("Entrez le 1er nombre : ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez le 2ème nombre : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choisissez une opération (+, -, *, /) : ");
            string op = Console.ReadLine();

            double resultat = 0;

            switch (op)
            {
                case "+":
                    resultat = a + b;
                    break;
                case "-":
                    resultat = a - b;
                    break;
                case "*":
                    resultat = a * b;
                    break;
                case "/":
                    if (b != 0)
                        resultat = a / b;
                    else
                    {
                        Console.WriteLine("Erreur : division par zéro !");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Opération invalide !");
                    return;
            }

            Console.WriteLine($"Résultat : {a} {op} {b} = {resultat}");
            Console.WriteLine("Appuie sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}