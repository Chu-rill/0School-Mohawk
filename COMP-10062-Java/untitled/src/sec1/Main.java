package sec1;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {

    public static void main(String[] args) {


        int n = 5;
        for (int x = 0;x<7;x++){
            if (x == 0 || x ==6){
                System.out.println("*".repeat(7));
            }else {
                System.out.println("*" + " ".repeat(n) + "*");
            }
        }
    }
}