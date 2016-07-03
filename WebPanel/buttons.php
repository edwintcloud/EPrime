<?php
session_start();
if(empty($_SESSION['login_user'])|| $_SESSION['role'] != 1)
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
$tblCustomer = new ajaxCRUD("Button",
                             "buttons", "id");

# don't show the primary key in the table
#$tblCustomer->omitPrimaryKey();


# my db fields all have prefixes
# display headers as reasonable titles
$tblCustomer->displayAs("id", "Button");
$tblCustomer->displayAs("label", "Button Label");
$tblCustomer->displayAs("visible", "Is Visible");
$tblCustomer->displayAs("stepid", "Troubleshooting Step ID");

# read only
$tblCustomer->disallowDelete();
$tblCustomer->disallowAdd();
$tblCustomer->turnOffSorting();
#$tblCustomer->cellspacing = 0;

# actually show to the table
$tblCustomer->showTable();

?>