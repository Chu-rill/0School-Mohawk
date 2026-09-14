namespace Lab1;

public class Employee
{
    private string name;
    private int number;
    private decimal rate;
    private double hours;
    private decimal gross;

    public Employee(string name, int number, decimal rate, double hours, decimal gross)
    {
        this.name = name;
        this.number = number;
        this.rate = rate;
        this.hours = hours;
        this.gross = gross;
    }

    public decimal GetGross()
    {
        return this.gross;
    }

    public double GetHours()
    {
        return this.hours; 
    }
    public string GetName()
    {
        return this.name;
    }
    public int GetNumber()
    {
        return this.number;
    }

    public decimal GetRate()
    {
        return this.rate;
    }

    public void SetHours(double hours)
    {
        this.hours = hours;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetNumber(int number)
    {
        this.number = number;
    }

    public void SetRate(decimal rate)
    {
        this.rate = rate;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}