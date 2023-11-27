public class BankAccount {

   public double Balance = 0;

   public string Ownersname = "";

   


public BankAccount( string NewOwnersName, double initialBalance) {

    this.Ownersname = NewOwnersName;

    this.Balance = initialBalance;
    this.Balance += 100.00;
}

}