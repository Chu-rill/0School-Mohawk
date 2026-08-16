import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.HBox;
import javafx.scene.paint.Color;
import javafx.stage.Stage;

/**
 * Assignment 6 - Grid Based Game.
 * Clicking an empty cell adds a piece (players alternate colours). Clicking a
 * piece selects it, and clicking an empty cell while a piece is selected moves
 * that piece. Pieces can be removed by typing a row and column and pressing the
 * Remove button.
 */
public class Assignment6 extends Application {

//    Number of rows, number of columns, and the size of a cell in pixels.
    private final int ROWS = 10;
    private final int COLS = 10;
    private final int CELL_SIZE = 40;

//    2D array representing the board, accessed by [row][col] (both start at 0).
    private GamePiece[][] board = new GamePiece[ROWS][COLS];

    private Canvas canvas;
    private GraphicsContext gc;

//    Text fields used for removing a piece from the board.
    private TextField rowField;
    private TextField colField;

    /**
     * true means the next piece added belongs to Player 1 (green),
     * false means Player 2 (brown). This makes the pieces alternate.
     */
    private boolean player1Turn = true;

//    The selected piece's location. -1 means nothing is selected.
    private int selectedRow = -1;
    private int selectedCol = -1;

    /**
     * Sets up the window and its controls.
     * @param stage the primary stage for this application
     */
    public void start(Stage stage) {

        canvas = new Canvas(COLS * CELL_SIZE + 30, ROWS * CELL_SIZE + 30);
        gc = canvas.getGraphicsContext2D();

        // Mouse listener: adds, selects, and moves pieces
        canvas.setOnMouseClicked(event -> handleCanvasClick(event.getX(), event.getY()));

        BorderPane root = new BorderPane();
        root.setCenter(canvas);

        HBox controls = new HBox(10);
        rowField = new TextField();
        rowField.setPromptText("Row");
        colField = new TextField();
        colField.setPromptText("Col");

        Button removeButton = new Button("Remove");
        removeButton.setOnAction(event -> handleRemove());

        controls.getChildren().addAll(new Label("Remove:"), rowField, colField, removeButton);
        root.setBottom(controls);

        drawEverything();

        stage.setScene(new Scene(root));
        stage.setTitle("Grid Game (Array Version)");
        stage.show();
    }

    /**
     * Figures out which cell was clicked, then adds, selects, or moves a piece.
     * @param clickX the x pixel the user clicked
     * @param clickY the y pixel the user clicked
     */
    private void handleCanvasClick(double clickX, double clickY) {
        // Convert the pixel click into a grid cell
        int col = (int) (clickX / CELL_SIZE);
        int row = (int) (clickY / CELL_SIZE);

        // Ignore clicks outside the actual board (the canvas is a bit larger)
        if (row < 0 || row >= ROWS || col < 0 || col >= COLS) {
            return;
        }

        if (selectedRow == -1) {
            // Nothing is selected yet
            if (board[row][col] == null) {
                // Empty cell: add a new piece, then switch turns
                if (player1Turn) {
                    board[row][col] = new Player1Piece();
                } else {
                    board[row][col] = new Player2Piece();
                }
                player1Turn = !player1Turn;
            } else {
                // A piece is here: select it
                selectedRow = row;
                selectedCol = col;
            }
        } else {
            // A piece is already selected
            if (row == selectedRow && col == selectedCol) {
                // Clicked the same piece: deselect it
                selectedRow = -1;
                selectedCol = -1;
            } else if (board[row][col] == null) {
                // Empty cell: move the selected piece here
                board[row][col] = board[selectedRow][selectedCol];
                board[selectedRow][selectedCol] = null;
                selectedRow = -1;
                selectedCol = -1;
            } else {
                // Target cell is taken: not allowed
                new Alert(Alert.AlertType.WARNING, "You can only move a piece to an empty cell.").showAndWait();
                selectedRow = -1;
                selectedCol = -1;
            }
        }

        drawEverything();
    }

    /**
     * Removes the piece at the row/column typed into the text fields, showing an
     * error if the input is not a number, is off the board, or the cell is empty.
     */
    private void handleRemove() {
        int row;
        int col;

        // The text boxes might not contain numbers
        try {
            row = Integer.parseInt(rowField.getText().trim());
            col = Integer.parseInt(colField.getText().trim());
        } catch (NumberFormatException e) {
            new Alert(Alert.AlertType.WARNING, "Please enter whole numbers for the row and column.").showAndWait();
            return;
        }

        // The numbers might be off the board
        if (row < 0 || row >= ROWS || col < 0 || col >= COLS) {
            new Alert(Alert.AlertType.WARNING, "That row/column is not on the board. Use 0 to " + (ROWS - 1) + ".").showAndWait();
            return;
        }

        // The cell might be empty
        if (board[row][col] == null) {
            new Alert(Alert.AlertType.WARNING, "There is no piece in that cell to remove.").showAndWait();
            return;
        }

        board[row][col] = null;

        // If the removed piece was selected, clear the selection
        if (row == selectedRow && col == selectedCol) {
            selectedRow = -1;
            selectedCol = -1;
        }

        drawEverything();
    }

    /**
     * Clears the screen and redraws the grid and all pieces.
     */
    private void drawEverything() {
        gc.clearRect(0, 0, canvas.getWidth(), canvas.getHeight());
        drawGrid();

        for (int r = 0; r < ROWS; r++) {
            for (int c = 0; c < COLS; c++) {
                GamePiece piece = board[r][c];
                if (piece != null) {
                    boolean selected = (r == selectedRow && c == selectedCol);
                    piece.draw(gc, r, c, CELL_SIZE, selected);
                }
            }
        }
    }

    /**
     * Draws the grid lines.
     */
    private void drawGrid() {
        gc.setStroke(Color.BLACK);
        gc.setLineWidth(1);
        for (int r = 0; r <= ROWS; r++) {
            gc.strokeLine(0, r * CELL_SIZE, COLS * CELL_SIZE, r * CELL_SIZE);
        }
        for (int c = 0; c <= COLS; c++) {
            gc.strokeLine(c * CELL_SIZE, 0, c * CELL_SIZE, ROWS * CELL_SIZE);
        }
    }

    /**
     * Launches the JavaFX application.
     * @param args command line arguments
     */
    public static void main(String[] args) {
        launch(args);
    }
}