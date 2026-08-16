package sec1;

import java.util.Scanner;

public class Conditional {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int numToFind = (int) (Math.random()*10+1);
        boolean guessing = true;

        while (guessing){
            System.out.print("Enter a number between 1-10: ");
            int userNum = scanner.nextInt();
            if (numToFind == userNum){
                System.out.println("You got the correct number");
                guessing = false;
            } else if (numToFind > userNum) {
                System.out.println("The number is greater");
            }else {
                System.out.println("The number is lesser");
            }
        }


    }
}
