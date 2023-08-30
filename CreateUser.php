<?php
$servername = "localhost";
$username = "root";
$password = "usbw";
$dbname = "fia4db";

//variables submitted by user
$givenEmail = $_POST["email"];
$givenUsername = $_POST["username"];
$givenPass = $_POST["password"];

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// $sql = "SELECT * FROM userdata WHERE PlayerEmail = '".$givenEmail."'"
// $result = $conn->query($sql)



// if($result->num_rows > 0){
//     $createAccount = false;
// } else if ($result->num_rows == 0){
//     $createAccount = true;
// }

// if($createAccount == true){
    $sql = "INSERT INTO userdata(PlayerEmail, Username, Password) VALUES ('".$givenEmail."', '".$givenUsername."', '".$givenPass."')" ;
    $result = $conn->query($sql);
// } else if($createAccount == false){
//     echo("account already exists")
// }

$conn->close();
?>