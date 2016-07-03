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
$tblCustomer = new ajaxCRUD("Step",
                             "steps", "id");

# don't show the primary key in the table
#$tblCustomer->omitPrimaryKey();


# my db fields all have prefixes;
# display headers as reasonable titles
$tblCustomer->displayAs("id", "Step ID");
$tblCustomer->displayAs("set_text", "Set Text");
$tblCustomer->displayAs("options", "Options (Comma Separated)");
$tblCustomer->displayAs("options_steps", "Options Step IDs (Comma Separtated)");
$tblCustomer->displayAs("yesbtn_text", "Yes Button Label");
$tblCustomer->displayAs("nobtn_text", "No Button Label");
$tblCustomer->displayAs("show_edit", "Show Edit");
$tblCustomer->displayAs("yes_next_step", "Yes Button Next Step ID (0 Hides Button)");
$tblCustomer->displayAs("no_next_step", "No Button Next Step ID (0 Hides Button)");
$tblCustomer->displayAs("set_fields_id", "Set Fields ID (For -1 Step ID)");
$tblCustomer->displayAs("prev_step", "Previous Step ID (-999 hides Go Back Button)");

# set width
$tblCustomer->setTextareaHeight("set_text",50);

# add the filter box (above the table)
$tblCustomer->addAjaxFilterBox("id");
$tblCustomer->addAjaxFilterBox("set_text");

# sort the table
$tblCustomer->orderFields("id,set_text,show_edit,options,options_steps,yesbtn_text,yes_next_step,nobtn_text,no_next_step,set_fields_id,prev_step");

# actually show to the table
$tblCustomer->showTable();

?>