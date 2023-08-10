using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PGCD
{
    internal class Program
    {
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

            Console.WriteLine("Ce programme calcule le PGCD de deux nombres saisis");
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

        static int PGCD(int Nbre_a, int Nbre_b)
        {
            /*
             * fonction de calcul du PGCb
             * entre deux nombres donnés
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
    }
}
