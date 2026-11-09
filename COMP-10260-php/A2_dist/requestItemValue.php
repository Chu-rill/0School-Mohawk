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


$shop = filter_input(INPUT_GET, "shop" ,FILTER_VALIDATE_INT);
$id = filter_input(INPUT_GET, "id" ,FILTER_VALIDATE_INT);

if($shop === null || $id == null){
    echo "Invalid data";
    return;
}

if ($shop === 0) {
    $row = 0;
} else if ($shop === 1) {
    $row = 1;
} else {
    $row = 2;
}

$col = $id - 1;

$fh = fopen("itemValues.csv","r");

for ($i = 0; $i < $row; $i++) {
    fgetcsv($fh);
}
$values = fgetcsv($fh);
fclose($fh);

if ($id === null || $id === false || !isset($values[$col])) {
    echo 0;
} else {
    echo (int) $values[$col];
}
?>
