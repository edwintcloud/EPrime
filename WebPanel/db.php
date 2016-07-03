<?php
define('DB_SERVER', 'eprime.duckdns.org');
define('DB_USERNAME', 'admin');
define('DB_PASSWORD', 'admin123');
define('DB_DATABASE', 'eprime');
$db = mysqli_connect(DB_SERVER,DB_USERNAME,DB_PASSWORD,DB_DATABASE);
?>