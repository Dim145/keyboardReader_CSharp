using System;
using System.Collections.Generic;
using System.Text;
using Lecture;

namespace TestClavier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Saisie String = ");
            String s = Clavier.lireString();
            Console.WriteLine("Resultat = " + s);

            Console.Write("Saisie int = ");
            int i = Clavier.lire_int();
            Console.WriteLine("Resultat = " + i);

            Console.Write("Saisie float = ");
            float f = Clavier.lire_float();
            Console.WriteLine("Resultat = " + f);

            Console.Write("Saisie byte = ");
            sbyte by = Clavier.lire_sbyte();
            Console.WriteLine("Resultat = " + by);

            Console.Write("Saisie bool = ");
            bool b = Clavier.lire_boolean();
            Console.WriteLine("Resultat = " + b);
        }
    }
}
