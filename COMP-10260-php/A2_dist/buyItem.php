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
$gold = filter_input(INPUT_GET, "gold" ,FILTER_VALIDATE_INT);

if($shop === null || $id === null || $gold === null){
    $data = [
    "success"  => false,
    "message" => htmlspecialchars("I don't understand what you're asking for.", ENT_QUOTES, "UTF-8"),
    "gold" => 0,
    "item"    => null,
    "debug"   => "Bad input"
];

echo json_encode($data);
exit;
}

$files = ["Shop1.json", "Shop2.json", "Shop3.json"];

$file = $files[$shop];
$inventory = json_decode(file_get_contents($file), true);

$index = null;
for ($i = 0; $i < count($inventory); $i++) {
    if ($inventory[$i]["id"] == $id) {
        $index = $i;
        break;
    }
}

if($index === null){
    $data = [
    "success"  => false,
    "message" => htmlspecialchars("We don't have that sorry.", ENT_QUOTES, "UTF-8"),
    "gold" => 0,
    "item"    => null,
    "debug"   => "Bad input"
];

echo json_encode($data);
exit;
}

$item = $inventory[$index];
$price = (int) $item["price"];

if($gold < $price){
    $data = [
    "success"  => false,
    "message" => htmlspecialchars("You don't have enough money for that.", ENT_QUOTES, "UTF-8"),
    "gold" => $gold,
    "item"    => null,
    "debug"   => "Bad input"
];

echo json_encode($data);
}

$gold -= $price;
$inventory[$index]["quantity"] = (int) $item["quantity"] - 1;

if ($inventory[$index]["quantity"] <= 0) {
    unset($inventory[$index]);
    $inventory = array_values($inventory);
}

file_put_contents($file,json_encode($inventory));

unset($item["price"], $item["quantity"]);

$item["name"] = htmlspecialchars($item["name"], ENT_QUOTES, "UTF-8");
$item["description"] = htmlspecialchars($item["description"], ENT_QUOTES, "UTF-8");

$data = [
    "success" => true,
    "message" => "Pleasure doing business! Enjoy your " . $item["name"] . ".",
    "gold"    => $gold,
    "item"    => $item,
    "debug"   => "Bought" . $item["description"] . " $id from $file for $price gold"
];

echo json_encode($data);

?>
