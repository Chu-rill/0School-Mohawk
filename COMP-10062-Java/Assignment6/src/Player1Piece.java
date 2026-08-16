import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

/**
 * Represents Player 1's game piece. It is drawn as a green circle.
 * This class inherits from the abstract GamePiece class and provides its own
 * version of the draw method (polymorphism).
 */
public class Player1Piece extends GamePiece {

    /**
     * Draws this piece as a green circle inside the given cell. If the piece is
     * selected, the cell behind it is highlighted so the user can see which
     * piece is currently selected.
     * @param gc GraphicsContext for drawing
     * @param row which row the piece is in
     * @param col which column the piece is in
     * @param size the size (width/height) of one cell
     * @param selected whether this piece is currently selected
     */
    @Override
    public void draw(GraphicsContext gc, int row, int col, int size, boolean selected) {
        // top-left corner of this cell
        int x = col * size;
        int y = row * size;

        // if the piece is selected, highlight the whole cell and redraw its border
        if (selected) {
            gc.setFill(Color.LIGHTYELLOW);
            gc.fillRect(x, y, size, size);
            gc.setStroke(Color.BLACK);
            gc.setLineWidth(1);
            gc.strokeRect(x, y, size, size);
        }

        // draw the green circle, leaving a small margin inside the cell
        int margin = 5;
        gc.setFill(Color.GREEN);
        gc.fillOval(x + margin, y + margin, size - 2 * margin, size - 2 * margin);
    }
}