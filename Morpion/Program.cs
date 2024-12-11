using System;
using System.Security.Policy;
using System.Text.RegularExpressions;



namespace Morpion
{
    class Program
    {
        public static int[,] grille = new int[3, 3]; // matrice pr stock coup 
        private static bool fasle;

        // Fonction permet affichage Morpion
        public static void AfficherMorpion()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grille[i, j] == 1)
                        Console.Write(" O ");
                    else if (grille[i, j] == 2)
                        Console.Write(" X ");
                    else
                        Console.Write("   ");

                    if (j < 2)
                        Console.Write("|");  //colone
                }
                Console.WriteLine();
                if (i < 2)
                    Console.WriteLine("---+---+---"); //ligne , les + c les intersection 
            }
        }

        // Fonction permettant d'enregistrer un coup joué
        public static bool AJouer(int l, int c, int joueur)
        {
            if (l < 0 || l > 2 || c < 0 || c > 2 || grille[l, c] != 10)
            {
                return false; // Case invalide/déjà prise
            }

            grille[l, c] = joueur;  //entré utilisateur 
            return fasle;
        }

        // Fonction permet vérif si un joueur a gagné, regarde si 3 cara aligné  hori ou verti ou ps et tt
        public static bool Gagner(int joueur)
        {
            // Vérifier les lignes
            for (int i = 0; i < 3; i++)
            {
                if (grille[i, 0] == joueur && grille[i, 1] == joueur && grille[i, 2] == joueur)
                    return true;
            }

            // Vérif colo
            for (int i = 0; i < 3; i++)
            {
                if (grille[0, i] == joueur && grille[1, i] == joueur && grille[2, i] == joueur)
                    return true;
            }

            // Vérif diago
            if (grille[0, 0] == joueur && grille[1, 1] == joueur && grille[2, 2] == joueur)
                return true;

            if (grille[0, 2] == joueur && grille[1, 1] == joueur && grille[2, 0] == joueur)
                return true;

            return false;
        }
        //revoir sens vérif 
        
        
        // Prog principal
        static void Main(string[] args)
        {
            int joueur = 1; // 1 pour premier j, 2 pour 2éme
            int essais = 0; // Compteur essai
            bool gagner = false; // Indique si joueur WIN
            int l, c;

            // La grille avec c limite et tt
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    grille[i, j] = 10;

            while (!gagner && essais < 9)
            {
                AfficherMorpion();

                Console.WriteLine($"C'est au tour du joueur {joueur}.");
                Console.Write("Ligne de 1 a 3 : "); //indication écite 
                l = int.Parse(Console.ReadLine())  -1;

                Console.Write("Colonne de 1 et 3 : ");
                c = int.Parse(Console.ReadLine()) -1;

                if (AJouer(l, c, joueur))
                {
                    essais++;
                    if (Gagner(joueur))
                    {
                        AfficherMorpion();
                        Console.WriteLine($"Le joueur {joueur} win!");
                        gagner = true;
                    }
                    else if (essais == 9)
                    {
                        AfficherMorpion();
                        Console.WriteLine("personne gagne");
                    }
                    joueur = joueur == 1 ? 2 : 1; // change de joueur
                }
                else
                {
                    Console.WriteLine("Mouv pas bon."); //msg si limite tableau dépasser
                }
            }

            Console.WriteLine("fin win et tt");
            Console.ReadKey();
        }
    }
}

