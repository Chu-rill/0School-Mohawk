package sec1;

import java.util.Scanner;

public class Ex1 {

    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a temperature in F> ");
        double f = scanner.nextDouble();
        double feedBack = fahrenheitToCelsius(f);
        System.out.printf("The temperature in Celsius is %.2f ", feedBack);
    }
    public static double fahrenheitToCelsius(double f){
        return 5 *(f-32)/9;
    }
}
