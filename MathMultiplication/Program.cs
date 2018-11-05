using System;

namespace MathMultiplication.Program
{
    /// <summary>
    /// On souhaite utiliser la méthode System.Math.Pow(), cependant,
    /// un autre développeur du projet a rajouté une méthode qui rentre en conlit.
    ///
    /// Pour éviter qu'il ne s'énèrve parce que je change son code, je souhaiterais
    /// continuer à utiliser la bonne méthode, sans changer mon code.
    ///
    /// Comment faire ?
    /// </summary>
    class Program
    {
        // Ne rien changer à partir d'ici
        static void Main(string[] args)
        {
            var a = 5;
            var b = 2;

            Console.WriteLine(Math.Pow(a, b));
            Console.ReadKey();
        }
    }
}
