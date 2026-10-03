/**
 * Google java style guide rules applied
 * 4.1.2 Nonempty blocks: K & R style
 * 4.2 Block indentation: +2 spaces (adjusted to +4 spaces for this assignment)
 * 4.4 Column limit: 100
 * 4.6.1 Vertical Whitespace
 * 4.6.2 Horizontal whitespace
 * 4.8.6.1 Block comment style
 * 5.2.3 Method names
 * 5.2.6 Parameter names
 * 5.2.7 Local variable names
 * 7.1.1 General form
 * 7.1.2 Paragraphs
 * 7.1.3 Block tags
 * 7.2 The summary fragment
 * 7.3 Where Javadoc is used
 */

import java.util.ArrayList;
import java.util.Collections;
/**
 * Library of Statistical Calculations
 * Includes functions for finding the minimum value, maximum value, median value
 and the mean
 */
public class StatisticalLibrary {

    /**
     * Calculate the average value of elements in a list
     *
     * @param values the list of doubles to find the average
     * @param minValue the smallest value to include when cutOff is set to true
     * @param cutOff exclude values bellow minValue
     * @return returns the mean of  the values greater than the minValue
     */
    public static double calculateMean(ArrayList<Double> values, double minValue, boolean cutOff){
        double sum = 0;
        int count = 0;

        for (double value : values) {

            if (!cutOff || value >= minValue) {
                sum += value;
                count++;
            }

        }

        return sum/count;
    }

    /**
     *Calculate the middle value of elements in a list
     *
     * @param values the array of double values to find the median value
     * @return the median value
     */
    public static double calculateMedian(ArrayList<Double> values){
        int medianValue = values.size() / 2;

        if (values.size() % 2 == 1) {
            return values.get(medianValue);
        }

        return (values.get(medianValue - 1) + values.get(medianValue)) / 2;
    }


    /**
     * Finds the smallest value in a list
     *
     * @param values the list of doubles
     * @return the minimum value in the list
     */
    public static double findMinimum(ArrayList<Double> values){
        double minimumValue = values.get(0);

        for (double value : values) {
            if (value < minimumValue) {
                minimumValue = value;
            }
        }

        return minimumValue;
    }

    /**
     * Finds the largest value in a list
     *
     * @param values the list of doubles
     * @return the maximum value in the list
     */
    public static double findMaximum(ArrayList<Double> values){
        double maximumValue = values.get(0);

        for (double value : values) {
            if (value > maximumValue) {
                maximumValue = value;
            }
        }

        return maximumValue;
    }

    /**
     * Runs each method on a sample data set and prints the results.
     *
     * @param args (unused)
     */
    public static void main(String[] args) {
// Use code here to understand what each method does to help with your code improvement
        ArrayList<Double> data = new ArrayList<>();
        Collections.addAll(data,25.5, 29.4, 36.7, 43.1, 57.9, 88.3, 99.9, 100.0 );
        System.out.println("calculateMean: " + calculateMean(data, 0, true));
        System.out.println("calculateMedian: " + calculateMedian(data));
        System.out.println("findMinimum: " + findMinimum(data));
        System.out.println("findMaximum: " + findMaximum(data));
    }
}