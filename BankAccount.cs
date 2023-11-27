public class BankAccount {

   private double Balance = 0;

   public string OwnersName = "";




public BankAccount( string NewOwnersName, double initialBalance) {

    this.OwnersName = NewOwnersName;
    if ( initialBalance < 0)
    {
        throw new Exception("Nope");
    }
    this.Balance = initialBalance;
    this.Balance += 100.00;
}

public double Deposit(double amount) {
    this.Balance += amount;
    return this.Balance;
}
public double getBalance() {
    return this.Balance;
}
 
}