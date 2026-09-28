<h2>File I/O</h2>
<?php

// r-read
// w-write(over-write removes what was there)
// a-append adds to a file but doesn't remove existing content
$file = fopen('hello.txt','r'); 

$file2 = fopen('numbers.txt','r');

$sum = 0;

while( !feof($file2)){
    
    $sum += (int) fgets($file2);


}
echo $sum;


fclose($file2);

?>