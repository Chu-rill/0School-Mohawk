<?php
$shop = filter_input(INPUT_GET, "shop" ,FILTER_VALIDATE_INT);
$id = filter_input(INPUT_GET, "id" ,FILTER_VALIDATE_INT);
$gold = filter_input(INPUT_GET, "gold" ,FILTER_VALIDATE_INT);


$data = [
    'success'  => 'success',
    'message' => 'Data retrieved successfully',
    'gold' => '',
    'payload' => [
        'id'   => 1024,
        'name' => 'Alex Miller'
    ]
];

?>
