/**
 * The FishFinder class draws it draws a school of fishes
 * it also calls the school draw in the FishFinder draw method
 * display's the total number of fishes found
 * @author Churchill Daniel
 */
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;
import javafx.scene.text.Font;
public class FishFinder {
    //size of the screen in the x position
    private double maxX;
    //size of the screen in the y position
    private double maxY;

    //variables of the School object type
     School school1;
     School school2;
     School school3;

    /**
     * The FishFinder constructor to set the field values and to make new School class instances
     * @param maxX double
     * @param maxY double
     */
    public FishFinder(double maxX, double maxY) {
        this.maxX = maxX;
        this.maxY = maxY;

         school1 = new School(30, 70,  "Anchovy");
         school2 = new School(80, 165, "Salmon");
         school3 = new School(170, 260, "Dolphin");
    }

    public void draw(GraphicsContext gc) {
        // Pond background.
        gc.setFill(Color.LIGHTBLUE);
        gc.fillRect(0, 0, maxX, maxY);

        // Adds each individual school to get the total amount of fishes
        int total = 0;
        total += school1.getCount();
        total += school2.getCount();
        total += school3.getCount();

        gc.setFill(Color.BLACK);
        gc.setFont(Font.font(14));
        gc.fillText("Total fish found: " + total, 12, 22);

        school1.draw(gc);
        school2.draw(gc);
        school3.draw(gc);
    }
}
