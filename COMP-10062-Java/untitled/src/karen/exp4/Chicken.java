package karen.exp4;

public class Chicken implements Edible,Catchable,Animal {
    @Override
    public String howToEat() {
        return "Chicken; Fry it";
    }

    @Override
    public String howToCatch() {
        return "Chase it";
    }

    @Override
    public String sound() {
        return "Yike";
    }
}
