using System;

namespace classes
{
    public class BankAccount
    {
      public string Number { get; }
      public string Owner { get; }
      public decimal Balance { get; }
      private static int accountNumberSeed = 1234567890;

      public void MakeDeposit(decimal amount, DateTime date, string note)
      {

      }

      public void MakeWithDrawl(decimal amount, DateTime date, string note)
      {

      }

      public BankAccount(string name, decimal initialBalance)
      {
        this.Owner = name;
        this.Balance = initialBalance;
        this.Number = accountNumberSeed.ToString();
        accountNumberSeed++;
      }
    }
}