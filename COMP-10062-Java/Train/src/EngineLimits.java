/**
 * An interface for anything that is able to pull a train. It requires the
 * ability to work out how long it takes to accelerate a given weight to
 * 100 km/h.
 *
 * Statement of Authorship: I, Churchill Daniel, 000983683, certify
 * that this work is my own work and that I did not consult external resources
 * including artificial intelligence software to complete this assignment without
 * due acknowledgement. I further certify that I did not provide my solution to
 * any other students, nor will I provide it to future students taking this
 * course at a later date.
 *
 * @author Churchill Daniel
 */
public interface EngineLimits {
    /**
     * Works out how long it takes to accelerate a weight to 100 km/h.
     * @param weight the total weight (in tonnes) to be accelerated
     * @return the time in seconds to reach 100 km/h
     **/
    public abstract double getTime100Kph(double weight);
}
