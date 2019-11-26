using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Arrays
    {
        public static void Execute()
        {
            Console.WriteLine("");
            Console.WriteLine("==========================");
            Console.WriteLine("Manipulation des tableaux");
            Console.WriteLine("==========================");
            // delcaration + assignation
            // indirectement la taille du tableau est definie à 4 cases
            int[] numbers = { 1, 2, 3, 4 };

            // possible de le faire en 2 temps
            // un tableau a toujours une taille fixe
            int tailleTableau = 20;
            int[] numbers2 = new int[tailleTableau];
            // interdit d'appeler un index qui n'existe pas, par ex numbers2[21];


            // affiche la taille du tableau
            Console.WriteLine("L'élément 0 du tableau numbers " + numbers.Length);

            // accéder aux éléments du tableau
            // affiche la valeur 1
            Console.WriteLine("L'élément 0 du tableau numbers " + numbers[0]);

            // modifier une entrée du tableau
            numbers[0] = 10;
            Console.WriteLine("L'élément 0 du tableau numbers " + numbers[0]);

            Console.WriteLine("L'élément 0 du tableau numbers2 " + numbers2[0]);


        }
    }
}
