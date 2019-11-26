using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // utilisation de l'API C# (classes internes a C#)
            Console.WriteLine("Hello World!");

            // utilisation des variables
            int num1 = 2;
            int num2 = 4;
            int res = num1 + num2;
            Console.WriteLine("Result: " + res);

            // utilisation du enum
            var status = EnumStatus.EN_RUPTURE;
            Console.WriteLine("Enum: " + status);

            // if (CONDITION)
            // operateurs ==, !=, >=, <=, >, <
            // operateurs logique && AND, || OR
            // on detaille l'operation
            // status != EnumStatus.EN_STOCK => true (renvoie vrai)
            // num1 == num2 => false
            // l'operation true || false
            // le || ou && s'arretent des qu'il trouvent une valeur
            if (status != EnumStatus.EN_STOCK || num1 == num2)
            {
                Console.WriteLine("Rupture");
            }
            bool a = !true;
            // !a <=> a == false
            if(!a)
            {
                Console.WriteLine("");
            }
            bool b = (num1 == 2);
            if (b)
            {
                Console.WriteLine("It's true!");
            }

            // appeler une methode statique
            VariablesAndTypes.Execute();
            Arrays.Execute();
            Lists.Execute();
            Loops.Execute();

        }
    }
}
