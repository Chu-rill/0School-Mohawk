<h2>File I/O</h2>
<?php

// r-read
// w-write(over-write removes what was there)
// a-append adds to a file but doesn't remove existing content

// filter input is null when the arg is missing
$file = fopen('hello.txt','r'); 

$file2 = fopen('numbers.txt','r');



while( !feof($file)){
    
    // $sum += (int) fgets($file2);

    echo filter_var(fgets($file),FILTER_SANITIZE_SPECIAL_CHARS);

    // echo fgets($file) . "<br>";


}



fclose($file2);

?>