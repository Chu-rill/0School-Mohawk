/**
 * Bugs found in the SetLibrary class and how to fix them
 *
 * 1st Bug: createSet makes an infinite loop when size is 0
 *      Test case: testCreateSetSizeZero
 *      Fix line 24: boolean filled = (size == 0);
 *
 * 2nd Bug: createSet never generates the maximum value. Math.random() * (maximum - minimum)
 *          only reaches maximum - 1.
 *      Test case: testCreateSetIncludesMaximum
 *      Fix line 41:
 *          int randomInteger = (int) (Math.random() * (maximum - minimum + 1)) + minimum
 *
 * 3rd Bug: createSet rejects a valid unique set. The range 1 to 3 holds 3 numbers,
 *          but maximum - minimum counts only 2, so asking for 3 unique numbers throws an error
 *      Test case: testCreateSetUniqueFullRange
 *      Fix line 34:
 *          else if(uniqueElements && maximum - minimum + 1 < size){
 *
 * 4th Bug: createSet with uniqueElements = true can add duplicates, because isUnique
 *          is overwritten on every loop, so only the last element is checked
 *      Test case: testCreateSetUniqueHasNoDuplicates
 *      Fix line 44:
 *          for (int j = 0; j < newListSize && uniqueElements && isUnique; j++) {
 *
 * 5th Bug: isSetUnique uses != on Integer objects, which compares references,
 *          so large duplicate values are not detected.
 *      Test case: testIsSetUniqueLargeDuplicates
 *      Fix line 76:
 *          isUniqueflag = !arraySet.get(i).equals(arraySet.get(j));
 *
 * 6th Bug: createIntersection does not throw an exception when setB is empty.
 *      Test case: testCreateIntersectionEmptySetB
 *      Fix line 96:
 *          if (setA == null || setB == null || setA.size() == 0 || setB.size() == 0) {
 *
 * 7th Bug: createIntersection uses == on Integer objects, which compares references,
 *          so common large values are not found
 *      Test case: testCreateIntersectionLargeValues
 *      Fix line 102:
 *          if (setA.get(i).equals(setB.get(j))) {
 *     Fix line 105:
 *          if (setA.get(i).equals(setCommon.get(k))) {
 *
 * 8th Bug: isSubSet uses == on Integer objects, which compares references,
 *          so large values never match
 *      Test case: testIsSubSetLargeValues
 *      Fix line 141:
 *          if(setA.get(i).equals(setB.get(j))) {
 *
 * 9th Bug: isSubSet returns true as soon as ONE element of setB is found in setA,
 *          every element of setB must be found in setA
 *      Test case: testIsSubSetPartialOverlap
 *      Fix lines 139-146 :
 *          for (int j = 0; j < setB.size(); j++) {
 *              boolean found = false;
 *              for (int i = 0; i < setA.size(); i++) {
 *                  if (setA.get(i).equals(setB.get(j))) {
 *                      found = true;
 *                  }
 *              }
 *              if (!found) {
 *                  return false;
 *              }
 *          }
 *          return true;
 */

import org.junit.jupiter.api.Test;
import java.time.Duration;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import static org.junit.jupiter.api.Assertions.*;

class SetLibraryTest {

/* createSet method test case */

// A negative size is giving should throw an exception
    @Test
    public void testCreateSetNegativeSize() {

        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.createSet(-1, 1, 10, false));
            assertEquals("Size not a positive value!", e.getMessage());
        });

    }

//   When the minimum value is bigger than the maximum, it should throw an error in all instances
    @Test
    public void testCreateSetMinBiggerThanMax() {

        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.createSet(5, 10, 1, false));
            assertEquals("Maximum value is smaller than minimum value!", e.getMessage());
        });
    }

//  When more unique numbers than the range holds, it should throw an error
    @Test
    public void testCreateSetUniqueRangeTooSmall() {

        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.createSet(5, 1, 3, true));
            assertEquals("Range not large enough for a unique set!", e.getMessage());
        });
    }

//    When a non-unique set as the expected size and the values are within range
    @Test
    public void testCreateSetNormal() {

        int expectedSize = 20;
        ArrayList<Integer> actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.createSet(expectedSize, 10, 20, false));
        // Confirm the size is correct and every value is between 10 and 20
        assertEquals(expectedSize, actual.size());
        for (int value : actual) {

            assertTrue(value >= 10 && value <= 20);
        }
    }

//    When the minimum and maximum are the same every value should be that number
    @Test
    public void testCreateSetMinEqualsMax() {

        // https://docs.oracle.com/en/java/javase/21/docs/api/java.base/java/util/Arrays.html#asList(T...)
        ArrayList<Integer> expected = new ArrayList<>(Arrays.asList(7, 7, 7));
        ArrayList<Integer> actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.createSet(3, 7, 7, false));

        // Confirm that every value is 7
        assertEquals(expected, actual);
    }

//    a size of zero should return an empty set (1st bug)
    @Test
    public void testCreateSetSizeZero() {

        ArrayList<Integer> actual = assertTimeoutPreemptively(Duration.ofSeconds(5),
                () -> SetLibrary.createSet(0, 5, 5, true));

        // Confirm that the set is empty
        assertTrue(actual.isEmpty());
    }

//    it should be possible to generate a maximum number (2nd bug)
    @Test
    public void testCreateSetIncludesMaximum() {

        int maximum = 1;
        ArrayList<Integer> actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.createSet(500, 0, maximum, false));

        // Confirm that the maximum appears at least once in 500 random values
        assertTrue(actual.contains(maximum));
    }

//    should be able to pass 3 unique numbers from 1 to 3 (3rd bug)
    @Test
    public void testCreateSetUniqueFullRange() {

        ArrayList<Integer> expected = new ArrayList<>(Arrays.asList(1, 2, 3));
        ArrayList<Integer> actual =  assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.createSet(3, 1, 3, true));

        Collections.sort(actual);

        // Confirm that the list holds exactly 1, 2 and 3
        assertEquals(expected, actual);
    }

//    a unique set should have no duplicate values (4th bug)
    @Test
    public void testCreateSetUniqueHasNoDuplicates() {

        int expectedSize = 50;
        ArrayList<Integer> result = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.createSet(50, 0, 50, true));

        // Build a list of distinct values, skipping any repeats
        ArrayList<Integer> distinct = new ArrayList<>();
        for (Integer value : result) {

            if (!distinct.contains(value)) {
                distinct.add(value);
            }
        }

        // Confirm that all 50 values are different
        assertEquals(expectedSize, distinct.size());
    }

/* isSetUnique method test case */

//    a null set should throw an exception
    @Test
    public void testIsSetUniqueNull() {

        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.isSetUnique(null));
            assertEquals("Set cannot be null or empty!", e.getMessage());
        });
    }

//    an empty list should throw an error
    @Test
    public void testIsSetUniqueEmpty() {

        ArrayList<Integer> list = new ArrayList<>();
        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.isSetUnique(list));
            assertEquals("Set cannot be null or empty!", e.getMessage());
        });
    }

//    a set of different values should return true
    @Test
    public void testIsSetUniqueTrue() {

        ArrayList<Integer> list = new ArrayList<>(Arrays.asList(1, 2, 3));
        boolean actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.isSetUnique(list));
        assertTrue(actual);
    }

//    a set with repeated small values should return false
    @Test
    public void testIsSetUniqueFalse() {

        ArrayList<Integer> list = new ArrayList<>(Arrays.asList(1, 2, 1));
        boolean actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.isSetUnique(list));
        assertFalse(actual);
    }

//    a set with repeated large values should return false (5th bug)
    @Test
    public void testIsSetUniqueLargeDuplicates() {

        ArrayList<Integer> list = new ArrayList<>(Arrays.asList(1000, 2000, 1000));
        boolean actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.isSetUnique(list));
        assertFalse(actual);
    }

/*   createIntersection method test case */

//    a null setA should throw an exception
    @Test
    public void testCreateIntersectionNullSetA() {

        ArrayList<Integer> setB = new ArrayList<>(Arrays.asList(1,2));
        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.createIntersection(null, setB));
            assertEquals("Arraylist arguments cannot be null or empty", e.getMessage());
        });
    }

//    a null setB should throw an exception
    @Test
    public void testCreateIntersectionNullSetB() {

        ArrayList<Integer> setA = new ArrayList<>(Arrays.asList(1,2));
        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.createIntersection(setA, null));
            assertEquals("Arraylist arguments cannot be null or empty", e.getMessage());
        });
    }

//    an empty setA should throw an exception
    @Test
    public void testCreateIntersectionEmptySetA() {

        ArrayList<Integer> setA = new ArrayList<>();
        ArrayList<Integer> setB = new ArrayList<>(Arrays.asList(1,2));
        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.createIntersection(setA, setB));
            assertEquals("Arraylist arguments cannot be null or empty", e.getMessage());
        });
    }

//    an empty setB should throw an exception (6th bug)
    @Test
    public void testCreateIntersectionEmptySetB() {

        ArrayList<Integer> setA = new ArrayList<>(Arrays.asList(1,2));
        ArrayList<Integer> setB = new ArrayList<>();

        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.createIntersection(setA, setB));

            assertEquals("Arraylist arguments cannot be null or empty", e.getMessage());
        });
    }

//    shared values are returned once with no duplicates
    @Test
    public void testCreateIntersectionCommonValues() {

        ArrayList<Integer> setA = new ArrayList<>(Arrays.asList(1,1,2,3));
        ArrayList<Integer> setB = new ArrayList<>(Arrays.asList(2,1,1));
        ArrayList<Integer> expected = new ArrayList<>(Arrays.asList(1,2));

        ArrayList<Integer> actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.createIntersection(setA, setB));

        assertEquals(expected, actual);
    }

//    no common values in the set return an empty list
    @Test
    public void testCreateIntersectionNoCommonValues() {

        ArrayList<Integer> setA = new ArrayList<>(Arrays.asList(1,2));
        ArrayList<Integer> setB = new ArrayList<>(Arrays.asList(3,4));

        ArrayList<Integer> actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.createIntersection(setA, setB));

        assertTrue(actual.isEmpty());
    }

//    large shared values should be returned (7th bug)
    @Test
    public void testCreateIntersectionLargeValues() {

        ArrayList<Integer> setA = new ArrayList<>(Arrays.asList(500,600));
        ArrayList<Integer> setB = new ArrayList<>(Arrays.asList(600,700));
        ArrayList<Integer> expected = new ArrayList<>(List.of(600));

        ArrayList<Integer> actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.createIntersection(setA, setB));

        assertEquals(expected, actual);
    }

/* isSubSet method test case */

//    a null setA should throw an exception
    @Test
    public void testIsSubSetNullSetA() {

        ArrayList<Integer> setB = new ArrayList<>(Arrays.asList(1,2));

        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.isSubSet(null, setB));

            assertEquals("Arraylist arguments cannot be null or empty", e.getMessage());
        });
    }

//    a null setB should throw an exception
    @Test
    public void testIsSubSetNullSetB() {

        ArrayList<Integer> setA = new ArrayList<>(Arrays.asList(1,2));

        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.isSubSet(setA, null));


            assertEquals("Arraylist arguments cannot be null or empty", e.getMessage());
        });
    }

//    an empty setA should throw an exception
    @Test
    public void testIsSubSetEmptySetA() {

        ArrayList<Integer> setA = new ArrayList<>();
        ArrayList<Integer> setB = new ArrayList<>(Arrays.asList(1,2));

        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.isSubSet(setA, setB));

            assertEquals("Arraylist arguments cannot be null or empty", e.getMessage());
        });
    }

    //    an empty setB should throw an exception
    @Test
    public void testIsSubSetEmptySetB() {

        ArrayList<Integer> setA = new ArrayList<>(Arrays.asList(1,2));
        ArrayList<Integer> setB = new ArrayList<>();

        assertTimeout(Duration.ofSeconds(5), () -> {

            IllegalArgumentException e = assertThrows(IllegalArgumentException.class,
                    () -> SetLibrary.isSubSet(setA, setB));

            assertEquals("Arraylist arguments cannot be null or empty", e.getMessage());
        });
    }

//    setB bigger than setA should return false
    @Test
    public void testIsSubSetBiggerSetB() {

        ArrayList<Integer> setA = new ArrayList<>(Arrays.asList(1,2));
        ArrayList<Integer> setB = new ArrayList<>(Arrays.asList(1,2,3));

        boolean actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.isSubSet(setA, setB));

        assertFalse(actual);
    }

//    setB is a subset of A should return true
    @Test
    public void testIsSubSetTrue() {

        ArrayList<Integer> setA = new ArrayList<>(Arrays.asList(1,2,3));
        ArrayList<Integer> setB = new ArrayList<>(Arrays.asList(2,3));

        boolean actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.isSubSet(setA, setB));

        assertTrue(actual);
    }

//    setB has no values in setA return false
    @Test
    public void testIsSubSetNoMatch() {

        ArrayList<Integer> setA = new ArrayList<>(Arrays.asList(1,2));
        ArrayList<Integer> setB = new ArrayList<>(List.of(3));

        boolean actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.isSubSet(setA, setB));

        assertFalse(actual);
    }

//    a large setB inside a large setA should return true (8th bug)
    @Test
    public void testIsSubSetLargeValues() {
        ArrayList<Integer> setA = new ArrayList<>(Arrays.asList(1000,2000));
        ArrayList<Integer> setB = new ArrayList<>(List.of(2000));

        boolean actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.isSubSet(setA, setB));

        assertTrue(actual);
    }

    //    setB only partially in setA should return false (9th bug)
    @Test
    public void testIsSubSetPartialOverlap() {
        ArrayList<Integer> setA = new ArrayList<>(Arrays.asList(1,2,3));
        ArrayList<Integer> setB = new ArrayList<>(Arrays.asList(3,4));

        boolean actual = assertTimeout(Duration.ofSeconds(5),
                () -> SetLibrary.isSubSet(setA, setB));

        assertFalse(actual);
    }

}