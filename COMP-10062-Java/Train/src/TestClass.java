
/**
 * A short test program that builds a train from user input, applies the
 * brakes, and prints how long the train takes to reach 100 km/h, warning if
 * the train is too heavy.
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
public class TestClass {
    /**
     * Builds a train, applies its brakes, and reports it's time to 100 km/h.
     * @param args unused
     **/
    public static void main(String[] args) {
        Train t = Train.create();
        t.applyBrake();
        System.out.printf("Time to reach 100kph: %.2f seconds\n",
                t.getTime100kph());
        if (t.getTime100kph() > 600){
            System.out.println("** Warning: Train is too heavy.");
        }

    }
}
