package gui;


import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.text.Font;
import javafx.stage.Stage;

/**
 * Use this template to create Apps with Graphical User Interfaces.
 *
 * @author sam.scott1
 */
public class Main extends Application {

    public final int WIDTH = 400;
    public final int HEIGHT = 400;

    // TODO: Instance Variables for View Components and Model
    TextField field1;
    Circle c1;
    GraphicsContext gc;
    // TODO: Private Event Handlers and Helper Methods
    private void myHandler(ActionEvent e) {
        double radius = Double.parseDouble(field1.getText());
        c1.drawwt(gc);
        c1.setRadius(radius);
        c1.draw(gc);
    }
    /**
     * This is where you create your components and the model and add event
     * handlers.
     *
     * @param stage The main stage
     * @throws Exception
     */
    @Override
    public void start(Stage stage) throws Exception {
        Pane root = new Pane();
        Scene scene = new Scene(root, WIDTH, HEIGHT); // set the size here
        stage.setTitle("FX GUI Template"); // set the window title here
        stage.setScene(scene);
        // TODO: Add your GUI-building code here

        // 1. Create the model
         c1 = new Circle(WIDTH/2,HEIGHT/2,10);
        // 2. Create the GUI components
        Canvas c = new  Canvas(WIDTH,.6*HEIGHT);
         gc = c.getGraphicsContext2D();
         field1 = new TextField("10");

        Button b1 =  new Button("b1");
        // 3. Add components to the root
        root.getChildren().addAll(field1,b1,c);
        // 4. Configure the components (colors, fonts, size, location)
       field1.relocate(100,HEIGHT * .6 + 10);
        b1.relocate(10,HEIGHT * .6 + 10);
        b1.setOnAction(this::myHandler);
        // 5. Add Event Handlers and do final setup

        // 6. Show the stage
        gc.setFill(Color.WHITE);
        gc.fillRect(0,0,WIDTH,HEIGHT);
        stage.show();
    }


    /**
     * Make no changes here.
     *
     * @param args unused
     */
    public static void main(String[] args) {
        launch(args);
    }
}
