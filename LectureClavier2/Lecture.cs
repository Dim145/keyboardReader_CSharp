using System;

namespace Lecture
{
    public class Clavier
    {
        public static string lireString()
        {
            return Console.ReadLine();
        }

        public static int lire_int()
        {
            int resultat = 0;

            if( !int.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur : saisissez un nombre entier (int) entre -2147483648 et 2147483647");
                return Clavier.lire_int();
            }

            return resultat;
        }

        public static char lire_char()
        {
            return Console.ReadKey().KeyChar;
        }

        public static double lire_double()
        {
            double resultat = 0.0;

            if( !Double.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur : saisissez un nombre Double entre 4.9E-324 et 1.7976931348623157E308");
                return Clavier.lire_double();
            }

            return resultat;
        }

        public static bool lire_boolean()
        {
            char tmp = ("" + Clavier.lire_char()).ToLower().ToCharArray()[0];

            if      (tmp == 'v' || tmp == '1') return true;
            else if (tmp == 'f' || tmp == '0') return false;
            else
            {
                Console.WriteLine("erreur : saisissez un nombre boolean (0, 1),(V,F)");
                return Clavier.lire_boolean();
            }
        }
    }
}
