import java.util.Scanner;
/**
 * A generic freight car, such as a box-car, flat-bed or tanker. It adds a type
 * to the basic TrainCar and uses a fixed number of wheels. It is built through
 * the static create() method.
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
public class FreightCar extends TrainCar{
    /** The kind of freight car (box-car, flat-bed, tanker, and so on) **/
    private String type;
    /** The fixed number of wheels on every freight car **/
    private static final int wheels = 8;

    /**
     * Builds a freight car with the given details.
     * @param name the name or serial number of the car
     * @param type the kind of freight car
     * @param weight the weight of the car in tonnes
     **/
    public FreightCar(String name, String type, double weight) {
        super(name,weight,wheels);
        this.type = type;
    }

    /**
     * Asks the user for the car's name, type and weight, then builds and
     * returns a FreightCar.
     * @return the new FreightCar object
     **/
    public static FreightCar create(){
        System.out.println("** New Freight Car **");
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter the name of the Car: ");
        String name = scanner.nextLine();
        System.out.print("Enter the type of Car: ");
        String type = scanner.nextLine();
        System.out.print("Enter the Car weight 100 - 250: ");
        double weight = scanner.nextDouble();
        if (weight < 100 || weight > 250){
            return  new FreightCar(name,type,100);
        }
        return new FreightCar(name,type,weight);
    }

    /**
     * @return the kind of freight car
     **/
    public String getType(){
        return type;
    }

    /**
     * @return a text description of the freight car
     **/
    @Override
    public String toString() {
        return "FreightCar{" +
                "type='" + type + '\'' +
                '}';
    }
}
