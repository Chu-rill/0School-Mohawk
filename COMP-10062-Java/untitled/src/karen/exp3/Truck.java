package karen.exp3;

public class Truck extends Vehicle{
    public Truck(int horsePower) {
        super(horsePower);
    }

    public int getRacingSpeed(){
        return super.getHorsePower()/3;
    }
}
