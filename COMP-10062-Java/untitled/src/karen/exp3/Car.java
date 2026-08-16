package karen.exp3;

public class Car extends Vehicle {
    public Car(int horsePower) {
        super(horsePower);
    }

    public int getRacingSpeed(){
        return super.getHorsePower()/2;
    }
}
