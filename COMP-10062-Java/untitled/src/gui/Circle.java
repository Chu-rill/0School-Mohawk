package gui;

import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

public class Circle {
    public double radius;
    public int x;
    public int y;

    public void setRadius(double radius) {
        this.radius = radius;
    }

    public Circle(int x, int y, double radius){
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public void draw(GraphicsContext gc){
        gc.setStroke(Color.BLACK);
        gc.setLineWidth(radius /2);
        gc.strokeOval(x-radius,y-radius,radius*2,radius*2);
    }

    public void drawwt(GraphicsContext gc){
        gc.setStroke(Color.WHITE);
        gc.setLineWidth( radius / 2 + 5);
        gc.strokeOval(x-radius,y-radius,radius*2,radius*2);
    }
}
