package karen.exp1;

import java.util.Arrays;

public class CollectionOfDice {
    private final int numOfDice = 6;
    Die[] dice;

    public CollectionOfDice() {
        dice = new Die[numOfDice];

        for (int i = 0; i < numOfDice; i++) {
            dice[i] = new Die(6);
        }
    }

    @Override
    public String toString() {
        return "CollectionOfDice{" +
                "numOfDice=" + numOfDice +
                ", dice=" + Arrays.toString(dice) +
                '}';
    }
}
