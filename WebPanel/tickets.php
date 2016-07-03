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
$tblCustomer = new ajaxCRUD("Ticket",
                             "tickets", "id");

# don't show the primary key in the table
$tblCustomer->omitPrimaryKey();


# my db fields all have prefixes;
# display headers as reasonable titles
$tblCustomer->displayAs("datetime", "Date/Time");
$tblCustomer->displayAs("useremail", "Owned By");
$tblCustomer->displayAs("incidentid", "Incident ID");
$tblCustomer->displayAs("fullname", "Full Name");
$tblCustomer->displayAs("subject", "Subject");
$tblCustomer->displayAs("description", "Description");
$tblCustomer->displayAs("resolution", "Resolution");
$tblCustomer->displayAs("service", "Service");
$tblCustomer->displayAs("category", "Category");
$tblCustomer->displayAs("subcategory", "Subcategory");
$tblCustomer->displayAs("priority", "Priority");
$tblCustomer->displayAs("impact", "Impact");
$tblCustomer->displayAs("urgency", "Urgency");
$tblCustomer->displayAs("email", "Email");
$tblCustomer->displayAs("campus", "Campus");
$tblCustomer->displayAs("ssn", "Last 4 SSN");
$tblCustomer->displayAs("courseid", "Course ID");
$tblCustomer->displayAs("lmssystem", "LMS System");
$tblCustomer->displayAs("time", "Resolution Time");
$tblCustomer->displayAs("status", "Status");
$tblCustomer->displayAs("lastaction", "Last Action");

# add the filter box (above the table)
$tblCustomer->addAjaxFilterBox("incidentid");
$tblCustomer->addAjaxFilterBox("email");
$tblCustomer->addAjaxFilterBox("useremail");


# sort the table
$tblCustomer->orderFields("datetime,incidentid,useremail,email,subject,description,courseid,lmssystem,resolution,service,category,subcategory,priority,time,status,lastaction,campus");

# omit fields
$tblCustomer->omitFieldCompletely('ssn');
$tblCustomer->omitFieldCompletely('impact');
$tblCustomer->omitFieldCompletely('urgency');
$tblCustomer->omitFieldCompletely('fullname');

# read only
$tblCustomer->turnOffAjaxEditing();
$tblCustomer->disallowAdd();
if($_SESSION['role'] != 1) $tblCustomer->disallowDelete();

#set style
#$tblCustomer->setCSSFile('mediagroove.css');

# actually show to the table
$tblCustomer->showTable();

?>