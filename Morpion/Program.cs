
// j'ai pris les liberté de ne pas suvire totalement toute les guide donné initialement, notament car il est demandé de rendre le morpion fonctionelle et je cite "MAINTENANCE CORRECTIVE ET/OU EVOLUTIVE".

using System;


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
            Console.WriteLine("Joueur 1 = O");  //information joueur
            Console.WriteLine("Joueur 2 = X");  //information joueur
            Console.WriteLine("            ");
            Console.WriteLine(" -----------");  //j'ai mis cette ligne ici car pour une raison inconue je ne peut pas mettre 4 ligne dans le if j ci dessous. 
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
                        Console.Write("   "); //et donc sa marque rien qui mis comme un espace ( qui vaut 0 de base) le rien vaut 0 donc le tableau de base est : 0 0 0 
                                              //                                                                                                                                        0 0 0
                                              //                                                                                                                                        0 0 0





                    if (j < 3) // barre verticale entre colonne 
                               // j (la colone du truc au dessu)
                               // < 3 (vérif que j est avant la derniére colone qui sont elle de 0 a2, donc il vérif que l'on est soit dans la 0 soit dans la 2
                               // si condition vérifier , passe en dessou
                        Console.Write("|"); //met | 





                }
                Console.WriteLine(); //ligne d'aprés

                if (i < 3) // barre horrizontale 
                           // i (la ligne du truc au dessu)
                           // < 3 (vérif que i est avant la derniére colone qui sont elle de 0 a2, donc il vérif que l'on est soit dans la 0 soit dans la 2
                           // si condition vérifier , passe en dessou




                    Console.WriteLine(" -----------"); // met -----------
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
            if (l < 0 || l > 2 || c < 0 || c > 2 || grille[l, c] != 0)  // ce if permet de vérifier tout les condition en meme temps


            // Vérifie si la case est valide et vide                                                     
            // l < 0 : vérif si ligne choisit par le joueur et inférieur a 0 , si oui invalid car hors grille                                                       
            // l > 2 : vérif si ligne choisit par le joueur et supérieur a 2 , si oui invalid car hors grille                                                      
            // c < 0 : vérif si la cologne choisit par le jouures est inférieur a 0 , si oui invalid car hors grille                                                      
            // c > 2 : vérif si la cologne choisit par le joueur est supérieurs a 2 , si oui invalid car hors grille                                                    
            // grille[l, c] != 10 : vérif si la case indiqué ne contient pas 10 ( 10 étant la valeur d'une case vide), si case na pas 10 sa veut dire quelle et prise                                                    
            // grille[l, c] != 0 : vérif si la case indiqué ne contient pas 0 ( 0 étant la valeur d'une case vide), si case na pas 0 sa veut dire quelle et prise                                                    
            // || : c un opérareur bool, c un moyen de dire que si un de ces truc est vrai hop invalid

            //* la grille et de 0 a 2 , non pas de 1 a 3 , c'est pourquoi je vérif inférieur a 0 et supérieur a 2 etc 



            {
                return false; // Retourne faux si le coup est invalide
                //en gros cela permet , si mauvais coordonnée de recommencer le coup ( cette fonciton ne gére que les execption hors grille qui sont des entier)
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
                                        // i < 3 (c la condition pour que la boucle continue, tant que 1 est plus petit que 3 la boucle continue) c un compte tour si 3 symbole identique win. 
                                        // i++ ajouter 1 a i
                                        //Pour résumer quand i atteint 3 la boucle se stop 
            {


                if (grille[i, 0] == joueur)
                //grille[i, 0] : regarde la case a la ligne i et colone 0
                //== joueur : compare la case avec la valeur du joueur ( O, X ou rien) donc 1,2,0
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
                            //si tt les condition au dessu sont vrai (case ligne i et colone 0.1.2 sont identique alors win ) donc true. 
                        }
                    }
                }

            }



            //explication fonctionnement au dessus
            for (int j = 0; j < 3; j++) // Vérifie chaque colonne
                                        // Boucle, int i = 0 (initialise varibale i a 0),
                                        // i < 3 (c la condition pour que la boucle continue, tant que 1 est plus petit que 3 la boucle continue )  c un compte tour si 3 symbole identique win.
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
            int l; 
            int c; // cordonnees du coup




            for (int i = 0; i < 3; i++) // Initialise la grille avec une valeur 10 pour indiquer que toutes les cases sont vides
                                        // Boucle, int i = 0 (initialise varibale i a 0),
                                        // i < 3 (c la condition pour que la boucle continue, tant que i est plus petit que 3 la boucle continue )  c un compte tour si 3 symbole identique win.
                                        // i++ ajouter 1 a i
                                        //Pour résumer quand i atteint 3 la boucle se stop 
                for (int j = 0; j < 3; j++)
                    // Boucle pour parcourir les colonnes
                    // int j = 0 ( instaure j et le met a 0)
                    // j < 3 ( tant que j est plus petit que 3 boucle continue )  c un compte tour si 3 symbole identique win.
                    // j++ ( incrémentation de j de 1)



                    //RAPELLE
                    // c une boucle dans une boucle, la boucle i se déplace dans les ligne du tableau et la boucle j se déplace dans les colone
                    //c un moyen de se "déplace" dans le tableau ( la grille du jeux ^)
                    //si on rajouter a ce code:  Console.WriteLine($"Case ({i}, {j})"); on aurais toute les sorti comme 0,0 ou 2,1 etc





                    grille[i, j] = 0; //met la valleur de la grille ( les case vide ) a 0, assigne une valeur dans les élément de la matrioce
                                      //grille : la grille 3*3
                                      //[i, j] :ligne et colonnes de matrice
                                      //=10 on met 10 au coordonnée donné 
                                      //=0 on met 0 au coordonnée donné 
                                      //ce truc permet a la martrice d'avoir des info deja mise dans la grille , pour pouvoir l'initialisé 





            while (!gagner && essais < 9) // sa continue tant que le nombre d'eesssaie n'est pas finit et que persone a win 
                                          //&& permet de mettre 2 condition dans while , il peut marcher avec un if ou d'autre structure logique 
                                          //while : c la boulce (tant que)
                                          //!gagner varribale (win ou lose), ! c un opérateur qui sert a dire qu'un joueur win , si gagner et true alors il devien fals ( grace a !) ce qui permet a la boucle de stop (et inversement)
                                          //< 9 , la boucle continue tant qu'on est pas a 9 tour
                                          //
                                          //
                                          //

            {
                AfficherMorpion(); // Affiche la grille finale (donc sans win just les o et x) ( avec les truc en dessous)

                Console.WriteLine($"C'est au tour du joueur {joueur}");  // indique de joueur 
                                                                         //$ : ce carctére permet de dire que {joueur} est une varriable qui peut etre modifier (dans cette situation c pr dire joueur 1 ou 2
                                                                         //{joueur} : met la varriable joueur dans le texte afficher, sa met la varriable joueur donc soit joueur 1 ou joueur 2 ( si win de l'un d'entre eu)
                                                                         //"le joueur .... gagne" : les caractére entre le nom du joueur qui a win ( sa met le 'nom' du joueur qui a win dans le champ)
                                                                         // Demande la ligne et la colonne






                /*
                Console.Write("Colonne de 1 à 3 : ");
                string input1 = Console.ReadLine(); //Console.. :métohde qui attend utilisateur rentre texte 
                                                    //

                if (int.TryParse(input1, out int temp1)) // int.TryParse : vérif si sa peut etre un entier 
                                                       // si c bon , c stocké dans out int temp
                                                       // donc si on met chiffre = true , si on met des lettre fals
                {
                    if (temp1 >= 1 && temp1 <= 3) //valeur temp est temporaire et permert de stocker une valeur
                    {
                        c = temp1 - 1; //le -1 du tableau et tt ( 0.1.2)
                    }
                    else
                    {
                        Console.WriteLine("La colonne doit être entre 1 et 3.");
                        // pas bon car doit etre en 1 et 3
                    }
                }
                else
                {
                    Console.WriteLine("Entrée invalide. Veuillez saisir un nombre.");
                    // pas bon car pas 1.2.3
                }


                
                
                Console.Write("Ligne de 1 à 3 : ");
                string input2 = Console.ReadLine(); //Console.. :métohde qui attend utilisateur rentre texte 
                                                    //

                if (int.TryParse(input2, out int temp2)) // int.TryParse : vérif si sa peut etre un entier 
                                                             // si c bon , c stocké dans out int temp
                                                             // donc si on met chiffre = true , si on met des lettre fals
                {
                    if (temp2 >= 1 && temp2 <= 3) //valeur temp est temporaire et permert de stocker une valeur
                    {
                        c = temp2 - 1; //le -1 du tableau et tt ( 0.1.2)
                    }
                    else
                    {
                        Console.WriteLine("La colonne doit être entre 1 et 3.");
                        // pas bon car doit etre en 1 et 3
                    }
                }
                else
                {
                    Console.WriteLine("Entrée invalide. Veuillez saisir un nombre.");
                    // pas bon car pas 1.2.3
                }
               */



               Console.Write("Ligne de 1 à 3 : "); // quelle ligne ? 
                l = int.Parse(Console.ReadLine()) - 1; // prend le chiffre mis par l'utilisateur fait -1 car sinon sa décal tt, le tableau c pas 1.2.3 mais 0.1.2,
               // try
               // {
               // l = int.Parse(Console.ReadLine()) - 1; // prend le chiffre mis par l'utilisateur fait -1 car sinon sa décal tt, le tableau c pas 1.2.3 mais 0.1.2,
               // } 
               // catch ((l >= 1 && l <= 3)   )









                Console.Write("Colonne de 1 à 3 : "); // quelle colone ?
                c = int.Parse(Console.ReadLine()) - 1; // prend le chiffre mis par l'utilisateur , fait -1 car sinon sa décal tt, le tableau c pas 1.2.3 mais 0.1.2





                // Si le coup est valide, jouer
                if (AJouer(c, l, joueur))
                {
                    essais++; // compte tour ( si  9 la parti de stop)


                    if (Gagner(joueur)) // Si joueur gagne alors : 
                    {
                        AfficherMorpion(); // Affiche la grille finale 
                        Console.WriteLine($"Le joueur {joueur} gaggne ");
                        gagner = true; // Arrête le jeu car le joueur a gagner (condition gagner vérifier)
                    }
                    else if (essais == 9) // Sinombre essais atteint 9 sans gagnant
                    {
                        AfficherMorpion(); // Affiche la grille finale (donc sans win just les o et x)
                        Console.WriteLine("Egalitè persone ne gagne");
                        gagner = true; // Arrête le jeu
                    }


                    //joueur c la varriable qui est le joueur qui joue (la ya 2 joueur , 1(O) et 2(X) )

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
                    Console.WriteLine("pas bon mouvement"); // Message d'erreur si le coup est invalide


                }



            }




            Console.WriteLine("Fin"); // Message fin
            //Console.ReadKey(); //touche random pr close

            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.WriteLine("Apuyer sur une touche pour fermer");
            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.WriteLine("            ");
        }
        //Console.ReadKey();
        //fin prog principale 



    }
}

