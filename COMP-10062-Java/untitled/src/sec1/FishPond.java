package sec1; /**
 * This is the class header. Put a brief description of your
 * program here, and the date it was created. May 16, 2026
 *
 * Statement of Authorship: I, Churchill Daniel 000983683, certify
 * that this work is my own work and that I did not consult external resources
 * including artificial intelligence software to complete this assignment without
 * due acknowledgement. I further certify that I did not provide my solution to
 * any other students, nor will I provide it to future students taking this
 * course at a later date.
 *
 * @author Churchill Daniel
 **/
import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;
import javafx.stage.Stage;

import java.util.ArrayList;
import java.util.Scanner;

class Fish {
    double x;
    double y;

    Fish(double x, double y) {
        this.x = x;
        this.y = y;
    }
}

public class FishPond extends Application {
    Scanner scanner = new Scanner(System.in);

    @Override
    public void start(Stage stage) throws Exception {

        System.out.print("Enter the number of fishes to be displayed: ");
        int fishCount = Integer.parseInt(scanner.nextLine());
        System.out.print("What size of fish to be used [BigFish,SmallFish]: ");
        String fishSize = scanner.nextLine();

        //variables
        int WIDTH = 800;
        int HEIGHT = 600;
        int POND_TOP = 80;
        // size for a big and small fish
        double bodyW = 42;
        double bodyH = 32;
        double tailW = 30;
        double tailH = 28;
        double smallBodyW = 22;
        double smallBodyH = 12;
        double smallTailW = 10;
        double smallTailH = 8;


        //Canva setup
        Group root = new Group();
        Scene scene = new Scene(root);
        Canvas canvas = new Canvas(WIDTH, HEIGHT);
        stage.setTitle("sec1.Fish Pond");
        root.getChildren().add(canvas);
        stage.setScene(scene);
        GraphicsContext gc = canvas.getGraphicsContext2D();

        //text at the top of the page
        gc.strokeText("Welcome to Watery pond,Written by Churchill Daniel 000983683", 10, 20);
        gc.strokeText("There are a total of " + fishCount + " fish in this pond", 10, 40);

        //drawing the pond on the screen
        gc.setFill(Color.LIGHTBLUE);
        gc.fillRect(0, POND_TOP, WIDTH, HEIGHT - POND_TOP);


        ArrayList<Fish> fishes = new ArrayList<>();

        double currentBodyW = fishSize.equalsIgnoreCase("BigFish") ? bodyW : smallBodyW;
        double currentBodyH = fishSize.equalsIgnoreCase("BigFish") ? bodyH : smallBodyH;
        double currentTailW = fishSize.equalsIgnoreCase("BigFish") ? tailW : smallTailW;
        double currentTailH = fishSize.equalsIgnoreCase("BigFish") ? tailH : smallTailH;
        double currentTotalW = currentBodyW + currentTailW;


        //Drawing the fish
        gc.setStroke(Color.GREEN);
        gc.setLineWidth(1.5);

        for (int i = 0;i < fishCount;i++){
                //generating the fish position on the x and y-axis
                double x = 0;
                double y = 0;
                boolean overlap = true;

                while (overlap) {
                    overlap = false;
                    x = Math.random() * (WIDTH - 60) + 10;
                    y = Math.random() * (HEIGHT - POND_TOP - 30) + POND_TOP + 15;
                    for (Fish f : fishes) {
                        if (Math.abs(f.x - x) < currentTotalW && Math.abs(f.y - y) < currentBodyH) {
                            overlap = true;
                            break;
                        }
                    }
                }

                //add the new positions to the List
                fishes.add(new Fish(x, y));

                gc.strokeOval(x, y - currentBodyH / 2, currentBodyW, currentBodyH);

                double[] tailX = { x + currentBodyW, x + currentBodyW + currentTailW, x + currentBodyW + currentTailW };
                double[] tailY = { y, y - currentTailH / 2, y + currentTailH / 2 };
                gc.strokePolygon(tailX, tailY, 3);

            }

        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }

}
