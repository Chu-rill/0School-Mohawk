package karen.exp3;

import java.util.Scanner;

public class VehicleTest {
    public static void main(String[] args) {
        Vehicle[] vehicles;
        Scanner scanner = new Scanner(System.in);
        System.out.println("How many vehicles would you like to create?");
        int numberOfVehicles = scanner.nextInt();
        scanner.nextLine();
        vehicles = new Vehicle[numberOfVehicles];
        for (int i = 0; i < numberOfVehicles; i++) {
            vehicles[i] = create();
        }
        System.out.println("Enter vehicle one number:");
        int v1 = scanner.nextInt();
        System.out.println("Enter vehicle two number:");
        int v2 = scanner.nextInt();
        scanner.nextLine();

        boolean result = vehicles[v1].raceAgainst(vehicles[v2]);
        System.out.println(result);

    }

    public static Vehicle create(){
        Scanner scanner = new Scanner(System.in);
        System.out.println("What kind of vehicle? c-Car,t-Truck,m-MotorCycle: ");
        String vechicleType = scanner.nextLine();
        System.out.println("What is the horsepower");
        int horsePower = scanner.nextInt();
        scanner.nextLine();

        if (vechicleType.equalsIgnoreCase("c")){
            return new Car(horsePower);
        } else if (vechicleType.equalsIgnoreCase("t")) {
            return new Truck(horsePower);
        }
        {
            return new MotorCycle(horsePower);
        }
    }
}
