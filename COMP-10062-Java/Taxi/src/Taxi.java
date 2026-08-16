/**
 * program here, and the date it was created.
 *A Java class simulating a taxi driver's workday, tracking gas, location, and earnings across short, medium, and long rides.
 * The driver automatically goes off duty when earnings reach $200 or gas runs too low.
 * May 26, 2026
 * Statement of Authorship: I, Churchill Daniel 000983683, certify
 * that this work is my own work and that I did not consult external resources
 * including artificial intelligence software to complete this assignment without
 * due acknowledgement. I further certify that I did not provide my solution to
 * any other students, nor will I provide it to future students taking this
 * course at a later date.
 *
 * @author Churchill Daniel
 **/
public class Taxi {
    /** Starting gas level in liters. */
    private  int gas = 20;
    /** Default starting street. */
    private String street = "MainSt";
    /** Default starting city. */
    private String city = "SimpleCity";
    /** state ranging from 1-3 for waiting for customer(1),waiting for tip(2),off duty(3) */
    private int state = 1;
    /**range for ride type 1-3 for short ride(1),medium ride(2),long ride(3)*/
    private int rideType = 1;
    /** Driver's name. */
    private String driverName;
    /** Total cash earned */
    private int cash = 0;

    /**
     * this is the main method for the code
     * @param destCity   destination city name
     * @param destStreet destination street name
     * @return a string based on the state
     */
    public String newRide(String destStreet,String destCity){
        if (this.state != 1){
            return "Driver is not available";

        }
        //Determine the type of ride
        this.rideType = checkRideType(destCity,destStreet);

        int gasUsed = calculateGasUsed(rideType);
        if (this.gas - gasUsed <=0){
            this.gas = 0;
            goOffDuty();
            return "Not enough Gas for the trip";
        }
        //deduct gas used
        this.gas -= gasUsed;
        //update location
        this.city = destCity;
        this.street = destStreet;

        int rate = getRate(rideType);
        this.cash += rate;

        if (rideType == 3){
            checkLimit();
            return "Thanks for the trip, will cost you $"+ rate;
        }
        //set state to waiting for tips on short or medium rides
        state = 2;
        checkLimit();
        return "Thanks for the trip, will cost you $"+ rate;
    }

    /**
     * after the user end's their ride the use this public method to tip the driver
     * @param amount int for the amount to be giving
     * @return a string to respond to the view based on the state
     */
    public String payTip(int amount){
        if (state != 2){
            return "Not waiting for tip";

        }
        if (rideType == 3){
           return "Tip included for long rides";

        }
        if (amount < 0){
          return "Negative numbers not allowed";
        }
        cash += amount;
        state = 1;
        checkLimit();
        return "Thanks for the tip";
    }

    /**
     * a void method that sets the driver name
     * @param name a string for the driver name
     */
    public void setDriverName(String name){
        this.driverName = name;
    }



    /**
     *Calculates gas consumed for a ride
     * @param rideType ranging from 1-3 for short to long rides
     * @return gas used in integer
     */
    private int calculateGasUsed(int rideType){
        if (rideType == 1){
            return (int) (2 + Math.random()*2);
        } else if (rideType == 2) {
            return (int) (3 + Math.random()*3);
        }else {
            return (int) (7 + Math.random()*5);
        }
    }


    /**
     * a public method that implements the goOffDuty method allowing the view to access the method
     * @return a string message based on the state
     */
    public String setOffDuty() {
        if (state != 1) {
            return "Can't go off duty";
        }
        goOffDuty();
        return "Taxi is off duty";
    }

    /**
     * a void method that sets the driver state to be off duty
     */
    private void goOffDuty(){
        state = 3;
    }

    /**
     * Determines the distance of the ride
     * @param destCity   destination city name
     * @param destStreet destination street name
     * @return an integer between 1-3 for the ride type
     */
    private int checkRideType(String destCity,String destStreet){
        if (!destCity.equalsIgnoreCase(this.city)){
            rideType = 3;//long
        } else if (destStreet.length() <= 8) {
            rideType = 1;//short
        }else {
            rideType = 2;//medium
        }
        return rideType;
    }

    /**
     * Assigns a value for the cost of the trip based on the ride type integer
     * @param rideType integer between 1-3
     * @return an integer for the cost of the trip
     */
    private int getRate(int rideType){
        if (rideType == 1){
            return 10;//the cost for a short trip
        } else if (rideType == 2) {
            return 20;//the cost for a medium trip
        }else {
            return 50;//the cost for a long trip
        }
    }

    /**
     * a private void method that checks if the driver as gotten the max sum for the day or as little fuel
     */
    private void checkLimit(){
        if (cash >= 200 || gas < 4) {
            goOffDuty();
        }
    }

    /**
     * this is a method that overwrites the built-in toString
     * @return formatted string
     */
    @Override
    public String toString(){
        String displayState;
        if (state == 1){
            displayState = "Waiting for customer";
        } else if (state == 2) {
            displayState = "Waiting for tip";
        }else {
            displayState = "Off duty";
        }
        return driverName + "'s Taxi:gas=" + gas + " l, $=" + cash
                + ", " + this.street + ", city=" + this.city
                + ": " + displayState;

    }

}
