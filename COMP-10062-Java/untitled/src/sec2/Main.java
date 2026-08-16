package sec2;

public class Main {
    public static void main(String[] args) {
        int[] numbers = {6,9,12,54,3,2,8};
        IntArrayProcessor list = new IntArrayProcessor(numbers);


        System.out.println("Array length: " + list.length());

        System.out.println("Regular");
        list.print();
        System.out.println("Revers");
        list.printReverse();

        list.increment(4);

        System.out.println("Array average: " + list.average());
    }
}
