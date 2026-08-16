package OOP;

public class Tv {
    private int channel = 2;//range between 2-13
    private int volume = 5;//between 0-100
    private boolean on = false;
    public String name = "paul";

    public int setChannel(int ch){
        this.channel = ch;
        return channel;
    }

}
