using System;

namespace Würfelspiel
{
    class Würfelspiel
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Drücke eine Taste, um zu würfeln.");
                Console.ReadLine();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("Du hast eine {0} gewürfelt.", playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);


                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Dein Gegner hat eine {0} gewürfelt.", enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Du hast gewonnen!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Der Gegner hat gewonnen!");
                }
                else
                {
                    Console.WriteLine("Unentschieden!");
                }
                Console.WriteLine("Es steht - Du vs. Gegner: {0} zu {1}", playerPoints, enemyPoints);
                Console.WriteLine();
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("Du hast das Spiel gewonnen!");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("Du hast das Spiel verloren!");
            }
            else
            {
                Console.WriteLine("Keiner hat gewonnen!");
            }
            Console.ReadLine();
        }
    }
}
