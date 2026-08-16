import java.util.Scanner;
 /**
 * Main class
 * Asks for the number of suits and ranks, builds the deck, then loops a menu
 * letting the user shuffle, deal one hand, deal 100,000 hands (histogram) or quit
 * @author Churchill Daniel
 */
public class Main {
    /**
     *A method to test the object
     * @param args unused
     */
    public static void main(String[] args) {
        //create the scanner object
        Scanner scanner = new Scanner(System.in);

        System.out.print("How many suits? ");
        int numSuits = scanner.nextInt();
        System.out.print("How many ranks? ");
        int maxRank = scanner.nextInt();

        //create an instance of the DeckOfCards class
        DeckOfCards deckOfCards = new DeckOfCards(maxRank, numSuits);
        System.out.println(deckOfCards);

        //running a loopr for the code to get response from the user infinitly
        boolean running = true;
        while (running) {
            System.out.print("1=shuffle, 2=deal 1 hand, 3=deal 100000 times, 4=quit: ");
            int choice = scanner.nextInt();
            switch (choice) {
                //case to shuffle the deck of cards
                case 1:
                    deckOfCards.shuffle();
                    System.out.println(deckOfCards);
                    break;

                    //case to deal a number of cards
                case 2: {
                    System.out.print("How many cards? ");
                    int n = scanner.nextInt();
                    if (n < 1 || n > deckOfCards.size()) {
                        System.out.println("Please choose between 1 and " + deckOfCards.size() + " cards.");
                        break;
                    }
                    Card[] hand = deckOfCards.deal(n);
                    for (Card c : hand) {
                        System.out.print(c + " ");
                    }
                    System.out.println();
                    System.out.println(deckOfCards);
                    break;
                }

                //case to run the histogram
                case 3: {
                    System.out.print("How many cards? ");
                    int n = scanner.nextInt();
                    if (n < 1 || n > deckOfCards.size()) {
                        System.out.println("Please choose between 1 and " + deckOfCards.size() + " cards.");
                        break;
                    }
                    int[] histogram = deckOfCards.histogram(n);

                    for (int i = 0; i < histogram.length; i++) {
                        if (histogram[i] != 0) {
                            String asterisk = "*".repeat(histogram.length-i);
                            System.out.println(" " + i + ": " + histogram[i] + " " + asterisk);
                        }
                    }
                    System.out.println(deckOfCards);
                    break;
                }

                //case to end the loop and set the running boolean to false
                case 4:
                    running = false;
                    System.out.println("BYE!");
                    break;

                    //a default if invalid data is passed
                default:
                    System.out.println("Invalid choice. Try again.");
            }
        }
    }
}