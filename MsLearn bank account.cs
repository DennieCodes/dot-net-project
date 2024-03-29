// var account = new BankAccount("Dennie", 1000);

// account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
// Console.WriteLine(account.Balance);
// account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
// Console.WriteLine(account.Balance);

// // Test that the initial balances must be positive.
// // Test for a negative balance.
// try
// {
//   account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
// }
// catch (InvalidOperationException e)
// {
//   Console.WriteLine("Exception caught trying to overdraw");
//   Console.WriteLine(e.ToString());
// }

// Console.WriteLine(account.GetAccountHistory());

// // BankAccount invalidAccount;
// // try
// // {
// //   invalidAccount = new BankAccount("invalid", -55);
// // }
// // catch (ArgumentOutOfRangeException e)
// // {
// //   Console.WriteLine("Exception caught creating account with negative balance");
// //   Console.WriteLine(e.ToString());
// //   return;
// // }

// Console.WriteLine($"Account: {account.Number} Owner:{account.Owner}, has {account.Balance}");

// // BankAccount Class Definition
// public class BankAccount
// {
//   public string Number { get; }
//   public string Owner { get; set; }
//   public decimal Balance
//   {
//     get
//     {
//       decimal balance = 0;
//       foreach (var item in _allTransactions)
//       {
//         balance += item.Amount;
//       }

//       return balance;
//     }
//   }

//   private static int s_accountNumberSeed = 1234567890;

//   // Constructor
//   public BankAccount(string name, decimal initialBalance)
//   {
//     Owner = name;
//     Number = s_accountNumberSeed.ToString();
//     s_accountNumberSeed++;
//     MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
//   }

//   private List<Transaction> _allTransactions = new List<Transaction>();

//   public string GetAccountHistory()
//   {
//     var report = new System.Text.StringBuilder();

//     decimal balance = 0;
//     report.AppendLine("Date\t\tAmount\tBalance\tNote");
//     foreach (var item in _allTransactions)
//     {
//       balance += item.Amount;
//       report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
//     }

//     return report.ToString();
//   }

//   public void MakeDeposit(decimal amount, DateTime date, string note)
//   {
//     if (amount <= 0)
//     {
//       throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
//     }
//     var deposit = new Transaction(amount, date, note);
//     _allTransactions.Add(deposit);
//   }

//   public void MakeWithdrawal(decimal amount, DateTime date, string note)
//   {
//     if (amount <= 0)
//     {
//       throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
//     }
//     if (Balance - amount < 0)
//     {
//       throw new InvalidOperationException("Not sufficient funds for this withdrawal");
//     }
//     var withdrawal = new Transaction(-amount, date, note);
//     _allTransactions.Add(withdrawal);
//   }
// }

// // Transaction Class Definition
// public class Transaction
// {
//   public decimal Amount { get; }
//   public DateTime Date { get; }
//   public string Notes { get; }

//   public Transaction(decimal amount, DateTime date, string note)
//   {
//     Amount = amount;
//     Date = date;
//     Notes = note;
//   }
// }
