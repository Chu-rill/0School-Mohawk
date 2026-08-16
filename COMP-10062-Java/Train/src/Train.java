
import java.util.Arrays;
import java.util.Scanner;
/**
 * Represents a whole train: a name plus an array of the cars that make it up.
 * It can report the total weight, work out how long the train takes to reach
 * 100 km/h, and apply or release the brakes on every car. A train is built
 * through the static create() method.
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
public class Train {
    /** The name of the train **/
    private String name;
    /** The number of cars on the train **/
    private int numCars;
    /** The array holding all the train's cars **/
    private TrainCar[] cars;
    /** A Scanner used to read the user's car type choices while building **/
    Scanner scanner = new Scanner(System.in);

    /**
     * Private constructor. Sets up the array of cars and asks the user to
     * choose each car in turn.
     * @param name the name of the train
     * @param numCars the number of cars on the train
     **/
    private Train(String name, int numCars) {
        this.name = name;
        this.numCars = numCars;
        this.cars = new TrainCar[numCars];

        for (int i = 0; i < numCars; i++) {
            System.out.println();
            System.out.println("Car " + (i + 1) + " of " + numCars + ":");
            cars[i] = createCar();
        }
    }

    /**
     * Asks the user for the train's name and length, then builds the train.
     * @return the new Train object
     **/
    public static Train create() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("** Build a new train car **");
        System.out.print("Train name: ");
        String name = scanner.nextLine();
        System.out.print("How many cars are on the train? (1 - 500): ");
        int numCars = scanner.nextInt();
        return new Train(name, numCars);
    }

    /**
     * Asks the user which type of car to add and calls the matching create()
     * method.
     * @return the new TrainCar object chosen by the user
     **/
    private TrainCar createCar() {
        System.out.println("  What type of car? 1 = Engine, 2 = FreightCar, 3 = Caboose");
        System.out.print(" Enter 1, 2 or 3: ");
        int choice = scanner.nextInt();
        if (choice == 1) {
            return TrainEngine.create();
        } else if (choice == 2) {
            return FreightCar.create();
        } else {
            return Caboose.create();
        }
    }

    /**
     * Adds up the weight of every car on the train.
     * @return the total weight of the train in tonnes
     **/
    public double getTotalWeight() {
        double total = 0.0;
        for (int i = 0; i < numCars; i++) {
            total = total + cars[i].getWeight();
        }
        return total;
    }

    /**
     * Adds up the power of every engine on the train.
     * @return the total engine power of the train in KW
     **/
    private double getTotalPower() {
        double total = 0.0;
        for (int i = 0; i < numCars; i++) {
            if (cars[i] instanceof TrainEngine) {
                TrainEngine engine = (TrainEngine) cars[i];
                total = total + engine.getPower();
            }
        }
        return total;
    }

    /**
     * Works out how long the whole train takes to reach 100 km/h. Engine power
     * is added together, so more engines make the train accelerate faster.
     * @return the time in seconds to reach 100 km/h
     **/
    public double getTime100kph() {
        double totalWeight = getTotalWeight();
        double totalPower = getTotalPower();
        return (totalWeight / totalPower) * 400.0;
    }

    /**
     * Applies the brakes on every car and prints a line confirming each one.
     **/
    public void applyBrake() {
        for (int i = 0; i < numCars; i++) {
            cars[i].setBrake(true);
            System.out.println(cars[i].getName() + ": brakes applied");
        }
    }

    /**
     * Releases the brakes on every car.
     **/
    public void releaseBrake() {
        for (int i = 0; i < numCars; i++) {
            cars[i].setBrake(false);
        }
    }

    /**
     * @return a text description of the train and all of its cars
     **/
    @Override
    public String toString() {
        return "Train{" +
                "name='" + name + '\'' +
                ", numCars=" + numCars +
                ", cars=" + Arrays.toString(cars) +
                '}';
    }
}
