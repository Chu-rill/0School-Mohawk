/**
 * A train car that also carries staff and provides an administration point.
 * It extends TrainCar by adding a count of the staff on board. TrainEngine and
 * Caboose both extend this class.
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
public class AdminCar extends TrainCar {
    /** The number of staff carried on this car **/
    private int totalStaff;

    /**
     * Builds an admin car with the given details.
     * @param name the name or serial number of the car
     * @param weight the weight of the car in tonnes
     * @param wheels the number of wheels on the car
     * @param totalStaff the number of staff carried (must not be negative)
     **/
    public AdminCar(String name, double weight, int wheels, int totalStaff) {
        super(name, weight, wheels);
        if (totalStaff < 0) {
            System.out.println("Staff count cannot be negative");
            return;
        }
        this.totalStaff = totalStaff;
    }



    /**
     * @return a text description showing the number of staff on the car
     **/
    @Override
    public String toString() {
        return "AdminCar{" +
                "totalStaff=" + totalStaff +
                '}';
    }
}
