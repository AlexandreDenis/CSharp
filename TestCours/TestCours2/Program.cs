using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace TestCours2
{
    class ThreadFonc
    {
        public static void methode()
        {
            CultureInfo ci = new CultureInfo("en-GB");

            IBankAccount compteCourant = new BankAccount1(0);
            IBankAccount compteEpargne = new BankAccount2(0);

            compteCourant.PayIn(500);
            compteEpargne.PayIn(500);

            Console.WriteLine("Compte Courant : {0}", compteCourant.Balance.ToString("C",ci));
            Console.WriteLine("Compte Epargne : {0}", compteEpargne.Balance.ToString("C", ci));

            compteCourant.Withdraw(600);
            compteEpargne.Withdraw(600);

            Console.WriteLine("Compte Courant : {0}", compteCourant.Balance.ToString("C", ci));
            Console.WriteLine("Compte Epargne : {0}", compteEpargne.Balance.ToString("C", ci));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Thread newThread = new Thread(ThreadFonc.methode);
            newThread.Start();
            
        }
    }
}
