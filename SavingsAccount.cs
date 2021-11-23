using System;

class SavingsAccount : BankAccount
    {
      public override void CalculateInterest()
      {
          Console.WriteLine("Now calculating interest");
          int age = DateTime.Today.Year-DateCreated.Year;
          Balance = Balance+(Balance*.05*age);
          Console.WriteLine("New balance is: $"+ Balance);
        
      }
      public SavingsAccount():this(1000){}
      public SavingsAccount(double balance):base(balance, DateTime.Today, "None", "None")
        {
        }
      public SavingsAccount(double balance, DateTime date):base(balance, date, "None", "None")
        {
        }
      public SavingsAccount(double balance, DateTime date, string name):base(balance, date, name, "None")
        {
        }
      public SavingsAccount(double balance, DateTime date, string name, string acctnbr)
        {
            Balance = balance;
            DateCreated = date;
            Name = name;
            AcctNbr=acctnbr;

        }
    }