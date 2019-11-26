using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Loops
    {
        public static void Execute()
        {
            Console.WriteLine("");
            Console.WriteLine("==========================");
            Console.WriteLine("Manipulation des boucles");
            Console.WriteLine("==========================");
            // delcaration + assignation
            // List<T> => typage dynamique, T représente une classe ou un type qui sera utilisé pour notre liste
            // List<string>, List<Product>
            // une liste est dynamique (taille)
            // un objet List qui est instancié (avec un type)
            List<int> numbers = new List<int>();

            // manipuler la liste
            numbers.Add(10);
            numbers.Add(12);


            // bloucle manuelle for
            // cette boucle n'affiche pas les nombres impairs
            for (int i = 0; i < 16; i++)
            {
                // % = modulo 
                // si i est impair
                if (i % 2 == 1)
                {
                    // passage à l'élément suivant
                    // on reste dans la boucle 
                    // mais on execute pas le code plus bas sur cet élément
                    // passe a l'élément suivant
                    // on abrège les instructions
                    continue;
                }

                Console.WriteLine("valeur de i " + i);

                // arret total de la boucle 
                // avec break on sort de la boucle
                if (i == 12)
                {
                    break;
                }

            }

            Console.WriteLine("after break");

            // parcours / boucle dynamique sur une liste
            foreach(int num in numbers)
            {
                Console.WriteLine("Le nombre est " + num);
            }

            // d'autres types de boucles
            // while
            // do while



        }
    }
}
