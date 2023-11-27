public class BankAccount {

   private double Balance = 0;

   public string OwnersName = "";




public BankAccount( string NewOwnersName, double initialBalance) {

    this.OwnersName = NewOwnersName;

    this.Balance = initialBalance;
    this.Balance += 100.00;
}

public double getBalance() {
    return this.Balance;
}
 
}