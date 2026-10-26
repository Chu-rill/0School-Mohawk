<?php
// I Churchill Daniel, 000983683, certify that this material is my original work.
// No other person's work has been used without suitable acknowledgment and I have not made my work available to anyone else.
/**
 * Accepts a GET parameter "shop" containing a number and outputs
 * a json file associated with it.
 *
 * @author Churchill Daniel
 * @version 202635.00
 * @package COMP 10260 Assignment 2
 */


$files = ["Shop1.json", "Shop2.json", "Shop3.json"];

$shop = filter_input(INPUT_GET, "shop" ,FILTER_VALIDATE_INT);

if ($shop === null || $shop === false) {
    $shop = 0;
}

readfile($files[$shop]);
?>
