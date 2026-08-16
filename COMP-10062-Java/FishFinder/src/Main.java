/**
 * The Main class this is the access point and passes the gc to the other classes
 * @author Churchill Daniel
 */
import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.stage.Stage;

public class Main extends Application {


    @Override
    public void start(Stage stage) {
        Group root = new Group();
        Scene scene = new Scene(root);
        Canvas canvas = new Canvas(520, 360);
        stage.setTitle("Fish Finder");
        root.getChildren().add(canvas);
        stage.setScene(scene);
        GraphicsContext gc = canvas.getGraphicsContext2D();

        FishFinder fishFinder = new FishFinder(520, 360);
        fishFinder.draw(gc);

        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}