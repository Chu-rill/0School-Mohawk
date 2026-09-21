namespace Excercise_2;

internal class Car
{
    private string make;
    private string model;
    private double fuel;
    private double mileage;

    public Car(string make, string model, double fuel, double mileage)
    {
        this.make = make;
        this.model = model;
        this.fuel = fuel;
        this.mileage = mileage;
    }

    public String GetMake()
    {
        return make;
    }

    public String GetModel()
    {
        return model;
    }

    public double CalculateFuelEfficiency()
    {
        return fuel / mileage * 100;
    }

    public override string ToString()
    {
        return $"[{make}], [{model}], Fuel Used = [{fuel}], Fuel Efficiency = [{CalculateFuelEfficiency():F}]";
    }
}