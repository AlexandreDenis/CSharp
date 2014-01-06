using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

namespace TestCours
{
    public enum TimeOfDay
    {
        Morning = 0,
        Afternoon = 1,
        Evening = 2
    }

    class Prg2
    {
        public static void methode()
        {
            CultureInfo ci = new CultureInfo("en");
            int nombre = 1234;
            Console.WriteLine("Monétaire : {0}", nombre.ToString("C", ci));
            Console.WriteLine("Décimal : {0}", nombre.ToString("D", ci));
            Console.WriteLine("Scientifique : {0}", nombre.ToString("E", ci));
            Console.WriteLine("Virgule fixe : {0}", nombre.ToString("F", ci));
            Console.WriteLine("Général : {0}", nombre.ToString("G", ci));
            Console.WriteLine("Nombre : {0}", nombre.ToString("N", ci));
            Console.WriteLine("Pourcentage : {0}", nombre.ToString("P", ci));
            Console.WriteLine("Hexadécimal : {0}", nombre.ToString("X", ci));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*****EX1*****/
           /* var entier = 0;
            Type entierType = entier.GetType();
            Console.WriteLine(entierType.ToString());*/

            /*****EX2*****/
            /*
            bool pair;
            for (int i = 0; i < 30; i += 5)
            {
                if (i % 2 == 0)
                    pair = true;
                else
                    pair = false;
                Console.WriteLine("{0} est {1}.", i, (pair ? "pair" : "impair"));

            }*/

            /*****EX3*****/
            /*foreach (string chiffre in new string[] { "one", "two", "three" })
            {
                switch (chiffre)
                {
                    case "one":
                        Console.WriteLine(1);
                        break;
                    case "three":
                        Console.WriteLine(3);
                        break;
                    default:
                        continue;
                }
            } */


            /*****EX4*****/
            /*TimeOfDay   t = (TimeOfDay)Enum.Parse(typeof(TimeOfDay),"afternoon",true);
            Console.WriteLine("{0}",(int)t);*/

           /******EX5******/
           /* Thread newThread = new Thread(Prg2.methode);
            newThread.Start();

            CultureInfo ci = new CultureInfo("fr-CA");
            int nombre = 1234;
            Console.WriteLine("Monétaire : {0}", nombre.ToString("C", ci));
            Console.WriteLine("Décimal : {0}", nombre.ToString("D", ci));
            Console.WriteLine("Scientifique : {0}", nombre.ToString("E", ci));
            Console.WriteLine("Virgule fixe : {0}", nombre.ToString("F", ci));
            Console.WriteLine("Général : {0}", nombre.ToString("G", ci));
            Console.WriteLine("Nombre : {0}", nombre.ToString("N", ci));
            Console.WriteLine("Pourcentage : {0}", nombre.ToString("P", ci));
            Console.WriteLine("Hexadécimal : {0}", nombre.ToString("X", ci));
            Console.WriteLine("***************************************");*/

            /******EX6******/
            /*
            const string motif = @"ion\b";// ou "ion\\b"
            string saisie = Console.ReadLine();
            MatchCollection correspondances = Regex.Matches(saisie, motif, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
            foreach (Match correspondance in correspondances)
            {
                Console.WriteLine("{0}: {1}", correspondance.Index, correspondance.Value);
            }*/

            Console.WriteLine(SanitizeInput(Console.ReadLine()));

        }

        static string SanitizeInput(string input)
        {
            if (Regex.IsMatch(input, @"^(\w)+@(\w)+.(\w)$"))
                return input;
            else
                return "Adresse incorrecte";
        }
    }
    

}
