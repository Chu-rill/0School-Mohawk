<?php
$fh = fopen("data.csv","r");

while(!feof($fh)){
    $line = fgets($fh);
    echo $line;
}

fclose($fh);

?>