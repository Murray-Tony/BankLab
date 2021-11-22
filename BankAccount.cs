 using System;
 
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount():this(1000, DateTime.Today, "None", "None")
        {
        }
        public BankAccount(double balance):this(balance, DateTime.Today, "None", "None")
        {
        }
        public BankAccount(double balance, DateTime date):this(balance, date, "None", "None")
        {
        }
        public BankAccount(double balance, DateTime date, string name):this(balance, date, name, "None")
        {
        }
         public BankAccount(double balance, DateTime date, string name, string acctnbr)
        {

            Balance = balance;
            DateCreated = date;
            Name = name;
            AcctNbr=acctnbr;

        }
        public virtual void Info()
        {
          Console.WriteLine(AcctNbr + " "+ Name + " "+Balance+" " + DateCreated);
        }

        public virtual void Deposit(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("Updated balance is: $"+ Balance);
        }

        public virtual void Withdraw(double amount)
        {
            if (Balance >= amount){
              Balance = (Balance-amount);
              Console.WriteLine("$" +amount +" has been withdrawn.");
              }
            else
            Console.WriteLine("Amount is greater than balance, withdrawal cancelled.");
          Console.WriteLine("Current balance is: $"+Balance);
        }
      
        public abstract void CalculateInterest();

    }