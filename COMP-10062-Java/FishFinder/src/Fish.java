import javafx.scene.paint.Color;
import javafx.scene.canvas.GraphicsContext;
/**
 * The Fish class draws a simple fish
 *and calls the draw method of the fin in the fish draw method method
 * @author Churchill Daniel
 */
public class Fish {
    /** The relative size of the fin. **/
    private double fSize;
    /** The X position of the fish. **/
    private double x;
    /** The Y position of the fish. **/
    private double y;
    /** The major color of the fish. **/
    private Color bodyColor;
    /** The major color of the fin. **/
    private Color finColor;


    /**Two variables of type the fin object **/
     Fin fin1;
     Fin fin2;

    /**
     *This is the Fish constructor it sets the values of the field to what is passed to the class
     * it makes 2 new fin object instances
     * @param fSize double
     * @param x double
     * @param y double
     * @param bodyColor The Color of the fish body
     * @param finColor The Color of the fin
     */
    public Fish(double fSize, double x, double y, Color bodyColor, Color finColor) {
        this.fSize = fSize;
        this.x = x;
        this.y = y;
        this.bodyColor = bodyColor;
        this.finColor = finColor;

        //assigning a value to the variables which is the instance of the class
        fin1 = new Fin(fSize, x + 50 * fSize, y, finColor);//fin 6
        fin2 = new Fin(fSize * 0.5, x + 5, y, finColor);//fin 1
    }

    /**
     * Draws a fish and calls the draw method in the fin class
     * @param gc a reference to the object to draw on.
     */
    public void draw(GraphicsContext gc) {
        gc.setStroke(bodyColor);
        gc.strokeOval(x, y - 26 * fSize / 2, 50 * fSize, 26 * fSize);

        fin1.draw(gc);
        fin2.draw(gc);
    }
}
