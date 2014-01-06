using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCours2
{
    /// <summary>
    /// Avec autorisation de découvert sans limite
    /// </summary>
    public class BankAccount1 : IBankAccount
    {
        private decimal _balance;
        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }

        /// <summary>
        /// Depot
        /// </summary>
        /// <param name="amount"></param>
        public void PayIn(decimal amount)
        {
            _balance += amount;
        }

        /// <summary>
        /// Retrait
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool Withdraw(decimal amount)
        {
            _balance -= amount;
            return true;
        }

        public BankAccount1(decimal inBalance)
        {
           _balance = inBalance;
        }
    }
}
