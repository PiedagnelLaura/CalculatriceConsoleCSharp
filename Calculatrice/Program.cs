using System;

namespace Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans ma calculatrice en C#");

            bool continueExecution = true;
            while (continueExecution)
            {
                DoCalculComplet();

                continueExecution = AskYesNo("Voulez-vous faire un autre calcul (O/N) ?");
            }
        }

        static void DoCalculComplet()
        {
            Console.WriteLine("Début du calcul");
            Console.WriteLine("Premier nombre :");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Opération (+ - / *)");
            string operation = Console.ReadLine();

            Console.WriteLine("Second nombre :");
            string secondNumber = Console.ReadLine();

            try
            {
                int myFirstNumber = Convert.ToInt32(firstNumber);
                int mySecondNumber = Convert.ToInt32(secondNumber);

                var resultat = Calcul(myFirstNumber, mySecondNumber, operation);

                if (resultat != null)
                {
                    Console.WriteLine("Résultat : " + resultat);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Le nombre n'est pas bon");
            }
        }

        /// <summary>
        /// Retourne le résultat du calcul en fonctions des nombres et de l'opérateur.
        /// Si l'opérateur n'est pas bon, on retourne null
        /// Si aucun opérateur n'est donnée, cela fera une addition
        /// </summary>
        /// <param name="nb1">Premier nombre du calcul</param>
        /// <param name="nb2">Deuxième nombre du calcul</param>
        /// <param name="operateur">Opérateur de calcul (+,-,*,x,X,/)</param>
        /// <returns>Si opérateur ok -> resultat calcul sinon null</returns>
        static double? Calcul(int nb1, int nb2, string operateur = "+")
        {
            double? resultat = null;
            Console.WriteLine(operateur);

            switch (operateur)
            {
                case "+":
                    resultat = nb1 + nb2;
                    break;

                case "-":
                    resultat = nb1 - nb2;
                    break;

                case "*":
                case "x":
                case "X":
                    resultat = nb1 * nb2;
                    break;

                case "/":
                    resultat = nb1 / nb2;
                    break;

                default:
                    Console.WriteLine("L'opérateur n'est pas bon");
                    resultat = null;
                    break;
            }

            return resultat;
        }

        /// <summary>
        /// Pose une question à l'utilisateur dans la commande
        /// </summary>
        /// <param name="question">question qui sera affiché dans la console</param>
        /// <returns>Retourne un booléen en fonction de la réponse de l'utilisateur</returns>
        static bool AskYesNo(string question = "Voulez-vous continuer ?")
        {
            Console.WriteLine(question);
            string responseUser = Console.ReadLine();

            if (responseUser == "N" || responseUser == "n")
            {
                return false;
            }
            return true;
        }
    }
}
