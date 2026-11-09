<?php


try {
   $dbh = new PDO("mysql:host=localhost;dbname=week10","root", "");
} catch (Exception $e) {
   die("ERROR: Couldn't connect. {$e->getMessage()}"); 
   // using die should be avoided in production code
}

?>