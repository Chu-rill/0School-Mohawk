<?php

$ants = filter_input(INPUT_GET, "ants" ,FILTER_SANITIZE_SPECIAL_CHARS);

echo $ants;

?>
