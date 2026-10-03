using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    internal class BankAccount
    {
        private static int nextBankAccountNumber = 10000;
        private decimal balance = 0;
        public BankAccountType Type { get; }
        public int Number { get; }
        public Person Owner { get; }
        private List<Transaction> Transactions;

        public BankAccount(Person owner,BankAccountType type)
        {
            Type = type;
            Owner = owner;
            Number = nextBankAccountNumber;
            Transactions = new List<Transaction>();

            nextBankAccountNumber++;
        }

        //public List<Transaction> GetTransaction()
        //{
        //    balance = 0;
        //    foreach (Transaction t in Transactions)
        //    {
        //        if(t.Type == TransactionType.DEPOSIT)
        //        {
        //            balance += t.Amount;
        //        }else if (t.Type == TransactionType.DEPOSIT)
        //        {
        //            balance -= t.Amount;
        //        }
        //    }
        //}
        public decimal GetCurrentBalance()
        {
            decimal balance = 0;      // type not visible; decimal is typical for money

            foreach (Transaction t in Transactions)
            {
                if (t.Type == TransactionType.DEPOSIT)
                    balance += t.Amount;
                else if (t.Type == TransactionType.WITHDRAWAL)
                    balance -= t.Amount;
            }
            return balance;
        }

        public void AddTransaction(Transaction transaction)
        {
            if (transaction.Type == TransactionType.WITHDRAWAL && GetCurrentBalance() < transaction.Amount)
                throw new ArgumentException("Insufficient funds");

            Transactions.Add(transaction);
        }


        public override string ToString()
        {
            return $"{Number} {Type} {Owner.FirstName} {Owner.LastName}";
        }

    }
}
