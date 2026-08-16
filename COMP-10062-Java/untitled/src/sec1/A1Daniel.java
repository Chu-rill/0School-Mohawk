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
import javafx.scene.text.Font;
import javafx.scene.text.FontWeight;
import javafx.stage.Stage;

import java.util.Scanner;

public class A1Daniel extends Application {


    @Override
    public void start(Stage stage) throws Exception {
        Group root = new Group();
        Scene scene = new Scene(root);
        Canvas canvas = new Canvas(600, 400);
        stage.setTitle("sec1.FXGraphicsTemplate");
        root.getChildren().add(canvas);
        stage.setScene(scene);
        GraphicsContext gc = canvas.getGraphicsContext2D();
        // YOUR CODE STARTS HERE
        Scanner scanner = new Scanner(System.in);
        //variables
        final int WIDTH = 600;
        final int HEIGHT = 400;
        final int POND_TOP = 60;
        int fishCount = (int) (Math.random()*200);
        // size for a big and small fish
        double bodyW = 42;
        double bodyH = 32;
        double tailW = 30;
        double tailH = 28;
        double smallBodyW = 22;
        double smallBodyH = 12;
        double smallTailW = 10;
        double smallTailH = 8;
        //display fish dimensions
        double currentBodyW = 0;
        double currentBodyH = 0;
        double currentTailW = 0;
        double currentTailH = 0;
        double currentTotalW = 0;
        //data from users
        int fishSize;
        String pondName = "";

        //loops to get data from users
        boolean nameGotten = false;
        boolean fishSizeGotten = false;
        while (!nameGotten){
            System.out.print("Enter a name for the pond: ");
            pondName = scanner.nextLine();
            if (pondName.length() < 3){
                System.out.println("Name of pond is to short");
            }else {
                nameGotten = true;
            }
        }

        while (!fishSizeGotten){
            System.out.print("What size of fish to be used [10,30 or a number between (1 - 5)]: ");
            fishSize = scanner.nextInt();
            if (fishSize == 30){
                currentBodyW = bodyW;
                currentBodyH = bodyH;
                currentTailW = tailW;
                currentTailH = tailH;
                fishSizeGotten = true;

            } else if (fishSize == 10) {
                currentBodyW = smallBodyW;
                currentBodyH = smallBodyH;
                currentTailW = smallTailW;
                currentTailH = smallTailH;
                fishSizeGotten = true;
            }else {
                if (fishSize < 1 || fishSize > 5){
                    System.out.println("Invalid input");
                }else {
                    currentBodyW = smallBodyW * fishSize;
                    currentBodyH = smallBodyH * fishSize;
                    currentTailW = smallTailW * fishSize;
                    currentTailH = smallTailH * fishSize;
                    fishSizeGotten = true;
                }

            }
            currentTotalW = currentBodyW + currentTailW;

        }

        //text at the top of the page
        gc.setFont(Font.font("Papyrus", FontWeight.LIGHT, 12));
        gc.setStroke(Color.DARKCYAN);
        gc.strokeText("Welcome to " + pondName + " pond,Written by Churchill Daniel 000983683", 10, 20);
        gc.strokeText("There are a total of " + fishCount + " fish in this pond", 10, 40);

        //drawing the pond on the screen
        gc.setFill(Color.LIGHTBLUE);
        gc.fillRect(0, POND_TOP, WIDTH, HEIGHT - POND_TOP);

        //commented the display image because it would throw an image not found error if i submit only the java file
        // Load the image file
//        Image myImage = new Image("seaweed-removebg-preview.png");
//        // Draw the image to the screen
//        double imgWidth = 100;
//        double imgHeight = 80;
//        int imgNumber = 5;
//        double imgX = 20;
//        double imgY = HEIGHT - imgHeight - 10;
//
//        for (int i = 1;i <= imgNumber;i++){
//            gc.drawImage(myImage, imgX, imgY, imgWidth, imgHeight);
//            imgX = imgX + 120;
//        }

        //Drawing the fish
        gc.setStroke(Color.GREEN);
        gc.setLineWidth(1.5);

        double x = Math.random() * (WIDTH - 60) + 10;
        double y = POND_TOP + 40;

        for (int i = 0;i <= fishCount;i++){

            if (x + currentTotalW > WIDTH - 10) {
                //random space when starting a new row
                x = 10 + Math.random() * 40;
                y += currentBodyH + 10;
            }

            if (i % 2 == 0) {
                gc.strokeOval(x, y - currentBodyH / 2, currentBodyW, currentBodyH);

                gc.strokeLine(x + currentBodyW, y, x + currentBodyW + currentTailW, y - currentTailH / 2);
                gc.strokeLine(x + currentBodyW, y, x + currentBodyW + currentTailW, y + currentTailH / 2);
                gc.strokeLine(x + currentBodyW + currentTailW, y - currentTailH / 2, x + currentBodyW + currentTailW, y + currentTailH / 2);
            } else {
                gc.strokeOval(x + currentTailW, y - currentBodyH / 2, currentBodyW, currentBodyH);

                gc.strokeLine(x + currentTailW, y, x, y - currentTailH / 2);
                gc.strokeLine(x + currentTailW, y, x, y + currentTailH / 2);
                gc.strokeLine(x, y - currentTailH / 2, x, y + currentTailH / 2);
            }

            //random space for fishes on the same row
            x += currentTotalW + 5 + Math.random() * 20;

        }

        // YOUR CODE STOPS HERE
        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }

}
