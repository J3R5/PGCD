## PGCD en C#

### Introduction

Ce répertoire va montrer un programme console qui demande deux nombres entiers strictement positifs et calcule leur PGCD et l'affiche. Le programme dit aussi s'ils sont premiers entre eux.

Code : [Projet]()

Application : [Console.exe]()

### PGCD

Le PGCD de deux nombres est le plus grand diviseur commun entre les deux, si le diviseur est 1 cela signifie que les deux nombres sont aussi premiers entre eux. Pour calculer le PGCD, il faut que les deux nombres soient positifs et entiers.

La méthode de calcul ici se fera par soustractions successives, d'abord on détermine le nombre le plus petit que l'on garde en mémoire puis, on soustrait les deux nombres pour garder la valeur absolue. Ensuite, on compare le nombre obtenu avec le plus petit déterminé avant s'ils sont identiques, on a le PGCD, sinon on recommence jusqu'à ce qu'ils le soient.

### Main 

~~~C#

        static void Main(string[] args)
        {
            /*
             * Programme qui demande deux nombres a et b
             * et calcul leur PGCD.
             * 
             * Jérémy Clémente 09/08/2023
             */

            //Variable

            int Nbre_PGCD, Nbre_a, Nbre_b;

            //Initialisation

            Nbre_PGCD = 0;
            Nbre_a = 0;
            Nbre_b = 0;

            //Début

            Console.WriteLine("Ce programme calcul le PGCD de deux nombres saisis");
            Console.WriteLine("Les nombres doivent être strictment positifs");
            Console.WriteLine();

            //Demande utilisateur

            Nbre_a = Demande_uint("Veuillez saisir le premier nombre");

            Nbre_b = Demande_uint("Veuillez saisir le deuxième nombre");

            //Calcul PGCD

            Nbre_PGCD = PGCD(Nbre_a, Nbre_b);

            Console.WriteLine("La valeur du PGCD est de " + Nbre_PGCD);

            if(Nbre_PGCD == 1)
            {
                Console.WriteLine("Les nombres sont premiers entre eux");
            }

            Console.ReadKey();

            //Fin
        }


~~~

Le programme crée trois variables Nbre_a et Nbre_b. Ils sont les deux nombres que l'utilisateur va devoir choisir. Quant à la variable Nbre_PGCD, c'est le résultat du PGCD de Nbre_a et Nbre_b. On demande d'abord la valeur de Nbre_a avec la fonction Demande_uint(), ensuite on recommence en demandant la valeur du deuxième nombre (Nbre_b) avec la même fonction Demande_uint().

Ensuite, on calcule le PGCD de Nbre_a et Nbre_b et on affiche le résultat dans la console. Finalement, si les nombres sont premiers entre eux, on l'affiche.

#### Demande_uint()

La fonction Demande_uint() permet de demander à l'utilisateur de saisir un nombre entier strictement positif (suppérieur à 0).

~~~C#

        static int Demande_uint(string Msg = "Veuillez saisir un nombre entier strictement positif")
        {
            /*
             * fontion demande utilisateur
             * d'un nombre suppérieur à 0
             * 
             * Jérémy Clémente 09/08/2023
             */

            //variable

            string Saisie;
            int Nbre;

            //initialisation

            Saisie = "";
            Nbre = 0;

            //Début

            Console.WriteLine();

            do
            {
                Console.WriteLine(Msg);
                Saisie = Console.ReadLine();
                int.TryParse(Saisie, out Nbre);
                if (int.TryParse(Saisie, out Nbre) == false || Nbre <= 0)
                {
                    Console.WriteLine("Veuillez saisir un nombre strictement positif (supérieur à 0)");
                }
            }
            while (!int.TryParse(Saisie, out Nbre) || Nbre <= 0);

            return Nbre;

            //Fin
        } 

~~~

Cette fonction possède un paramètre optionnel Msg qui est le message affiché à l'utilisateur qu'il est possible de changer par défaut le message est : Veuillez saisir un nombre entier strictement positif.

Le programme possède deux variables internes : Saisie et Nbre. Saisie est une chaîne de caractère et Nbre est un entier.

La fonction affiche la variable Msg. Puis, elle demande la saisie de l'utilisateur, le résultat va dans la variable Saisie. On essaye ensuite de convertir cette variable en nombre, si cela marche le résultat ira dans la variable Nbre, sinon la variable Nbre ne changera pas. Ensuite, on regarde si la conversion a fonctionné et si le nombre est strictement positif, dans le cas où l'un des deux est faux, on affiche un message d'erreur de saisie et on recommence la boucle tant que le résultat n'est pas correct.

Une fois le résultat correct la fonction retourne la variable Nbre.

### Fonction PGCD()

La fonction PGCD() prend en paramètre deux entiers et retourne leur PGCD.

~~~C#

        static int PGCD(int Nbre_a, int Nbre_b)
        {
            /*
             * fonction de calcul du PGCb
             * entre deux nombres donné
             * à la fonction
             * 
             * Jérémy Clémente 09/08/2023
             */

            //variable

            int Nbre_c;

            //initialisation 

            Nbre_c = 0;

            //Début

            while (Nbre_a != Nbre_b)
            {
                Nbre_c = Math.Min(Nbre_a, Nbre_b);
                Nbre_b = Math.Abs(Nbre_a - Nbre_b);
                Nbre_a = Nbre_c;
            }

            return Nbre_a;

            //Fin
        }

~~~

En plus des deux variables que prend la fonction, il y a aussi une variable interne Nbre_c. 

La fonction se caractérise par une boucle où l'on utilise la méthode de calcul vue au début. C'est à dire, on garde en mémoire via la variable Nbre_c le plus petit nombre entre Nbre_a et Nbre_b. Puis, on prend la valeur absolue de la soustraction de Nbre_a et Nbre_b et, cette valeur ira dans Nbre_b. Ensuite, on redonne la valeur Nbre_c dans Nbre_a pour finalement les comparer.

Si les nombres sont identiques, on retourne la valeur sinon on recommence la boucle.

### Conclusion 

Voilà la fin de ce markdown sur le programme de PGCD, il existe aussi d'autres méthodes de calcul comme par la division euclidienne ou bien d'autres.



