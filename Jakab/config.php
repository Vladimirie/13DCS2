<?php

$server = "localhost";
$username = "root";
$password = "";

try {
    $db = new PDO("mysql:host=$server;dbname=13dcs2", $username, $password);
    $db -> setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch (PDOexception $e) {
    echo $e->getMessage(); 
}