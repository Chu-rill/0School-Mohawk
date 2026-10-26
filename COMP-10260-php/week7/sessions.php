<?php

session_start();

echo json_encode($_SESSION);

// $_SESSION["x"] = 5;

if(!isset($_SESSION["count"])){
    $_SESSION["count"] = 0;
}else{
    $_SESSION["count"] ++;    
}



?>