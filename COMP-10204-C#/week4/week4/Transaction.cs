using System;

namespace week4
{
    internal class Transaction
    {
        public TransactionType Type { get; }
        public decimal Amount { get; }

        public Transaction(TransactionType type, decimal amount)
        {
            Type = type;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{Type} of {Amount:c}";
        }
    }
}