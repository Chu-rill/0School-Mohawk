package karen.exp2;

public class Child extends Parent {
    public void foo(int x){
        System.out.println(x);
    }

    public void foo(int x,int y,int z){
        System.out.println(x+ " , " + y + " , " + z) ;
    }
}
