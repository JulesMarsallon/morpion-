﻿using System;


//i : sert a bouger dans le tableau , il permet de changer le nombre (1,2 ou " ") a chaque passager utilisateur 
//i c donc les ligne 

//j : sert a bouger dans le tableau ,  il permet de changer le nombre (1,2 ou " ") a chaque passager utilisateur 
//j c les colone
namespace Morpion // nom du truc
{
    class ProgrameMorpi // classe du jeux
    {
        public static int[,] grille = new int[3, 3]; // grille 3x3 pour jeu, sa s'appelle une matrice
                                                     //grille c la variable 
                                                     //public : accesible a tt le program
                                                     //int[,] : permet de dire que c un tableau 2d (matrice) et chaque élément c un int 
                                                     //[,] : la virgule c pr dire que c un tableau de tableau 

        //new int[3, 3] : met la grille en 3 colone 3 ligne , chaque matrice sera un entier 





        // affiche grille Morpion (c une fonction)
        public static void AfficherMorpion()
        {
            Console.Clear(); // Efface la console , en gros sa permet d'avoir un truc "neuf"
            for (int i = 0; i < 3; i++) // Boucle, int i = 0 (initialise varibale i a 0),
                                        // i < 3 (c la condition pour que la boucle continue, tant que 1 est plus petit que 3 la boucle continue 
                                        // i++ ajouter 1 a i
                                        //Pour résumer quand i atteint 3 la boucle se stop 



            {
                for (int j = 0; j < 3; j++) // Boucle pour parcourir les colonnes
                                            // int j = 0 ( instaure j et le met a 0)
                                            // j < 3 ( tant que j est plus petit que 3 boucle continue 
                                            // j++ ( incrémentation de j de 1)

                // c une boucle dans une boucle, la boucle i se déplace dans les ligne du tableau et la boucle j se déplace dans les colone
                //c un moyen de se "déplace" dans le tableau ( la grille du jeux ^)
                //si on rajouter a ce code:  Console.WriteLine($"Case ({i}, {j})"); on aurais toute les sorti comme 0,0 ou 2,1 etc



                {
                    if (grille[i, j] == 1) // Si la case contient un 1, affiche "O"
                                           // grille[i, j] (vas a la ligne i et la colonne j )
                                           // == 1  (regarde si ya 1 ds la case)
                                           // if ( si la case correspond a 1 , faire se qu'il ya en dessous
                                           // si la case est 1 cela veut donc dire que c le joueur O qui a mis sont signe, si c 2 c le joueur X qui a mis
                                           //sont signe , et 0 ya rien 
                        Console.Write(" O "); //c le joueur 1





                    else if (grille[i, j] == 2) // Si la case contient un 2, affiche "X"
                                                // Si la case contient un 1, affiche "O"
                                                // grille[i, j] (vas a la ligne i et la colonne j )
                                                // == 2  (regarde si ya 2 ds la case)
                                                // if ( si la case correspond a 2 , faire se qu'il ya en dessous
                                                // si la case est 2 cela veut donc dire que c le joueur X qui a mis sont signe, si c 1 c le joueur O qui a mis
                                                //sont signe , et 0 ya rien 
                        Console.Write(" X "); // c le joueur 2




                    else // Sinon, laisse la case vide
                        Console.Write("   "); //et donc sa marque rien qui mis comme un espace 




                    if (j < 2) // barre verticale entre colonne 
                               // j (la colone du truc au dessu)
                               // < 2 (vérif que j est avant la derniére colone qui sont elle de 0 a2, donc il vérif que l'on est soit dans la 0 soit dans la 2
                               // si condition vérifier , passe en dessou
                        Console.Write("|"); //met | ( deux fois)




                }
                Console.WriteLine(); //ligne d'aprés
                if (i < 2) // barre horrizontale 
                           // i (la ligne du truc au dessu)
                           // < 2 (vérif que i est avant la derniére colone qui sont elle de 0 a2, donc il vérif que l'on est soit dans la 0 soit dans la 2
                           // si condition vérifier , passe en dessou



                    Console.WriteLine("---+---+---"); // met ---+---+--- ( deux fois)
            }
        }


        //DEMANDER POUR LE STATIC  

        //jouer un coup (fonction)
        public static bool AJouer(int l, int c, int joueur)
        //gére les coups jouer 
        //la méthode et accesible pr tt le truc
        //bool car coup valide : vrai/faux
        //ajouter : Nom , utilsié pour engresiter les coup jouer
        //l : ligne choisit par le joueur 
        //c : cologne choisit par le joueurs 
        //joueur : c le joueur , 1 pour O , 2 pour X





        {
            if (l < 0 || l > 2 || c < 0 || c > 2 || grille[l, c] != 10) // Vérifie si la case est valide et vide
            // l < 0 : vérif si ligne choisit par le joueur et inférieur a 0 , si oui invalid car hors grille 
            // l > 2 : vérif si ligne choisit par le joueur et supérieur a 2 , si oui invalid car hors grille 
            // c < 0 : vérif si la cologne choisit par le jouures est inférieur a 0 , si oui invalid car hors grille 
            // c > 2 : vérif si la cologne choisit par le joueur est supérieurs a 2 , si oui invalid car hors grille 
            // grille[l, c] != 10 : vérif si la case indiqué ne contient pas 10 ( 10 étant la valeur d'une case vide), si case na pas 10 sa veut dire quelle et prise
            // || : c un opérareur bool, c un moyen de dire que si un de ces truc est vrai hop invalid




            {
                return false; // Retourne faux si le coup est invalide
            }

            grille[l, c] = joueur; // Met le numéro du joueur dans la case choisie
            return true; // Erreur probable, devrait retourner "true"
        }




        //i : sert a bouger dans le tableau , il permet de changer le nombre (1,2 ou " ") a chaque passager utilisateur 
        //i c donc les ligne 

        //j : sert a bouger dans le tableau ,  il permet de changer le nombre (1,2 ou " ") a chaque passager utilisateur 
        //j c les colone







        // Fonction pour vérif si un joueur a gagné
        public static bool Gagner(int joueur) // bool : vrai /faux...
                                              // gagner c la méthode qui est utiliser pr savoir si un joueur a win ou ps 
                                              // joueur sa représente le joueur 1(O) ou 2 (X), permet de savoir lequel des joueur a win 
                                              // 

        {


            for (int i = 0; i < 3; i++) // Vérifie chaque ligne
                                        // Boucle, int i = 0 (initialise varibale i a 0),
                                        // i < 3 (c la condition pour que la boucle continue, tant que 1 est plus petit que 3 la boucle continue 
                                        // i++ ajouter 1 a i
                                        //Pour résumer quand i atteint 3 la boucle se stop 
            {


                if (grille[i, 0] == joueur)
                //grille[i, 0] : regarde la case a la ligne i et colone 0
                //== joueur : compare la case avec la valeur du joueur ( O, X ou rien)
                //vérif si c vrai , vérifier le 2éme , puis si c vrai vérifier le 3éme 

                {

                    if (grille[i, 1] == joueur)
                    //grille[i, 1] : regarde la case a la ligne i et colone 1
                    //== joueur : compare la case avec la valeur du joueur ( O, X ou rien)
                    //vérif si c vrai si c vrai vérifier le 3éme 


                    {
                        if (grille[i, 2] == joueur)
                        //grille[i, 2] : regarde la case a la ligne i et colone 2
                        //== joueur : compare la case avec la valeur du joueur ( O, X ou rien)
                        //vérif si c vrai , 


                        {
                            return true;
                            //si tt les condition au dessu sont vrai (case ligne i et colone 0.1.2 sont identique alors win ) donc true
                        }
                    }
                }

            }



            //explication fonctionnement au dessus
            for (int j = 0; j < 3; j++) // Vérifie chaque colonne
                                        // Boucle, int i = 0 (initialise varibale i a 0),
                                        // i < 3 (c la condition pour que la boucle continue, tant que 1 est plus petit que 3 la boucle continue 
                                        // i++ ajouter 1 a i
                                        //Pour résumer quand i atteint 3 la boucle se stop 
            {
                if (grille[0, j] == joueur)
                {
                    if (grille[1, j] == joueur)
                    {
                        if (grille[2, j] == joueur)


                        {
                            return true;


                        }
                    }

                }

            }



            // Vérifie la première diagonale
            //explication fonctionnement au dessus
            if (grille[0, 0] == joueur)
            {
                if (grille[1, 1] == joueur)
                {
                    if (grille[2, 2] == joueur)
                    {

                        return true;


                    }

                }
            }





            // Vérifie la seconde diagonale
            //explication fonctionnement au dessus

            if (grille[0, 2] == joueur)
            {
                if (grille[1, 1] == joueur)
                {

                    if (grille[2, 0] == joueur)
                    {


                        return true;



                    }
                }
            }

            return false; // Retourne faux si aucun joueur n'a gagné
        }










        // Point d'entrée du programme principal
        static void Main(string[] args)
        //métode main ( par défault elle a ce nom, le code commence tjrs d'ici
        //string[] args : DEMANDER POUR CONPRENDRE, visual ma mis sa en correct
        //
        //

        {
            int joueur = 1; // declare le joueur actuel (1 ou 2)
            int essais = 0; // compte nombre coups jouer
            bool gagner = false; // indique si joueur gagner
            int l, c; // cordonnees du coup





            for (int i = 0; i < 3; i++) // Initialise la grille avec une valeur 10 pour indiquer que toutes les cases sont vides
                                        // Boucle, int i = 0 (initialise varibale i a 0),
                                        // i < 3 (c la condition pour que la boucle continue, tant que i est plus petit que 3 la boucle continue 
                                        // i++ ajouter 1 a i
                                        //Pour résumer quand i atteint 3 la boucle se stop 
                for (int j = 0; j < 3; j++)
                    // Boucle pour parcourir les colonnes
                    // int j = 0 ( instaure j et le met a 0)
                    // j < 3 ( tant que j est plus petit que 3 boucle continue 
                    // j++ ( incrémentation de j de 1)



                    //RAPELLE
                    // c une boucle dans une boucle, la boucle i se déplace dans les ligne du tableau et la boucle j se déplace dans les colone
                    //c un moyen de se "déplace" dans le tableau ( la grille du jeux ^)
                    //si on rajouter a ce code:  Console.WriteLine($"Case ({i}, {j})"); on aurais toute les sorti comme 0,0 ou 2,1 etc




                    grille[i, j] = 10; //met la valleur de la grille ( les case vide ) a 10, assigne une valeur dans les élément de la matrioce
                                       //grille : la grille 3*3
                                       //[i, j] :ligne et colonnes de matrice
                                       //=10 on met 10 au coordonnée donné 
                                       //ce truc permet a la martrice d'avoir des info deja mise dans la grille , pour pouvoir l'initialisé 





            while (!gagner && essais < 9) // Continue tant qu'aucun joueur n'a gagné et qu'il reste des coups à jouer
            {
                AfficherMorpion(); // Affiche la grille

                Console.WriteLine($"C'est au tour du joueur {joueur}."); // Indique le joueur actuel
                Console.Write("Ligne de 1 a 3 : "); // Demande la ligne
                l = int.Parse(Console.ReadLine()) - 1; // Convertit l'entrée utilisateur et ajuste l'index (commence à 0)

                Console.Write("Colonne de 1 a 3 : "); // Demande la colonne
                c = int.Parse(Console.ReadLine()) - 1; // Convertit l'entrée utilisateur et ajuste l'index (commence à 0)



                //l : ligne 
                //c : colone 



                if (AJouer(l, c, joueur)) // si l'entré utilisateur est bonne , il ajoute et fait ce qu'il y a en dessous
                {



                    essais++; // augmente le compteur de coups ( rajoute a la varriable essais)
                    if (Gagner(joueur)) // regarde si joueur a win ( avec la variable Gagner) ( joueur : 1 ou 2) et fait ce qu'il y a en dessous
                    {
                        AfficherMorpion(); //affiche   grille fina
                        Console.WriteLine($"Le joueur {joueur} gange"); // Affiche le message de win
                        //$ : ce carctére permet de dire que {joueur} est une varriable qui peut etre modifier (dans cette situation c pr dire joueur 1 ou 2
                        //{joueur} : met la varriable joueur dans le texte afficher, sa met la varriable joueur donc soit joueur 1 ou joueur 2 ( si win de l'un d'entre eu)
                        //"le joueur .... gagne" : les caractére entre le nom du joueur qui a win ( sa met le 'nom' du joueur qui a win dans le champ)
                        //

                        gagner = true; // met fin a la fin du if 
                    }






                    //fait pour gestion égalité 
                    else if (essais == 9) // si toute les case son remplie sans win
                    {
                        AfficherMorpion(); // Affiche la grille finale (donc sans win just les o et x)
                        Console.WriteLine("égalité"); // et ducoup sa  affiche ce msg qui dit que persone de gagne 
                    }





                    //*joueur c la varriable qui est le joueur qui joue (la ya 2 joueur , 1(O) et 2(X) )

                    if (joueur == 1)  //c pr vérif si la on est joueur 1 passe au 2 et vis versa
                    {
                        joueur = 2; //si joueur actuel est 1, on change a 2
                    }
                    else
                    {
                        joueur = 1; // sinon (la il est 2), on  change a 1
                    }



                }
                else
                {
                    Console.WriteLine("NON pas bon mouv"); // Message d'erreur si le coup est invalide
                    //c le sinon du coup invalide
                }
            }

            Console.WriteLine("Fin"); // Message de fin
            Console.ReadKey(); // Attend une touche pour fermer la console
        }//fin prog principale 
    }
}
