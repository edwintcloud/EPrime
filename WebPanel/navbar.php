<!DOCTYPE html>
<html lang="en">
<head>
<title>EPrime Admin Panel</title>
<link rel="stylesheet"
  href="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css">
<link rel="stylesheet"
  href="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap-theme.min.css">
<script
  src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
<script
  src="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
</head><!-- w  ww  . j  a  v a2  s  .c o  m-->
  <body style='margin:0px'>
    <div class="navbar navbar-default">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" 
                        class="navbar-toggle"
                        data-toggle="collapse" 
                        data-target="#mynavbar-content">
                    <span  class="icon-bar"></span>
                    <span  class="icon-bar"></span>
                    <span  class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="tickets.php">EPrime Admin Panel</a>
            </div>
            <div class="collapse navbar-collapse" id="mynavbar-content">
                <ul class="nav navbar-nav">
		<?php

		$current = basename($_SERVER['PHP_SELF']);

		if($current == "tickets.php") {
                    echo('<li class="active"><a href="tickets.php">Tickets</a></li>');
		}else {
			echo('<li><a href="tickets.php">Tickets</a></li>');
		}
		if($_SESSION['role'] == 1) {
		if($current == "buttons.php") {
                    echo('<li class="active"><a  href="buttons.php">Edit Buttons</a></li>');
		}else {
			echo('<li><a  href="buttons.php">Edit Buttons</a></li>');
		}
		if($current == "steps.php") {
                    echo('<li class="active"><a  href="steps.php">Edit Troubleshooting Steps</a></li>');
		}else {
			echo('<li><a  href="steps.php">Edit Troubleshooting Steps</a></li>');
		}
		if($current == "fields.php") {
                    echo('<li class="active"><a  href="fields.php">Edit Set Fields</a></li>');
		}else {
			echo('<li><a  href="fields.php">Edit Set Fields</a></li>');
		}
		}
		if($current == "errors.php") {
                    echo('<li class="active"><a  href="errors.php">View Program Errors</a></li>');
		}else {
			echo('<li><a  href="errors.php">View Program Errors</a></li>');
		}

		?>
                </ul>
		<ul class="nav navbar-nav navbar-right">
                	<li><a href="logout.php">Logout</a></li>
            </ul>
            </div>
        </div>
    </div>


  </body>
</html>
