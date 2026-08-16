package karen.exp2;

public class Main {
    public static void main(String[] args) {
        Child c = new Child();
        Parent p = new Parent();
        GrandParent g = new GrandParent();

        c.foo(1);
        c.foo(1, 2);
        c.foo(1, 2, 3);
        p.foo(4);
        p.foo(4, 5);
//        p.foo(4, 5, 6);
        g.foo(7);
        g.foo(7, 8);
//        g.foo(7, 8, 9);
    }
}
