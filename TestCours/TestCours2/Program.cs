using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCours2
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankAccount compteCourant = new BankAccount1(0);
            IBankAccount compteEpargne = new BankAccount2(0);

            compteCourant.PayIn(500);
            compteEpargne.PayIn(500);

            Console.WriteLine("Compte Courant : {0}", compteCourant.Balance);
            Console.WriteLine("Compte Epargne : {0}", compteEpargne.Balance);

            compteCourant.Withdraw(600);
            compteEpargne.Withdraw(600);

            Console.WriteLine("Compte Courant : {0}", compteCourant.Balance);
            Console.WriteLine("Compte Epargne : {0}", compteEpargne.Balance);
        }
    }
}
