package karen.exp1;

import java.util.Random;

public class Die {
    private int numOfSides;

    public Die(int numOfSides) {
        if (numOfSides < 1){
            System.out.println("Invalid number of sides!");
        }else {
            this.numOfSides = 6;
        }
    }

    public int roll(){
        Random rand = new Random();
        return rand.nextInt(numOfSides+1);
    }
}
