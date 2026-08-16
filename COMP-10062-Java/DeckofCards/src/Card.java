/**
 * Card model class
 * A Card has a final positive, non-zero integers for the rank and suit
 * The suit is displayed as a capital letter
 * Suit start at 'A' (suit 1 -> A, suit 2 -> B, ...)
 * @author Churchill Daniel
 */
public class Card {
    //the rank of cards ranging from 1+ represented with an integer
    private final int rank;
    //the number of cards in a suit represented with an integer
    private final int suit;

    /**
     * The constructor for the Card class
     * @param rank an integer for the rank
     * @param suit an integer for the suit
     */
    public Card(int rank, int suit) {
        this.rank = rank;
        this.suit = suit;
    }

    /**
     *a getter to get the rank of a card
     * @return the int value of the rank
     */
    public int getRank() {
        return rank;
    }

    /**
     *a getter to the get the suit a card is in
     * @return the int value of the suit
     */
    public int getSuit() {
        return suit;
    }

    /**
     *this method returns the multiplied value of rank and suit
     * @return an integer of the rank multiplied by the suit
     */
    public int getValue() {
        return rank * suit;
    }


    /**
     *to override the default object and memory address response
     * @return a formated version of the class eg "Card SAR1"
     */
    @Override
    public String toString() {
        String letter = "" + (char) ((int) 'A' + suit - 1);
        return "Card S" + letter + "R" + rank + ",";
    }
}