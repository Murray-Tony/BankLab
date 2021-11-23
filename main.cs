using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

 
    CheckingAccount c1 = new CheckingAccount(25, Convert.ToDateTime("12/01/1991"));
    c1.Info();
    c1.Deposit(1040);
    c1.Withdraw(50);
    c1.Withdraw(2000);
    SavingsAccount s1 = new SavingsAccount(100, Convert.ToDateTime("11/03/1991"));
    s1.Info();
    s1.Deposit(2000);
    s1.Info();
    s1.CalculateInterest();
    s1.Info();
    c1.Info();
    c1.CalculateInterest();
    c1.Info();
 
   
    
            /*Test case 1
             * Create a savingsaccount object
             * Deposit $2000
             * Withdraw $5000
             * Calculate interest
             * Withdraw $500
            */

            /*Test case 2
            * Create a checkingaccount object
            * Deposit $2000
            * Withdraw $5000
            * Calculate interest
            * Withdraw $500
           */
  }
}