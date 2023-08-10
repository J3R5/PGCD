## PGCD en C#

### Introduction

Ce répertoir va montrer un programme console qui demande le deux nombres entier strictement positif et calcul leur PGCD et l'affiche. Le programme dit aussi si ils sont premier entre deux.

### PGCD

Le PGCD de deux nombre est le plus grand diviseur commun entre les deux si le diviseur est 1 cela signifie que les deux nombres son aussi premier entre eux. Pour calculer le PGCD il faut que les deux nombres sois positif et entier.

la méthode de calcul ici se fera par soustraction successive d'abord on détermine le nombre le plus petit que l'on garde en mémoire puis, on soustrait les deux nombres pour garder la valeur absolue. Ensuite, on compare le nombre obtenir avec le plus petit déterminer avant si il sont identique on as le PGCD sinon on recommence jusqu'à ce qu'il le sois.

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

            Console.WriteLine("Ce programme calcul le PGCD de deux nombre saisie");
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

Le programme créer trois variables Nbre_a et Nbre_b sont les deux nombres que l'utilisateur va devoir choisir. Quant a la variable Nbre_PGCD c'est le résultat du PGCD de Nbre_a et Nbre_b. On demande d'abord la valeur de Nbre_a avec la fonction Demande_uint(), ensuite on recommence en demandant la valeur du deuxième nombre (Nbre_b) avec la même fonction Demande_uint().

Ensuite, on calcul le PGCD de Nbre_a et Nbre_b et on affiche le résultat dans la console. Finalement, on si les nombres sont premier entre eux on les affiches.

#### Demande_uint()

La fonction Demande_uint() permet demande à l'utilisateur de saisir un nombre entier strictement positif (suppérieur à 0).

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

Cette fonction possède un paramètre optionnel Msg qui est le message afficher a l'utilisateur qu'il est possible de changer par défaut le message est : Veuillez saisir un nombre entier strictement positif.

Le programme possède deux variables interne Saisie et Nbre. Saisie est une chaine de caractère et Nbre est un entier.

La fonction affiche la variable Msg. Puis elle demande la saisie de l'utilisateur le résultat va dans la variable Saisie. On essaye ensuite de convertir cette variable en nombre si cela marche le résultat ira dans la variable Nbre sinon la variable Nbre ne changera pas. Ensuite on regarde si la conversion a fonctionné et si le nombre est strictement positif, dans le cas ou l'un des deux est faux on affiche un message d'erreur de saisie et on recommence la boucle tant que le résultat n'es pas correcte.

Une fois le résultat correcte la fonction retourne la variable Nbre.

### Fonction PGCD()

La fonction PGCD() prend en paramètre deux entier et retourne leur PGCD.

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

En plus des deux variables à qui prend la fonction il y a aussi une variable interne Nbre_c. 

La fonction se caractérise par un boucle où l'on utilise la méthode de calcul vu au début. C'est a dire on garde en mémoire via la variable Nbre_c le plus petit nombre entre Nbre_a et Nbre_b. Puis, on prend la valeur absolue de la soustraction de Nbre_a et Nbre_b et, cette valeur ira dans Nbre_b. Ensuite, on redonne la valeur Nbre_c dans Nbre_a pour finalement les comparés.

Si les nombres sont identiques on retourne la valeur sinon on recommence la boucle.

### Conclusion 

Voila la fin de se markdown sur le programme de PGCD, il existe aussi d'autre method de calcul comme par la division euclidienne ou encore bien d'autre.



