using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

 
    CheckingAccount c1 = new CheckingAccount();
    c1.Deposit(1040);
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