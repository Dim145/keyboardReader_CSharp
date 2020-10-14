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
                Console.WriteLine("erreur : saisissez un nombre entier (int) entre " + int.MinValue + " et " + int.MaxValue);
                return Clavier.lire_int();
            }

            return resultat;
        }

        public static uint lire_uint()
        {
            uint resultat = 0;

            if (!uint.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur : saisissez un nombre entier entre " + uint.MinValue + " et " + uint.MaxValue);
                return Clavier.lire_uint();
            }

            return resultat;
        }

        public static float lire_float()
        {
            float resultat = 0;

            if (!float.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur : saisissez un nombre réel (float) entre " + float.MinValue + " et " + float.MaxValue);
                return Clavier.lire_float();
            }

            return resultat;
        }

        public static byte lire_byte()
        {
            byte resultat = 0;

            if( !byte.TryParse(Clavier.lireString(), out resultat) )
            {
                Console.WriteLine("erreur: saisissez un nombre (byte) entre " + byte.MinValue + " et " + byte.MaxValue);

                return lire_byte();
            }

            return resultat;
        }

        public static sbyte lire_sbyte()
        {
            sbyte resultat = 0;

            if (!sbyte.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur: saisissez un nombre (byte) entre " + sbyte.MinValue + " et " + sbyte.MaxValue);

                return lire_sbyte();
            }

            return resultat;
        }

        public static short lire_short()
        {
            short resultat = 0;

            if (!short.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur: saisissez un nombre (byte) entre " + short.MinValue + " et " + short.MaxValue);

                return lire_short();
            }

            return resultat;
        }

        public static ushort lire_ushort()
        {
            ushort resultat = 0;

            if (!ushort.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur: saisissez un nombre (byte) entre " + ushort.MinValue + " et " + ushort.MaxValue);

                return lire_ushort();
            }

            return resultat;
        }

        public static long lire_long()
        {
            long resultat = 0;

            if (!long.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur: saisissez un nombre (byte) entre " + long.MinValue + " et " + long.MaxValue);

                return lire_long();
            }

            return resultat;
        }

        public static ulong lire_ulong()
        {
            ulong resultat = 0;

            if (!ulong.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur: saisissez un nombre (byte) entre " + ulong.MinValue + " et " + ulong.MaxValue);

                return lire_ulong();
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
                Console.WriteLine("erreur : saisissez un nombre Double entre " + double.MinValue +" et " + double.MaxValue);
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

        public static Boolean lireBoolean()
        {
            return lire_boolean();
        }

        public static Int16 lireInt16()
        {
            Int16 resultat = 0;

            if (!Int16.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur : saisissez un nombre entier (int) entre " + Int16.MinValue + " et " + Int16.MaxValue);
                return Clavier.lireInt16();
            }

            return resultat;
        }

        public static Int32 lireInt32()
        {
            Int32 resultat = 0;

            if (!Int32.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur : saisissez un nombre entier (int) entre " + Int32.MinValue + " et " + Int32.MaxValue);
                return Clavier.lireInt32();
            }

            return resultat;
        }

        public static Int64 lireInt64()
        {
            Int64 resultat = 0;

            if (!Int64.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur : saisissez un nombre entier (int) entre " + Int64.MinValue + " et " + Int64.MaxValue);
                return Clavier.lireInt64();
            }

            return resultat;
        }

        public static UInt64 lireUInt64()
        {
            UInt64 resultat = 0;

            if (!UInt64.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur : saisissez un nombre entier (int) entre " + UInt64.MinValue + " et " + UInt64.MaxValue);
                return Clavier.lireUInt64();
            }

            return resultat;
        }

        public static UInt32 lireUInt32()
        {
            UInt32 resultat = 0;

            if (!UInt32.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur : saisissez un nombre entier (int) entre " + UInt32.MinValue + " et " + UInt32.MaxValue);
                return Clavier.lireUInt32();
            }

            return resultat;
        }

        public static UInt16 lireUInt16()
        {
            UInt16 resultat = 0;

            if (!UInt16.TryParse(Clavier.lireString(), out resultat))
            {
                Console.WriteLine("erreur : saisissez un nombre entier (int) entre " + UInt16.MinValue + " et " + UInt16.MaxValue);
                return Clavier.lireUInt16();
            }

            return resultat;
        }

        public static SByte lireSByte()
        {
            return lire_sbyte();
        }

        public static Byte lireByte()
        {
            return lire_byte();
        }

        public static Char lireChar()
        {
            return lire_char();
        }

        public static Single lireSingle()
        {
            return lire_float();
        }

        public static Double lireDouble()
        {
            return lire_double();
        }
    }
}
