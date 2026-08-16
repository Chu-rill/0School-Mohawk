package karen.exp5;

public class Static {

    private  int counter;

    private static int counter2;

    public Static(){
        counter++;
        counter2++;
    }

    @Override
    public String toString() {
        return "Static{" +
                "counter=" + counter +
                ":counter2=" + counter2 +
                '}';
    }

    public static void main(String[] args) {
        Static static1 = new Static();
        Static static2 = new Static();
        System.out.println(static1.toString());
        System.out.println(static2.toString());
    }
}
