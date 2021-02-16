using System;

namespace Partie2_Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {

            int age;
            Console.WriteLine("votre age svp : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age>18) {
                Console.WriteLine(" Vous avez {0} ans, vous êtes donc majeur.e. ",age);
            }
            else
            {
                Console.WriteLine(" Vous avez {0} ans, vous êtes donc mineur.e.", age);
            }
           
        }
    }
}
