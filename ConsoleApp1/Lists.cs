using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Lists
    {
        public static void Execute()
        {
            Console.WriteLine("");
            Console.WriteLine("==========================");
            Console.WriteLine("Manipulation des listes");
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

            // taille de la liste
            Console.WriteLine("taille de la liste " + numbers.Count);

            // différentes méthodes disponibles sur la classe List
            if(numbers.Contains(10))
            {
                Console.WriteLine("la liste contient la valeur 10");
            }


        }
    }
}
