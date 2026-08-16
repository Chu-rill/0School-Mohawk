
/**
 * Represents a single car that can sit on a train. It stores the car's name,
 * weight, number of wheels and whether its brakes are on. The other car types
 * (FreightCar, AdminCar, and AdminCar's subclasses) extend this class.
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
public class TrainCar {

    /** The name or serial number of the car **/
    private String name;
    /** The weight of the car in tonnes **/
    private double weight;
    /** The number of wheels on the car **/
    private int wheels;
    /** Whether the car's brakes are currently on (true) or off (false) **/
    private boolean brakeOn;


    /**
     * Builds a train car with the given details.
     * @param name the name or serial number of the car
     * @param weight the weight of the car in tonnes
     * @param wheels the number of wheels on the car
     **/
    public TrainCar(String name, double weight, int wheels) {
        this.name = name;
        this.weight = weight;
        this.wheels = wheels;
    }


    /**
     * Turns this car's brakes on or off.
     * @param brake true to apply the brakes, false to release them
     **/
    public void setBrake(boolean brake) {
        this.brakeOn = brake;
    }

    /**
     * @return the name of the car
     **/
    public String getName() {
        return name;
    }

    /**
     * @return the weight of the car in tonnes
     **/
    public double getWeight() {
        return weight;
    }

    /**
     * @return a text description of the car and its current state
     **/
    @Override
    public String toString() {
        return "TrainCar{" +
                "name='" + name + '\'' +
                ", weight=" + weight +
                ", wheels=" + wheels +
                ", brakeOn=" + brakeOn +
                '}';
    }
}
