package OOP;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        Tv tv1 = new Tv();

        while (true){
            System.out.println("Select a task to run");
            System.out.println("1: Change the channel");
            System.out.println("2: Turn TV on or off");
            System.out.println("3: Watch the tv");

            int choice = scanner.nextInt();
            tv1.setChannel(4);

        }

    }
}
