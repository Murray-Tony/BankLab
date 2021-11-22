using System;

class SavingsAccount : BankAccount
    {
      public override void CalculateInterest()
      {
          int age = DateCreated.Year-DateTime.Today.Year;
          Balance = Balance+(Balance*.05*age);
          Console.WriteLine("New balance is: $"+ Balance);
        
      }
      
    }