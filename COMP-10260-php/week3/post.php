<h3>POST example</h3>

<form action="post.php" method="post">
    <label for="user">Username</label>
    <input type="text" name="user" id="user">
    <label for="pass">Password</label>
    <input type="password" name="pass" id="pass">
    <input type="submit" value="Submit">
</form>

<?php

$user = filter_input(INPUT_POST,"user",FILTER_SANITIZE_SPECIAL_CHARS);
$pass = filter_input(INPUT_POST,"pass",FILTER_SANITIZE_SPECIAL_CHARS);

$secret_user = "MrKrabs";
$secret_pass = "money";

if($user == null || $pass == null){
    echo "this was not a login attmept";
    exit(0);
}

if($user == $secret_user && $pass == $secret_pass){
    echo "Login Succesful";
}else{
    echo "Login Failed";
}



?>