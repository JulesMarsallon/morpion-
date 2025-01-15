// j'ai pris les liberté de ne pas suvire totalement toute les guide donné initialement, notament car il est demandé de rendre le morpion fonctionelle et je cite "Maintenance corrective et/ou évolutive". 
using System;
//i : sert a bouger dans le tableau , il permet de changer le nombre (1,2 ou " ") a chaque passager utilisateur , i représente les ligne 
//j : sert a bouger dans le tableau ,  il permet de changer le nombre (1,2 ou " ") a chaque passager utilisateur , c représente les colone
namespace Morpion
{
    class ProgrameMorpion // classe du jeux
    {
        public static int[,] grille = new int[3, 3]; // grille 3x3 pour jeu, sa s'appelle une matrice
                                                     //grille c'est la variable 
                                                     //public : accesible a tt le programe
                                                     //int[,] : permet de dire que c'est un tableau 2d (matrice) et chaque élément c un int 
                                                     //[,] : la virgule c pour dire que c'est un tableau de tableau, chaque "petit" tableau vaut 0 nativement 
                                                     //new int[3, 3] : met la grille en 3 colone 3 ligne , chaque matrice sera un entier, dans le cas ici 0 nativement, 1 ou 2 ( pour les joueur)
                                                     //affiche grille Morpion 
        public static void AfficherMorpion() //le tableau lui meme
        {
            Console.Clear(); // Efface la console ,permet de réinitialisé la console 
            Console.WriteLine("Joueur 1 = O");  //information joueur 
            Console.WriteLine("Joueur 2 = X");  //information joueur
            Console.WriteLine("            "); //simple espace 
            Console.WriteLine(" -----------"); 
                               
            for (int i = 0; i < 3; i++) //Pour les Ligne
                                        // Boucle, int i = 0 (initialise varibale i a 0),
                                        // i < 3 (c la condition pour que la boucle continue, tant que 1 est plus petit que 3 la boucle continue) 
                                        // i++ ajouter 1 a i
                                        //Pour résumer quand i atteint 3 la boucle se stop 
            {
                for (int j = 0; j < 3; j++) // Pour les colone 
                                            // int j = 0 ( instaure j et le met a 0)
                                            // j < 3 ( tant que j est plus petit que 3 boucle continue 
                                            // j++ ( incrémentation de j de 1)

                // c'est une boucle dans une boucle, la boucle i se déplace dans les ligne du tableau et la boucle j se déplace dans les colone
                //c'est un moyen de se "déplacer" dans le tableau ( la grille du jeux ^)
                //si on rajoute a ce code:  Console.WriteLine($"Case ({i}, {j})"); on aurais toute les sorti comme 0,0 ou 2,1 etc, pour résumer il donnerai tout les sorti possible
                {
                    if (grille[i, j] == 1) // Si la case contient un 1, affiche "O" (joueur 1)
                                           // grille[i, j] (vas a la ligne i et la colonne j )
                                           // == 1  (regarde si ya 1 ds la case)
                                           // if ( si la case correspond a 1 , faire se qu'il ya en dessous)
                                           // si la case est 1 cela veut donc dire que c le joueur O qui a mis sont signe, si c 2 c le joueur X qui a mis
                                           //sont signe , et 0 ya rien 

                    Console.Write(" O "); //c le joueur 1
                    else if (grille[i, j] == 2) // Si la case contient un 2, affiche "X" 
                                                // Si la case contient un 1, affiche "O"
                                                // grille[i, j] (vas a la ligne i et la colonne j )
                                                // == 2  (regarde si ya 2 ds la case)
                                                // if ( si la case correspond a 2 , faire se qu'il ya en dessous
                                                // si la case est 2 cela veut donc dire que c le joueur X qui a mis sont signe, si c 1 c le joueur O qui a mis sont signe , et 0 ya rien 
                    Console.Write(" X "); // c le joueur 2
                    
                    else // Sinon, laisse la case vide
                    Console.Write("   "); //et donc sa marque rien qui mis comme un espace ( qui vaut 0 de base) le rien vaut 0 donc le tableau de base est : 0 0 0 
                                          //                                                                                                                  0 0 0
                                          //                                                                                                                  0 0 0
                    if (j < 3) // barre verticale entre colonne 
                               // j (la colone au dessu)
                               // < 3 (vérif que j est avant la derniére colone qui sont elle de 0 a2, donc il vérif que l'on est soit dans la 0 soit dans la 2
                               // si condition vérifier , passe en dessou
                        Console.Write("|"); //met | , c les barre verticale 
                }
                Console.WriteLine(); //ligne d'aprés

                if (i < 3) // barre horrizontale 
                           // i (la ligne  au dessu)
                           // < 3 (vérif que i est avant la derniére colone qui sont elle de 0 a2, donc il vérif que l'on est soit dans la 0 soit dans la 2
                           // si condition vérifier , passe en dessous

                    Console.WriteLine(" -----------"); // met ----------- 3x , barre horrizontale 
            }
        }
        //jouer un coup (fonction)
        public static bool AJouer(int l, int c, int joueur)
        //gére les coups jouer 
        //la méthode et accesible pr tt 
        //bool car coup valide : vrai/faux
        //ajouter : Nom , utilsié pour engresiter les coup jouer
        //l : ligne choisit par le joueur 
        //c : colone choisit par le joueurs 
        //joueur : c'est le joueur , 1 pour O , 2 pour X
        {
            if (l < 0 || l > 2 || c < 0 || c > 2 || grille[l, c] != 0)
            // ce if permet de vérifier tout les condition en meme temps, cette structure permet de faire un peut plus court et simple tout en ne modifiant pas le fonctionnement de base. 
            // Vérifie si la case est valide et vide                                                     
            // l < 0 : vérif si ligne choisit par le joueur et inférieur a 0 , si oui invalid car hors grille                                                       
            // l > 2 : vérif si ligne choisit par le joueur et supérieur a 2 , si oui invalid car hors grille                                                      
            // c < 0 : vérif si la cologne choisit par le jouures est inférieur a 0 , si oui invalid car hors grille                                                      
            // c > 2 : vérif si la cologne choisit par le joueur est supérieurs a 2 , si oui invalid car hors grille                                                    
            // grille[l, c] != 10 : vérif si la case indiqué ne contient pas 10 ( 10 étant la valeur d'une case vide), si case na pas 10 sa veut dire quelle et prise                                                    
            // grille[l, c] != 0 : vérif si la case indiqué ne contient pas 0 ( 0 étant la valeur d'une case vide), si case na pas 0 sa veut dire quelle et prise                                                    
            // || : c un opérareur bool, c un moyen de dire que si un de ces élément est vrai hop invalid
            //la grille et de 0 a 2 , non pas de 1 a 3 , c'est pourquoi je vérif inférieur a 0 et supérieur a 2 etc 
            {
                return false; // Retourne faux si le coup est invalide
                //en gros cela permet , si mauvais coordonnée de recommencer le coup ( cette fonciton ne gére que les execption hors grille qui sont des entier)
            }
            grille[l, c] = joueur; // Met le numéro du joueur dans la case choisie
            return true; // Erreur probable, devrait retourner "true"
        }
        // Fonction pour vérif si un joueur a gagné
        public static bool Gagner(int joueur) // bool : vrai /faux...
                                              // gagner c la méthode qui est utiliser pr savoir si un joueur a win ou ps 
                                              // joueur sa représente le joueur 1(O) ou 2 (X), permet de savoir lequel des joueur a win 
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
                            //si tt les condition au dessus sont vrai (case ligne i et colone 0.1.2 sont identique alors win ) donc true. 
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
        {
            int joueur = 1; // Déclare le joueur actuel (1 ou 2)
            int essais = 0; // Compte le nombre de coups joués
            bool gagner = false; // Indique si un joueur a gagné
            int l = -1;  // Initialisation de la variable ligne (-1 car tableau )
            int c = -1;  // Initialisation de la variable colonne  (-1 car tableau )

            // Initialisation de la grille (toutes les cases sont vides)
            for (int i = 0; i < 3; i++)
            // Initialise la grille avec une valeur 10 pour indiquer que toutes les cases sont vides
            // Boucle, int i = 0 (initialise varibale i a 0),
            // i < 3 (c la condition pour que la boucle continue, tant que i est plus petit que 3 la boucle continue )  c un compte tour si 3 symbole identique win.
            // i++ ajouter 1 a i
            //Pour résumer quand i atteint 3 la boucle se stop 

            //RAPELLE
            // c une boucle dans une boucle, la boucle i se déplace dans les ligne du tableau et la boucle j se déplace dans les colone
            //c un moyen de se "déplace" dans le tableau ( la grille du jeux ^)
            //si on rajouter a ce code:  Console.WriteLine($"Case ({i}, {j})"); on aurais toute les sorti comme 0,0 ou 2,1 etc
            {
                for (int j = 0; j < 3; j++)
                // Boucle pour parcourir les colonnes
                // int j = 0 ( instaure j et le met a 0)
                // j < 3 ( tant que j est plus petit que 3 boucle continue )  c un compte tour si 3 symbole identique win.
                // j++ ( incrémentation de j de 1)
                {
                    grille[i, j] = 0;//met la valleur de la grille ( les case vide ) a 0, assigne une valeur dans les élément de la matrioce
                                     //grille : la grille 3*3
                                     //[i, j] :ligne et colonnes de matrice
                                     //=10 on met 10 au coordonnée donné 
                                     //=0 on met 0 au coordonnée donné 
                                     //permet a la martrice d'avoir des info deja mise dans la grille , pour pouvoir l'initialisé 
                }
            }
            while (!gagner && essais < 9)//sa continue tant que le nombre d'eesssaie n'est pas finit et que persone a win 
                                         //&& permet de mettre 2 condition dans while , il peut marcher avec un if ou d'autre structure logique 
                                         //while : c la boulce (tant que)
                                         //!gagner varribale (win ou lose), ! c un opérateur qui sert a dire qu'un joueur win , si gagner et true alors il devien fals ( grace a !) ce qui permet a la boucle de stop (et inversement)
                                         //< 9 , la boucle continue tant qu'on est pas a 9 tour
            {
                AfficherMorpion(); // Affiche la grille finale (donc sans win just les o et x) (avec les information en dessous)

                Console.WriteLine($"C'est au tour du joueur {joueur}");  // indique de joueur 
                                                                         //$ : ce carctére permet de dire que {joueur} est une varriable qui peut etre modifier (dans cette situation c pr dire joueur 1 ou 2
                                                                         //{joueur} : met la varriable joueur dans le texte afficher, sa met la varriable joueur donc soit joueur 1 ou joueur 2 ( si win de l'un d'entre eu)
                                                                         //"le joueur .... gagne" : les caractére entre le nom du joueur qui a win ( sa met le 'nom' du joueur qui a win dans le champ)
                                                                         // Demande la ligne et la colonne
                // Demande la ligne
                bool validLigne = false;
                while (!validLigne) //! = inverse de validligne
                {
                    Console.Write("Ligne de 1 à 3 : ");
                    string inputL = Console.ReadLine();
                    if (int.TryParse(inputL, out l) && l >= 1 && l <= 3) //& double condiution 
                                                                         //Console.Write("Colonne de 1 à 3 : "); : affiche msg
                                                                         //string inputC = Console.ReadLine(); : attend que l'utilisateur mette un touche 
                                                                         //if (int.TryParse(inputC, out c) && c >= 1 && c <= 3) // vérificateur
                    {
                        l--; // On ajuste la valeurs pour correspondrer à l'index de la grile (0-2)
                        validLigne = true; //passe la varriable en true (initialement false)
                    }
                    else
                    {
                        Console.WriteLine("Mauvaise saisie, saisir une ligne entre 1 et 3 et qui est un entiers");
                    }
                }
                // Demande la colonne
                bool validColonne = false;
                while (!validColonne) //! = inverse de validcolonne
                {
                    Console.Write("Colonne de 1 à 3 : ");
                    string inputC = Console.ReadLine();
                    if (int.TryParse(inputC, out c) && c >= 1 && c <= 3) //& double condiution 
                    //Console.Write("Colonne de 1 à 3 : "); : affiche msg
                    //string inputC = Console.ReadLine(); : attend que l'utilisateur mette un touche 
                    //if (int.TryParse(inputC, out c) && c >= 1 && c <= 3) // vérificateur 
                    {
                        c--; // On ajuste la valeur pour correspondre à l'index de la grille (0-2)
                        validColonne = true; //passe la varriable en true (initialement false)
                    }
                    else
                    {
                        Console.WriteLine("pas bon saisir une colonne entre 1 et 3 et qui est un entiers");
                    }
                }
                //Si le coup est valide, on le joue
                if (AJouer(l, c, joueur))
                {
                    essais++; // Incrémente le nombre d'essais

                    if (Gagner(joueur)) // Si le joueur a gagné
                    {
                        AfficherMorpion(); // Affiche la grille finale
                        Console.WriteLine($"Le joueur {joueur} gagne !");
                        gagner = true; // Arrête le jeu car un joueur a gagné
                    }
                    else if (essais == 9) // Si on atteint 9 essais sans gagnant
                    {
                        AfficherMorpion(); // Affiche la grille finale
                        Console.WriteLine("Egalité, personne ne gagne.");
                        gagner = true; // Arrête le jeu
                    }
                    
                    //joueur c la varriable qui est le joueur qui joue (la ya 2 joueur , 1(O) et 2(X) )
                    //cela permet de switch 
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
                    Console.WriteLine("Pas bon mouvement, veillez a mettre a caractére valide :");
                }
            }
            //visual studio soit ferme dirretement la console ( si pas Console.ReadKey) donc pas d'affichage de
            //résultat soit crash aprés Console.ReadKey, j'ai donc mis "Appuyez sur une touche deux fois pour fermer le jeux." pour fermer la console
            Console.WriteLine("Fin du jeux.");
            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.WriteLine("Appuyez sur une touche deux fois pour fermer le jeux.");                                                                      
            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.WriteLine("            ");
            Console.ReadKey();
        }
        //fin prog principale 
    }
}

