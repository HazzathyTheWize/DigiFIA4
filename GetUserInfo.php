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

$sql = "SELECT id, username, email, password FROM users";
$result = $conn->query($sql);


if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
        echo "ID: " . $row["id"]. " | Username: " . $row["username"]. " | Password: " . $row["password"]." | Email: " . $row["password"]. "<br>";
    }
} else {
    echo "0 results";
}



$conn->close();
?>