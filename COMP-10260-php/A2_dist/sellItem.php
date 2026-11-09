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


$shop = filter_input(INPUT_POST, "shop" ,FILTER_VALIDATE_INT);
$item = json_decode(filter_input(INPUT_POST, "item"),true); // i don't know how i would filter a json input
$gold = filter_input(INPUT_POST, "gold" ,FILTER_VALIDATE_INT);

if($gold === null || $shop === null || $item === null || !isset($item["id"], $item["name"], $item["price"])){
    $data = [
    "success"  => false,
    "message" => htmlspecialchars("Error selling.", ENT_QUOTES, "UTF-8"),
    "gold" => 0,
    "item"    => null,
    "debug"   => "Bad input"
];

echo json_encode($data);
exit;
}

$files = ["Shop1.json", "Shop2.json", "Shop3.json"];


$id    = (int) $item["id"];
$price = (int) $item["price"];

$file = $files[$shop];
$inventory = json_decode(file_get_contents($file), true);

$found = false;
for ($i = 0; $i < count($inventory); $i++) {
    if ($inventory[$i]["id"] == $id) {
        $inventory[$i]["quantity"] = $inventory[$i]["quantity"] + 1;
        $found = true;
        break;
    }
}

if ($found == false) {
    $inventory[] = [
        "id"          => $id,
        "name"        => $item["name"],
        "description" => $item["description"],
        "price"       => $price * 2,
        "quantity"    => 1
    ];
}

file_put_contents($file, json_encode($inventory));

$gold = $gold + $price;

$data = [
    "success" => true,
    "message" => htmlspecialchars("A fine " . $item["name"] . "! Here's $price gold for it.", ENT_QUOTES, "UTF-8"),
    "gold"    => $gold,
    "debug"   => "Sold item $id to $file for $price gold"
];

echo json_encode($data);
?>
