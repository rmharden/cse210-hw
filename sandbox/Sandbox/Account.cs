/*
First Step:
public class Account
{
    public int _balance = 0;
    public void Deposit(int amount)
    {
        _balance = _balance + amount;

        Console.WriteLine(_balance);
    }
}
*/

/*
Second Step:
public class Account
{
    public List<int> _transactions = new List<int>();

    public void Deposit(int amount)
    {
        _transactions.Add(amount);
    }
}
*/

/*  
Video: Encapsulation:
public class Account
{
    //private int _balance;
    private List<int> _transactions = new List<int>();
    // The Access Modifiers are changed here in the Account class.
    public void Deposit(int amount)
    {
        //_balance = _balance + amount;
        _transactions.Add(amount);
    }
    public int GetBalance()
    {

    }

}
*/