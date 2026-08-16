package sec2;

public class List {
    public static void main(String[] args) {
        int[] a = new int[10];

        a[0] = 1;
        a[1] = 2;

        for (int i =2 ;i < 10 ;i++){
            a[i] = i *2;
        }

        System.out.println("a: "+ a);

        for (int i =0 ;i < a.length ;i++){
            System.out.println(a[i]);
        }
    }
}
