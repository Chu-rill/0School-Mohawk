<?php
$fh = fopen("data.csv","r");

$data = [];

$bellow = [];

$line = fgets($fh);

while(!feof($fh)){
    
    $line = fgetcsv($fh);
    // $line = explode(",",$line);
    // echo $line[0] . " " . $line[1] . " " . $line[2] . "<br>";
    array_push($data,$line);
}

for($i = 0; $i < count($data); $i++){
    if($data[$i][2] < 75){
        array_push($bellow,$data[$i]);
    }
}

// echo json_encode($data);
echo json_encode($bellow);

fclose($fh);

?>