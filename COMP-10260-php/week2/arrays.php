<?php

$x =  [1,2,3,4,5,6];

$x["food"] = "good";

unset($x[2]);

echo json_encode($x);

echo json_encode(array_values($x));

?>