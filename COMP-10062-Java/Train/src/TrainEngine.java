import java.util.Scanner;
/**
 * The engine (locomotive) that pulls or pushes the train. It is an admin car
 * that also has a description and an amount of power, and it can work out how
 * long it would take to accelerate a weight to 100 km/h, so it implements the
 * EngineLimits interface.
 *
 * Statement of Authorship: I, Churchill Daniel, 000983683, certify
 * that this work is my own work and that I did not consult external resources
 * including artificial intelligence software to complete this assignment without
 * due acknowledgement. I further certify that I did not provide my solution to
 * any other students, nor will I provide it to future students taking this
 * course at a later date.
 *
 * @author Churchill Daniel
 */
public class TrainEngine extends AdminCar implements EngineLimits {
    /** A description of the engine, such as its maker or model **/
    private String description;
    /** The power of the engine in KW **/
    private double power;
    /** The fixed number of staff that crew every engine **/
    private static final int staff = 2;


    /**
     * Builds a train engine with the given details.
     * @param name the name or serial number of the engine
     * @param weight the weight of the engine in tonnes
     * @param wheels the number of wheels on the engine
     * @param description a description of the engine (maker / model)
     * @param power the power of the engine in KW
     **/
    public TrainEngine(String name, double weight, int wheels, String description, double power) {
        super(name, weight, wheels,staff);
        this.description = description;
        this.power = power;
    }

    /**
     * Asks the user for the engine's details, then builds and returns a
     * TrainEngine.
     * @return the new TrainEngine object
     **/
    public static TrainEngine create(){
        Scanner scanner = new Scanner(System.in);
        System.out.println("** New Train Engine **");
        System.out.print("Enter the name of the Train Engine: ");
        String name  = scanner.nextLine();
        System.out.print("Enter the weight of the Train Engine: ");
        double weight  = scanner.nextDouble();
        System.out.print("Enter the number of wheels: ");
        int wheels  = scanner.nextInt();
        scanner.nextLine();
        System.out.print("Enter the description of the Train Engine: ");
        String description  = scanner.nextLine();
        System.out.print("Enter the power of the Train Engine: ");
        double power  = scanner.nextDouble();
        return new TrainEngine(name, weight, wheels, description, power);
    }

    /**
     * @return the description of the engine
     **/
    public String getDescription() {
        return description;
    }

    /**
     * @return the power of the engine in KW
     **/
    public double getPower() {
        return power;
    }

    /**
     * Works out how long this engine alone would take to accelerate the given
     * weight to 100 km/h. More weight means more time and more power means less
     * time.
     * @param weight the total weight (in tonnes) to be accelerated
     * @return the time in seconds to reach 100 km/h
     **/
    @Override
    public double getTime100Kph(double weight) {
        return (weight / power) * 400.0;
    }


    /**
     * @return a text description of the engine
     **/
    @Override
    public String toString() {
        return "TrainEngine{" +
                "description='" + description + '\'' +
                ", power=" + power +
                '}';
    }
}
