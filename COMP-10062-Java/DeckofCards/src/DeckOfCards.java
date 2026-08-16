/**
 * DeckOfCards model class
 * Holds one Card of every (rank x suit) combination in an array.
 * The constructor takes the maximum rank first, then the number of suits,
 * so new DeckOfCards(6, 3) builds 18 cards.
 * @author Churchill Daniel
 */
    public class DeckOfCards {
        //an array of type card to store the collection of cards
        private final Card[] cards;

    /**
     * The constructor for the DeckOfCard class
     * @param maxRank  the highest rank in the deck
     * @param numSuits the number of suits in the deck
     */
    public DeckOfCards(int maxRank, int numSuits) {
        cards = new Card[maxRank * numSuits];
        int index = 0;
        for (int suit = 1; suit <= numSuits; suit++) {
            for (int rank = 1; rank <= maxRank; rank++) {
                cards[index] = new Card(rank, suit);
                index++;
            }
        }
    }

    /**
     *gets the length of the cards array
     * @return the size of the card array
     */
    public int size() {
        return cards.length;
    }

    /**
     * Smallest card value in the deck
     * runs a for loops to be sure
     * @return an int of the min value in the array
     */
    public int getMinValue() {
        int min = cards[0].getValue();
        for (Card c : cards) {
            if (c.getValue() < min) {
                min = c.getValue();
            }
        }
        return min;
    }

    /**
     * Largest card value in the deck
     * runs a for loops to be sure
     * @return an int of the max value in the array
     */
    public int getMaxValue() {
        int max = cards[0].getValue();
        for (Card c : cards) {
            if (c.getValue() > max) {
                max = c.getValue();
            }
        }
        return max;
    }

    /**
     * Shuffles by randomly swapping pairs of cards in the array
     * makes a temp variable to store the value of the original variable at the index
     */
    public void shuffle() {
        for (int i = 0; i < cards.length; i++) {
            int j = (int) (Math.random()*cards.length);
            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }

    /**
     * Deals the top n cards into a new array and returns it
     * makes a new copy of the cards array but doesn't replace it
     * @param n number of cards to deal
     * @return a new Card array with the selected card
     */
    public Card[] deal(int n) {
        Card[] hand = new Card[n];
        for (int i = 0; i < n; i++) {
            hand[i] = cards[i];
        }
        return hand;
    }

    /**
     * Shuffles and deals a hand of the given size 100,000 times. For each deal
     * it sums the card values and tallies that sum in a counter array, where
     * the array index is the sum. Returns the counter array.
     * @param handSize number of cards
     * @return an array of integers
     */
    public int[] histogram(int handSize) {
        int maxPossibleSum = handSize * getMaxValue();
        int[] counts = new int[maxPossibleSum + 1];
        for (int trial = 0; trial < 100000; trial++) {
            shuffle();
            Card[] hand = deal(handSize);
            int sum = 0;
            for (Card c : hand) {
                sum += c.getValue();
            }
            counts[sum]++;
        }
        return counts;
    }

    /** Reports size, min/max value, and the current top card. */
    @Override
    public String toString() {
        return "Deck of " + size() + " cards: low = " + getMinValue()
                + " high = " + getMaxValue() + " top = " + cards[0];
    }
}