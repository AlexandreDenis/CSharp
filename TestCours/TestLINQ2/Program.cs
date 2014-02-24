using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestLINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>();

            contacts.Add(new Contact("Henri@isima.fr", "Henri", Contact.EStatus.Available, true));
            contacts.Add(new Contact("Murielle@isima.fr", "Murielle", Contact.EStatus.Disconnected, false));
            contacts.Add(new Contact("Yann@isima.fr", "Yann", Contact.EStatus.Away, false));
            contacts.Add(new Contact("Baptista@limos.fr", "Baptista", Contact.EStatus.Busy, false));
            contacts.Add(new Contact("Debra@limos.fr", "Debra", Contact.EStatus.Available, false));
            contacts.Add(new Contact("Dexter@limos.fr", "Dexter", Contact.EStatus.Disconnected, true));
            contacts.Add(new Contact("Hill@isima.fr", "Hill", Contact.EStatus.Away, true));
            contacts.Add(new Contact("Mazuka@limos.fr", "Mazuka", Contact.EStatus.Busy, false));
            contacts.Add(new Contact("Mitchell@isima.fr", "Mitchell", Contact.EStatus.Available, false));
            contacts.Add(new Contact("Chase@isima.fr", "Chase", Contact.EStatus.Disconnected, false));

            /*affichage des DisplayName de tous les contacts*/
            var allDisplayName = from n in contacts
                                 select n.DisplayName;

            Console.WriteLine("affichage des DisplayName de tous les contacts :");
            foreach (string s in allDisplayName)
            {
                Console.WriteLine(s);
            }

            /*le contact dont l'adresse est xxx@isima.fr est devant son pc*/
            string contact = "Dexter@isima.fr";

            var isDevantPC = from n in contacts
                             where n.Address == contact
                             select (!n.Status.ToString().Equals("Disconnected")).ToString();

            Console.WriteLine("le contact dont l'adresse est Dexter@isima.fr est devant son pc :");
            foreach (string s in isDevantPC)
            {
                Console.WriteLine(s);
            }

            /*L’état du contact dont l’adresse est saisie*/
            Console.WriteLine("Saisissez l'adresse dont vous voulez connaître l'état : ");
            contact = Console.ReadLine();

            var etatContact = from n in contacts
                             where n.Address == contact
                             select n.Status.ToString();

            Console.WriteLine("Etat :");
            foreach (string s in etatContact)
            {
                Console.WriteLine(s);
            }

            /*La liste des domaines des adresses des contacts VIP, avec le nombre de contacts par domaine*/
            var noname = from n in contacts
                         where n.IsVIP == true
                         group n by n.Address.Split('@')[1].ToString() into g
                         select new
                             {
                                 domaine = g.Key.ToString(),
                                 count = g.Count().ToString(),
                             }.ToString();

            Console.WriteLine("La liste des domaines des adresses des contacts VIP, avec le nombre de contacts par domaine :");
            foreach (string s in noname)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
