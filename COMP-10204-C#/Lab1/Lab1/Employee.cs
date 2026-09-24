namespace Lab1;
/// <summary>
/// I, Churchill Daniel, 000983683 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
///
/// 
/// This is a class called Employee used to handle the data gotten from the txt
/// </summary>
public class Employee
{
    private string name;
    private int number;
    private decimal rate;
    private double hours;
    private decimal gross;

    /// <summary>
    /// Constructor for the class to set the value
    /// when you make an instance of the class
    /// </summary>
    /// <param name="name">Employee's full name</param>
    /// <param name="number">Employee number</param>
    /// <param name="rate">Hourly pay rate</param>
    /// <param name="hours">Hours worked</param>
    public Employee(string name, int number, decimal rate, double hours)
    {
        this.name = name;
        this.number = number;
        this.rate = rate;
        this.hours = hours;
        CalculateGross();
    }

    public string GetName() => name;
    public int GetNumber() => number;
    public decimal GetRate() => rate;
    public double GetHours() => hours;
    public decimal GetGross() => gross;

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
        CalculateGross();
    }

    public void SetHours(double hours)
    {
        this.hours = hours;
        CalculateGross();
    }

    /// <summary>
    /// This method uses the formula giving in the assignment not to calculate the Gross and assigns it
    /// when you make the class instance
    /// </summary>
    private void CalculateGross()
    {
        if (hours > 40.0)
        {
            double overtimeHours = hours - 40.0;
            gross = (40.0m * rate) + ((decimal)overtimeHours * rate * 1.5m);
        }
        else
        {
            gross = (decimal)hours * rate;
        }
    }

    public override string ToString()
    {
        return $"{name}, {number}, {rate}, {hours}, {gross}";
    }
}
