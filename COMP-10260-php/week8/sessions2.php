<h1>Session Example</h1>
<?php

session_start();

echo "before: " . json_encode($_SESSION) . "<br>";

// $_SESSION = [];
session_unset();

echo "after: " . json_encode($_SESSION) . "<br>";


?>