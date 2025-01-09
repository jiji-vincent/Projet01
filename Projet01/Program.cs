using System;
using System.Threading;

namespace Projet01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choix = 0;
            float RENDU = 0.0f;
            float monnaie = 0.0f;

            //AFFICHAGE DU MENU.

            Console.WriteLine(" __________________________________");
            Console.WriteLine("|          MACHINE À CAFÉ          |");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("|           --> MENU <--           |");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("| [1]    : EXPRESSO (2$)           |");
            Console.WriteLine("| [2]    : DOUBLE EXPRESSO (4$)    |");
            Console.WriteLine("| [3]    : RISTRETTO (2$)          |");
            Console.WriteLine("| [4]    : LONG (5$)               |");
            Console.WriteLine("| [5]    : CAFÉ MACCHIATO (5$)     |");
            Console.WriteLine("| [6]    : CAFÉ CRÈME (6$)         |");
            Console.WriteLine("| [7]    : CAFÉ NOISETTE (6$)      |");
            Console.WriteLine("| [8]    : CAPPUCCINO (5$)         |");
            Console.WriteLine("| [9]    : CAPPUCCINO ALLÉGÉ (5$)  |");
            Console.WriteLine("| [10]   : CAFÉ AMERICAIN (5$)     |");
            Console.WriteLine("| [11]   : CAFÉ GLACÉ (4$)         |");
            Console.WriteLine("| [12]   : CAFÉ BREVE (5$)         |");
            Console.WriteLine("| [13]   : MOCHA BREVE (7$)        |");
            Console.WriteLine("| [14]   : MOCHA (6$)              |");
            Console.WriteLine("| [15]   : OEIL AU BEURRE NOIR (5$)|");
            Console.WriteLine("| [16]   : CAFÉ LATTE (5$)         |");
            Console.WriteLine("| [17]   : CAFÉ CON LECHE (7$)     |");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("| Entrez votre choix               |");
            Console.WriteLine("|__________________________________|");
            Console.Write(" ---> ");

            // ENTRÉES : LE CHOIX DE L'UTILISATEUR.

            if (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 17)
            {
                Console.WriteLine("Veuillez entrer une option valide SVP.");
                return;
            }

            //DEFINITION DES PRIX DES CAFES.

            float[] prixCafes = { 2.0f, 4.0f, 2.0f, 5.0f, 5.0f, 6.0f, 6.0f, 5.0f, 5.0f, 5.0f, 4.0f, 5.0f, 7.0f, 6.0f, 5.0f, 5.0f, 7.0f };
            float prixCafe = prixCafes[choix - 1];

            //ENTRÉES : LA MONNAIE.

            Console.WriteLine("Entrez la monnaie ");
            Console.Write(" ---> ");

            if (!float.TryParse(Console.ReadLine(), out monnaie) || monnaie <= 0)
            {
                Console.WriteLine("Monnaie insuffisante.");
                return;
            }

            // VÉRIFICATION DU PAIEMENT.

            if (monnaie < prixCafe)
            {
                Console.WriteLine($"Monnaie insuffisante. Le prix est de {prixCafe} $.");
                return;
            }

            // CALCUL DU CHANGE. 
            RENDU = monnaie - prixCafe;

            //PRÉPARATION CAFÉ EN 10 S.
            Console.Clear();
            Console.Write("Préparation du café en cours");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(10000);


            //AFFICHER LA MONNAIE RENDUE ET SERVIR CAFÉ.
            Console.WriteLine();
            Console.WriteLine($"ARGENT RENDU : {RENDU:0.00} $");
            Console.WriteLine(" __________________");
            Console.WriteLine("|Prenez votre Café |");
            Console.WriteLine(" ******************");

            Console.WriteLine(" ( ( (");
            Console.WriteLine("  ) ) )");
            Console.WriteLine("|        |");
            switch (choix)
            {
                case 1:
                    Console.WriteLine("|EXPRESSO|");
                    break;
                case 2:
                    Console.WriteLine("|DOUBLE  |");
                    Console.WriteLine("|EXPRESSO|");
                    break;
                case 3:
                    Console.WriteLine("|RISTRETTO|");
                    break;
                case 4:
                    Console.WriteLine("|  LONG  |");
                    break;
                case 5:
                    Console.WriteLine("|  MACCHIATO |");
                    break;
                case 6:
                    Console.WriteLine("| CAFÉ CRÈME |");
                    break;
                case 7:
                    Console.WriteLine("| NOISETTE |");
                    break;
                case 8:
                    Console.WriteLine("|CAPPUCCINO|");
                    break;
                case 9:
                    Console.WriteLine("|CAPPUCCINO|");
                    Console.WriteLine("|ALLÉGÉ    |");
                    break;
                case 10:
                    Console.WriteLine("|CAFÉ     |");
                    Console.WriteLine("|AMÉRICAIN|");
                    break;
                case 11:
                    Console.WriteLine("|CAFÉ |");
                    Console.WriteLine("|GLACÉ|");
                    break;
                case 12:
                    Console.WriteLine("|CAFÉ |");
                    Console.WriteLine("|BREVE|");
                    break;
                case 13:
                    Console.WriteLine("|MOCHA|");
                    Console.WriteLine("|BREVE|");
                    break;
                case 14:
                    Console.WriteLine("|  MOCHA  |");
                    break;
                case 15:
                    Console.WriteLine("|OEIL AU BEURRE NOIR|");
                    break;
                case 16:
                    Console.WriteLine("|CAFÉ |");
                    Console.WriteLine("|LATTE|");
                    break;
                case 17:
                    Console.WriteLine("|CAFÉ |");
                    Console.WriteLine("| CON |");
                    Console.WriteLine("|LECHE|");
                    break;
            }
            Console.WriteLine("|________|");

            //FIN ACHAT.

            Console.WriteLine();
            Console.WriteLine("À LA PROCHAINE !");

            //LISTE DES PRIX DES CAFÉS À RESPECTER.
            /*
             EXPRESSO : 2 $
             DOUBLE EXPRESSO : 4 $
             RISTRETTO : 2 $
             LONG : 5 $
             CAFÉ MACCHIATO : 5 $
             CAFÉ CRÈME : 6 $
             CAFÉ NOISETTE : 6 $
             CAPPUCCINO : 5 $
             CAPPUCCINO ALLÉGÉ : 5 $
             CAFÉ AMERICAIN : 5 $
             CAFÉ GLACÉ : 4 $
             CAFÉ BREVE : 5 $
             MOCHA BREVE : 7 $
             MOCHA : 6 $
             OEIL AU BEURRE NOIR : 5 $
             CAFÉ LATTE : 5 $
             CAFÉ CON LECHE : 7 $
             */
        }
    }
}
