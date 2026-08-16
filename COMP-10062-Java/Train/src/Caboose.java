import java.util.Scanner;
/**
 * A special admin car that normally sits at the end of the train and houses
 * workers. Each caboose is given an automatic name (CABOOSE-1, CABOOSE-2, ...)
 * and uses a fixed number of wheels and staff. It is built through the static
 * create() method, because its constructor is private.
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
public class Caboose extends AdminCar{
    /** The fixed number of wheels on every caboose **/
    private static final int wheels = 8;
    /** The fixed number of staff carried on every caboose **/
    private static final int numOfStaff = 4;

    /** A counter used to give each caboose a unique name **/
    private static int cabooseCount = 1;



    /**
     * Private constructor. Builds a caboose with an automatic name and the
     * fixed wheel and staff values, then increases the name counter.
     * @param weight the weight of the caboose in tonnes
     **/
    private Caboose(double weight) {
        super("CABOOSE-" + cabooseCount, weight, wheels, numOfStaff);
        cabooseCount++;
    }


    /**
     * Asks the user for the caboose weight, then builds and returns a Caboose.
     * @return the new Caboose object
     **/
    public static Caboose create() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("** New Caboose **");
        System.out.print("Enter the Car weight 30 - 100: ");
        double weight = scanner.nextDouble();
        if (weight < 30 || weight > 100){
            return  new Caboose(30);
        }
        return new Caboose(weight);
    }

    /**
     * @return a text description of the caboose
     **/
    @Override
    public String toString() {
        return "Caboose " + super.toString();
    }
}
