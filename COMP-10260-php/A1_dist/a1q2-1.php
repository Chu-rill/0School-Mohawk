<?php
/**
 * Accepts a POST parameter "n" containing a number and outputs
 * an ordered list of every number that divides it evenly.
 *
 * @author Churchill Daniel
 * @version 202635.00
 * @package COMP 10260 Assignment 1
 */

$n = filter_input(INPUT_POST, "n", FILTER_VALIDATE_INT);

if ($n === null) {
    echo "Invalid parameter";
} elseif ($n < 0) {
    echo "Negative numbers are not allowed";
} elseif ($n === 0) {
    echo "0 is not a natural number";
} else {
    $factors = [1];
    for ($i = 2; $i <= intdiv($n, 2); $i++) {
        if ($n % $i === 0) {
            $factors[] = $i;
        }
    }
    if ($n > 1) {
        $factors[] = $n;
    }

    $html = "<ol>";
    foreach ($factors as $factor) {
        $html .= "<li>" . $factor . "</li>";
    }
    echo $html . "</ol>";
}
?>