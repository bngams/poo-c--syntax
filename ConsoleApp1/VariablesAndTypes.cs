using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class VariablesAndTypes
    {
        private static int attribut;

        public static void Execute()
        {
            Console.WriteLine("");
            Console.WriteLine("==========================");
            Console.WriteLine("Manipulation des variables et des types");
            Console.WriteLine("==========================");
            // write your code here
            // on définit des variables de bloc 
            // on définit des variables simples (on a pas de portée - public ou private - a ce niveau)
            string productName = "TV";
            int productYear = 2012;
            float productPrice = 279.99f; // f 

            // test code
            Console.WriteLine("productName: " + productName);
            Console.WriteLine("productYear: " + productYear);
            Console.WriteLine("productPrice: " + productPrice);

        }

        public static void Test()
        {
            // non definit
            // productName = "test";
            attribut = 2;
        }
    }
}
