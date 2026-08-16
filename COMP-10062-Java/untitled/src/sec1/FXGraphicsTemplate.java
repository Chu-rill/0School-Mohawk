package sec1;

import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;
import javafx.stage.Stage;
import static javafx.application.Application.launch;

/**
 * Use this template to create drawings in FX. Change the name of the class and
 * put your own name as author below. Change the size of the canvas and the
 * window title where marked and add your drawing code where marked.
 *
 * @author YOUR NAME
 */
public class FXGraphicsTemplate extends Application {

    /**
     * Start method (use this instead of main).
     *
     * @param stage The FX stage to draw on
     * @throws Exception
     */
    @Override
    public void start(Stage stage) throws Exception {
        Group root = new Group();
        Scene scene = new Scene(root);
        Canvas canvas = new Canvas(800, 600); // Set canvas Size in Pixels
        stage.setTitle("sec1.FXGraphicsTemplate"); // Set window title
        root.getChildren().add(canvas);
        stage.setScene(scene);
        GraphicsContext gc = canvas.getGraphicsContext2D();

        // YOUR CODE STARTS HERE 
        int x = 100;
        int y = 100; //middle
        int w = 100;
        int h = w;

//        gc.setStroke(12);


        //snow man
//        gc.setStroke(Color.BLACK);
//        gc.setFill(Color.LIGHTBLUE);
//
//        gc.fillOval(300,220, w,h);
//        
//        gc.fillOval(315, 170,60,60);

        int r = 100; // diameter
        int overlap = 30; // how much circles overlap horizontally
        int rowGap = 60; // vertical offset for bottom row (less than r so they overlap)

// Top row: circles 1, 2, 3 (indices 0, 2, 4 in ring order — but simpler to just lay out by position)
        int spacing = r - overlap;

        Color[] colors = {
                Color.BLUE,
                Color.BLACK,
                Color.RED,
                Color.YELLOW,
                Color.GREEN
        };

// x positions: top row has 3 circles, bottom row has 2 centered in the gaps
        int topY = 150;
        int botY = topY + rowGap;

        int[] xs = {
                100,                    // blue   (top-left)
                100 + spacing,          // black  (top-middle)
                100 + spacing * 2,      // red    (top-right)
                100 + spacing / 2,      // yellow (bottom-left, centered between blue & black)
                100 + spacing + spacing / 2  // green  (bottom-right, centered between black & red)
        };

        int[] ys = {
                topY, topY, topY,       // top row
                botY, botY              // bottom row
        };

// Draw filled rings (donut effect using stroke instead of fill)
        gc.setLineWidth(8);
        for (int i = 0; i < 5; i++) {
            gc.setStroke(colors[i]);
            gc.strokeOval(xs[i], ys[i], r, r);
        }


        
        // YOUR CODE STOPS HERE
        stage.show();
    }

    /**
     * The actual main method that launches the app.
     *
     * @param args unused
     */
    public static void main(String[] args) {
        launch(args);
    }
}
