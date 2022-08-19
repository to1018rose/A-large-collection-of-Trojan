<?php
$password = ""; //Your password, same in the client
$host = ""; //Your host for MySql
$username = ""; //Username for MySql
$dbpassword = ""; //Password for MySql
$dbname = ""; //Database name in MySql
$dctimeout = 10; //Timeout in seconds

if($_REQUEST['PASSWORD'] != $password)
	die("Wrong password!");

$sql = mysqli_connect($host,$username,$dbpassword,$dbname);
?>