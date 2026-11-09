<?php

require "connect.php";

$name = "another";
$url = "the other url";

$command = "INSERT INTO today (name, url) VALUES (?, ?)";
echo $command;
$stmt = $dbh->prepare($command);
$success = $stmt->execute([$name, $url]);

echo "record insterted";

?>