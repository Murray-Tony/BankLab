 using System;
 
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount()
        {
            Balance = 1000;
        }

         public BankAccount(double balance)
        {
            Balance = balance;
        }

        public virtual void Deposit(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("Updated balance is: $"+ Balance);
        }

        public virtual void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
        public abstract void CalculateInterest();

    }