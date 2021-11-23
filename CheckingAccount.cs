using System;

class CheckingAccount : BankAccount
    {
      public CheckingAccount():this(1000){}
      public CheckingAccount(double balance):base(balance, DateTime.Today, "None", "None")
        {
        }
      public CheckingAccount(double balance, DateTime date):base(balance, date, "None", "None")
        {
        }
      public CheckingAccount(double balance, DateTime date, string name):base(balance, date, name, "None")
        {
        }
      public CheckingAccount(double balance, DateTime date, string name, string acctnbr)
        {
            Balance = balance;
            DateCreated = date;
            Name = name;
            AcctNbr=acctnbr;

        }
      
        public override void CalculateInterest()
      {
          Console.WriteLine("Now calculating interest");
          int age = DateTime.Today.Year-DateCreated.Year;
          Balance = Balance+(Balance*.005*age);
          Console.WriteLine("New balance is: $"+ Balance);}
      
    }