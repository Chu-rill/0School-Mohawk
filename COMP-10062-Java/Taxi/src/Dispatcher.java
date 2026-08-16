/**
 * This is the view for the program called dispatcher it assigns values to 2 variables choice and selectedDriver
 * it calls and prints the response from 3 public methods in the Taxi class
 * May 26, 2026
 * Statement of Authorship: I, Churchill Daniel 000983683, certify
 * that this work is my own work and that I did not consult external resources
 * including artificial intelligence software to complete this assignment without
 * due acknowledgement. I further certify that I did not provide my solution to
 * any other students, nor will I provide it to future students taking this
 * course at a later date.
 *
 * @author Churchill Daniel
 **/
import java.util.Scanner;

public class Dispatcher {
  public static void main(String[] args) {
      Scanner scanner = new Scanner(System.in);
      Taxi taxi1 = new Taxi();
      taxi1.setDriverName("Ali");
      Taxi taxi2 = new Taxi();
      taxi2.setDriverName("Bob");

      while (true){
          System.out.println("1: "+taxi1);
          System.out.println("2: "+taxi2);
          System.out.print("Menu: Select a Taxi [1 or 2]: ");
          int choice = Integer.parseInt(scanner.nextLine());
          Taxi selectedDriver = (choice == 1) ? taxi1 : taxi2;

          System.out.print("Menu2: 1. New Ride, 2. Tip driver, 3. Off duty [1, 2 or 3]: ");
          int action = Integer.parseInt(scanner.nextLine());
            if (action == 1){
                System.out.print("What city?: ");
                String city = scanner.nextLine();
                System.out.print("What street?: ");
                String street = scanner.nextLine();

                String rideResult = selectedDriver.newRide(street, city);
                System.out.println(rideResult);
            } else if (action == 2) {
                System.out.print("tip $: ");
                int tipAmount = Integer.parseInt(scanner.nextLine());

                String tipResult = selectedDriver.payTip(tipAmount);
                System.out.println(tipResult);
            } else if (action == 3) {
                String response = selectedDriver.setOffDuty();
                System.out.println(response);
            }else {
                System.out.println("Invalid action. Please choose 1, 2, or 3.");
            }
      }
    }
}
