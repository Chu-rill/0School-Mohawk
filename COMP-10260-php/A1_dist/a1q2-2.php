<?php
/**
 * Accepts POST parameters "start" and "end" (whole numbers from 0 to 100,
 * with start no larger than end) and outputs an unordered HTML list of every
 * number in that range that is not divisible by any prime factor of start
 * or end.
 *
 * @author Churchill Daniel
 * @version 202635.00
 * @package COMP 10260 Assignment 1
 */

$start = filter_input(INPUT_POST, "start", FILTER_VALIDATE_INT);
$end = filter_input(INPUT_POST, "end", FILTER_VALIDATE_INT);

if($start === null || $end === null){
    echo "Invalid parameter";
}else{
    $primes = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47];

    $factors = [];
    $startIsFactor = false;
    $endIsFactor = false;

    foreach($primes as $prime){
        if ($start % $prime === 0) {
            $startIsFactor = true;
        }
        if ($end % $prime === 0) {
            $endIsFactor = true;
        }
        if ($start % $prime === 0 || $end % $prime === 0) {
            $factors[] = $prime;
        }
    }

    if ($start > 47 && !$startIsFactor) {
        $factors[] = $start;
    }
    if ($end > 47 && !$endIsFactor && $end !== $start) {
        $factors[] = $end;
    }

    echo "<ul>";
    for ($i = $start; $i <= $end; $i++) {
        $divisible = false;
        foreach ($factors as $factor) {
            if ($i % $factor === 0) {
                $divisible = true;
                break;
            }
        }
        if (!$divisible) {
            echo "<li>$i</li>";
        }
    }
    echo "</ul>";
}

?>
