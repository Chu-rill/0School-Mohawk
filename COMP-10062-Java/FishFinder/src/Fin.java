import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;
/**
 * The Fin class draws a simple fish fin as a triangle.
 *
 * @author Churchill Daniel
 */
public class Fin {
    /** The relative size of the fin. **/
    private double fSize;
    /** The X position of one end of the fin. **/
    private double x;
    /** The Y position of one end of the fin. **/
    private double y;
    /** The major color of the fin. **/
    private Color finColor;
    /**
     * Fin constructor.
     *
     * @param fSize The relative size of the fin.
     * @param x The X position of one end of the fin.
     * @param y The Y position of one end of the fin.
     * @param finColor The major color of the fin.
     */
    public Fin(double fSize, double x, double y, Color finColor){
        this.x = x;
        this.y = y;
        this.fSize = fSize;
        this.finColor = finColor;
    }
    /**
     * Draw a fin with 3 lines.
     *
     * @param gc a reference to the object to draw on.
     *
     */
    public void draw(GraphicsContext gc) {
        gc.setStroke(finColor);
        gc.strokeLine(x,y,x + 20 * fSize, y + 20 * fSize);
        gc.strokeLine(x + 20 * fSize, y + 20 * fSize,
                x + 20 * fSize, y - 10 * fSize);
        gc.strokeLine(x + 20 * fSize, y - 10 * fSize, x,y);
    }
}
