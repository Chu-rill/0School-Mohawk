<?php



$shop = filter_input(INPUT_GET, "shop" ,FILTER_VALIDATE_INT);
$id = filter_input(INPUT_GET, "id" ,FILTER_VALIDATE_INT);

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
