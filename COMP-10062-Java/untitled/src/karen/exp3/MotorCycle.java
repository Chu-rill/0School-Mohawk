package karen.exp3;

public class MotorCycle extends Vehicle{
    public MotorCycle(int horsePower) {
        super(horsePower);
    }

    public int getRacingSpeed(){
        return (int) (super.getHorsePower()*1.5);
    }
}
