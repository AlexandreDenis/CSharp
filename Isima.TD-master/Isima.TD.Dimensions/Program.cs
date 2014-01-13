using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Isima.TD.Dimensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            IFormePlane[] formes = new IFormePlane[2];
            formes[0] = new Rectangle(10, 20);
            formes[1] = new Cercle(30);

            for (int i = 0; i < formes.Length; i++)
            {
                Console.WriteLine("Avant [{0}]: surface={1} périmètre={2}", formes[i].GetType().Name, formes[i].Surface, formes[i].Perimetre);

                formes[i].Agrandir(2);

                Console.WriteLine("Après [{0}]: surface={1} périmètre={2}", formes[i].GetType().Name, formes[i].Surface, formes[i].Perimetre);

                Console.ReadLine();
            }
        }
    }
}
