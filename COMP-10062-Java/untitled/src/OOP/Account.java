package OOP;

public class Account {
    private String name;
    private int accountId;
    private int balance;
    private double interestRate;

    /**
     *
     * @param amount
     */

    public void deposit(int amount){
        this.balance  = balance + amount;
    }

    /**
     *
     * @param amount this is the amount you want to take out
     * @return an amount in int
     */
    public int withdraw(int amount){
        return this.balance - amount;
    }

    public static void main(String[] args) {


    }

    @Override
    public String toString() {
        return "Account{" +
                "name='" + name + '\'' +
                ", accountId=" + accountId +
                ", balance=" + balance +
                ", interestRate=" + interestRate +
                '}';
    }


}
