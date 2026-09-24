<h3>Calculator</h3>

<form action="calc.php" method="post">
    <input type="text" name="x" placeholder="x">
    <input type="text" name="sign" placeholder="sign">
    <input type="text" name="y" placeholder="y">
   
    <input type="submit" value="Submit">
</form>

<?php
$x = filter_input(INPUT_POST,"x",FILTER_VALIDATE_INT);
$y = filter_input(INPUT_POST,"y",FILTER_VALIDATE_INT);
$sign = filter_input(INPUT_POST,"sign",FILTER_SANITIZE_SPECIAL_CHARS);

if($x == null || $y == null || $sign == null){
    echo "Invalid operation";
    exit(0);
}

if($sign == "+"){
    echo $x + $y;
}elseif($sign == "-"){
    echo $x - $y;
}


?>