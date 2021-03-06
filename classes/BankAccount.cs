using System;
using System.Collections.Generic;

namespace classes
{
    public class BankAccount
    {
      public string Number { get; }
      public string Owner { get; }
      public decimal Balance 
      { 
          get
          {
              decimal balance = 0;
              foreach (var item in allTransactions)
              {
                  balance += item.Amount;
              }
              return balance;
          } 
      }
      private static int accountNumberSeed = 1234567890;
      private List<Transaction> allTransactions = new List<Transaction>();
      public string GetAccountHistory()
      {
          var report = new System.Text.StringBuilder();
          report.AppendLine("Date\t\tAmount\tNote");
          foreach (var item in allTransactions)
          {
              report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount:C}\t{item.Notes}");   
          }
          return report.ToString();
      }
      public void MakeDeposit(decimal amount, DateTime date, string note)
      {
          if (amount <= 0)
          {
              throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
          }
          var deposit = new Transaction(amount, date, note);
          allTransactions.Add(deposit);
      }

      public void MakeWithDrawal(decimal amount, DateTime date, string note)
      {
          if (amount <= 0)
          {
              throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
          }
          if (Balance - amount < 0)
          {
              throw new InvalidOperationException("Not sufficient funds for this withdrawal");
          }
          var withdrawal = new Transaction(-amount, date, note);
          allTransactions.Add(withdrawal);
      }

      public BankAccount(string name, decimal initialBalance)
      {
        this.Owner = name;
        MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        this.Number = accountNumberSeed.ToString();
        accountNumberSeed++;
      }
    }
}