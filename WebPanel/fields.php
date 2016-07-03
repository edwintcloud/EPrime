<?php
session_start();
if(empty($_SESSION['login_user']) || $_SESSION['role'] != 1)
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
$tblCustomer = new ajaxCRUD("Field",
                             "setfields", "id");

# don't show the primary key in the table
#$tblCustomer->omitPrimaryKey();


# my db fields all have prefixes;
# display headers as reasonable titles
$tblCustomer->displayAs("id", "Set Fields ID");
$tblCustomer->displayAs("subject", "Subject");
$tblCustomer->displayAs("description", "Description (Use \$number to pull edit field text)");
$tblCustomer->displayAs("resolution", "Resolution");
$tblCustomer->displayAs("lmssystem", "LMS System");
$tblCustomer->displayAs("service", "Service");
$tblCustomer->displayAs("category", "Category");
$tblCustomer->displayAs("subcategory", "Subcategory");
$tblCustomer->displayAs("priority", "Priority");
$tblCustomer->displayAs("impact", "Impact");
$tblCustomer->displayAs("urgency", "Urgency");
$tblCustomer->displayAs("cause", "Resolve Cause");
$tblCustomer->displayAs("command", "Resolve Command");

# set width
$tblCustomer->setTextareaHeight("description",50);
$tblCustomer->setTextareaHeight("resolution",50);

# add the filter box (above the table)
$tblCustomer->addAjaxFilterBox("id");
$tblCustomer->addAjaxFilterBox("subject");
$tblCustomer->addAjaxFilterBox("description");
$tblCustomer->addAjaxFilterBox("service");
$tblCustomer->addAjaxFilterBox("category");
$tblCustomer->addAjaxFilterBox("subcategory");

# actually show to the table
$tblCustomer->showTable();

?>