/**
 * The School class draws it draws a school of fishes
 * it also calls the fish draw in the school draw method
 * display's the name of the school and the count of the fishes
 * @author Churchill Daniel
 */
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;
import javafx.scene.text.Font;

public class School {
    /** The X position of the fish. **/
    private double x;
    /** The Y position of the fish. **/
    private double y;
    /** An integer to store a random number for the amount of fishes generated**/
    private int count;
    /** A string for the type of fish**/
    private String species;
    /** An array of the fish object type to store the count of fishes which isn't fixed**/
     Fish[] fish;
    /** The major color of the fin. **/
     Color fin = null;
    /** The major color of the body. **/
     Color body = null;

    /**
     * The school constructor to set the field values and to make new fish class instances
     * @param x double
     * @param y double
     * @param species string
     */
    public School(double x, double y, String species) {
        this.x = x;
        this.y = y;
        this.species = species;
        this.count = (int) (2 + Math.random() * 4);


//        if else block to assign a fish color based on the specie name entered
        if (species.equalsIgnoreCase("Anchovy")){
            body = Color.LIMEGREEN;
        } else if (species.equalsIgnoreCase("Salmon")) {
            body = Color.CRIMSON;
        }else {
            body = Color.DARKGRAY;
        }
//        java fx color method to make a darker shade of the assigned color
        fin = body.darker();

//        sets the size of the array to be what is gotten from count
        fish = new Fish[count];
        fish[0] = new Fish(1.3, x + 230, y + 12, body, fin);//big fish
//      for loop to generate small fishes
        for (int i = 1; i < count; i++) {
            int n = i - 1;
            int spacey = n % 2;
            int spacex = n / 2;
            fish[i] = new Fish(0.55, x + spacey * 55, y + spacex * 32, body, fin);
        }
    }

    /**
     * a getter to get the amount of fishes generated
     * @return int
     */
    public int getCount() {
        return count;
    }

    /**
     * Runs an enhanced for loop to draw the fishes in  the array
     * and draws out a school of fishes
     * @param gc a reference to the object to draw on.
     */
    public void draw(GraphicsContext gc) {
        for (Fish item : fish) {
            item.draw(gc);
        }

        gc.setFill(Color.BLACK);
        gc.setFont(Font.font(13));
        gc.fillText(count + " " + species, x + 95, y + 70);
    }


}
