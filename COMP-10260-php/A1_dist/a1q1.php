<?php
/**
 * Accepts a GET parameter "ants" containing only the characters
 * 'R' (red ant travelling left), 'B' (black ant travelling right)
 * and 'X' (empty space), and outputs the outcome of the battle.
 *
 * @author Churchill Daniel
 * @version 202635.00
 * @package COMP 10260 Assignment 1
 */

$ants = filter_input(INPUT_GET, "ants" ,FILTER_SANITIZE_SPECIAL_CHARS);



if ($ants === null){
    echo "Invalid parameter";
}else{
    $marchingBlack = 0;          
    $redReachedLeft = false;

    $length = str_split($ants);

    for($i = 0; $i < count($length); $i++){
        if($length[$i] === 'B'){
            $marchingBlack++;
        }elseif ($length[$i] === 'R'){
            if ($marchingBlack > 0) {
                $marchingBlack--;        // red and black ant kill each other
            } else {
                $redReachedLeft = true;  // nothing stops this red ant
            }
        }
    }

    $blackReachedRight = $marchingBlack > 0;
 
    if ($redReachedLeft && $blackReachedRight) {
        echo "M.A.D.";
    } elseif ($redReachedLeft) {
        echo "Red Wins";
    } elseif ($blackReachedRight) {
        echo "Black Wins";
    }
    echo "Neither";
}

?>
