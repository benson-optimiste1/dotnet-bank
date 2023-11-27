public class SavingsAccount: BankAccount {

    public SavingsAccount(string NewOwnersName, double InitialBalance)
    : base(NewOwnersName, InitialBalance)
    {
        this.Deposit(100); 
    }
}

public class CheckingAccount: BankAccount {

    public CheckingAccount(string NewOwnersName, double InitialBalance)
    : base( NewOwnersName, InitialBalance)
    {
       
    }
}