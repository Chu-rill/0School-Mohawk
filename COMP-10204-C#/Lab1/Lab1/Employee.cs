namespace Lab1;

/// <summary>
/// Stores the information for a single employee: name, employee number,
/// hourly pay rate, hours worked and the resulting gross pay.
///
/// Per the UML diagram, all data is private and reached only through the
/// Get/Set methods below (no public properties). The class performs no
/// console/file input or output of its own - it only stores data and keeps
/// gross pay in sync with it.
/// </summary>
public class Employee
{
    private string name;
    private int number;
    private decimal rate;
    private double hours;
    private decimal gross;

    /// <summary>
    /// Builds an Employee and immediately calculates its gross pay so the
    /// object is always in a valid, accurate state.
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
    /// Recomputes gross pay from rate and hours: straight time up to 40
    /// hours, and time-and-a-half for anything beyond that. Called from the
    /// constructor and from any setter that touches rate or hours, so
    /// gross is never allowed to go stale.
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
