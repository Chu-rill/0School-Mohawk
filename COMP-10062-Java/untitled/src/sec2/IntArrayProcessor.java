package sec2;

public class IntArrayProcessor {
    private int[] a;
    public IntArrayProcessor(int[] a) {
        this.a = a;
    }

    public int length(){
        return a.length;
    }

    public void print(){
        System.out.print("[");
        for (int item: a){
            System.out.print(item + " ");
        }
        System.out.println("]");
    }

    public  void printReverse(){
        System.out.print("[");
        for (int i = a.length-1; i >=0 ; i--){
            System.out.print(a[i] + " ");
        }
        System.out.println("]");
    }

    public void increment(int i){
        for (int j = 0; j < a.length;j++){
            a[j] += i;
        }
    }

    public double average(){
        int sum = 0;
        for (int item: a){
            sum += item;
        }
       return (double) sum /a.length;
    }
}
