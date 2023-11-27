// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int age = 23;
// age = "fifty"; // can't do this

string name = "Benson";

// Console.WriteLine($"Your name is {name}, and you are {age} years old " );



try {
BankAccount newAccount = new BankAccount("Chatelain", 100.99);

// newAccount.Balance = 100.99;
// newAccount.Balance = newAccount.Balance + 100;

newAccount.Deposit(50.00);

Console.WriteLine($"{newAccount.OwnersName}, balance is {newAccount.getBalance()}");

} catch ( Exception err ) {
    Console.WriteLine($"You got an error: {err.Message}");
}