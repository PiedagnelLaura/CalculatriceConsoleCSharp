using System;

namespace Remise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Prix :");
                double prix = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Pourcentage de remise :");
                int remise = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Prix remisé :" + ReducPrice(prix, remise));
            }
        }

        static double ReducPrice(double price, int reduc)
        {
            return price - price * reduc / 100;
        }
    }
}
