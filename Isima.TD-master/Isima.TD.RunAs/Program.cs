using System;
using System.Security.Principal;
using Isima.TD.RunAs.Security;

namespace Isima.TD.RunAs
{
    class Program
    {
        static void Main(string[] args)
        {
            ImpersonatedSecurityContext nouv;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Domaine : ");
            string domain = Console.ReadLine();

            Console.Write("Identifiant : ");
            string username = Console.ReadLine();

            Console.Write("Mot de passe : ");
            Console.ForegroundColor = ConsoleColor.Black;
            string password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            nouv = new ImpersonatedSecurityContext(username, domain, password);
            nouv.Connexion();

            Console.ReadLine();
        }
    }
}
