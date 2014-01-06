using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCours2
{

    /// <summary>
    /// Sans découvert possible
    /// </summary>
    public class BankAccount2 : IBankAccount
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
            bool res = false;

            if (_balance - amount > 0)
            {
                _balance -= amount;
                res = true;
            }

            return res;
        }

        public BankAccount2(decimal inBalance)
        {
            _balance = inBalance;
        }
    }
}
