<?php
session_start();
if(empty($_SESSION['login_user']))
{
header('Location: index.php');
}

?>

<?php
# include this file at the very top of your script
require_once('preheader.php');

#include('navbar.php');

# the code for the class
include ('ajaxCRUD.class.php');

# this one line of code is how you implement the class
$tblCustomer = new ajaxCRUD("Errors",
                             "errors", "id");

# don't show the primary key in the table
$tblCustomer->omitPrimaryKey();


# my db fields all have prefixes;
# display headers as reasonable titles
$tblCustomer->displayAs("computername", "Computer Name");
$tblCustomer->displayAs("user", "Username");
$tblCustomer->displayAs("error", "Error Details");

# add the filter box (above the table)
#$tblCustomer->addAjaxFilterBox("");

# sort the table
#$tblCustomer->orderFields("computername,user,error");

# omit fields
#$tblCustomer->omitFieldCompletely('ssn');

# read only
$tblCustomer->turnOffAjaxEditing();
if($_SESSION['role'] != 1) $tblCustomer->disallowDelete();
$tblCustomer->disallowAdd();

# actually show to the table
$tblCustomer->showTable();

?>