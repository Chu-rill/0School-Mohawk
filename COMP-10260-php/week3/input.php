<h2>Input Example</h2>

<?php

// echo json_encode($_GET)

// if (isset($_GET['x'])){
//     echo "x exist";
// }

//$name = htmlspecialchars($_GET["name"]);

//put in cheat sheet
$name = filter_input(INPUT_GET, "name" ,FILTER_SANITIZE_SPECIAL_CHARS);

//$x = filter_input(INPUT_GET, "x" ,FILTER_SANITIZE_SPECIAL_CHARS);
$x = $_GET['x'];

if ($x == null){
    echo "error! No x was provided!";
}elseif ($x == false){
    echo "error! You sneaky person! No XSS attack";
}else{
    echo "<p>" . $x . "</p>";
}





?>