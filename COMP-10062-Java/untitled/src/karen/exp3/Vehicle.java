package karen.exp3;

public class Vehicle {
    private int horsePower;

    public Vehicle(int horsePower) {
        this.horsePower = horsePower;
    }

    public int getRacingSpeed() {
        return horsePower;
    }

    public int getHorsePower() {
        return horsePower;
    }

    public boolean raceAgainst(Vehicle v){
        if (this.getRacingSpeed() > v.getRacingSpeed()){
            return true;
        }
        return false;
    }
}
