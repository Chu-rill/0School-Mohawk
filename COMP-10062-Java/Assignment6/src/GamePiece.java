import javafx.scene.canvas.GraphicsContext;

/**
 * Abstract class to represent a Game Piece in the Grid Game
 */
public abstract class GamePiece {
    /**
     * Abstract method to be implemented by child classes
     * @param gc GraphicsContext for drawing
     * @param row Which row the piece will be in
     * @param col Which col the piece will be in
     * @param size Size of the piece (diameter)
     * @param selected If the piece is selected (clicked on) or not.  Only one piece can be selected at a time.
     */
    public abstract void draw(GraphicsContext gc, int row, int col, int size, boolean selected);
}
