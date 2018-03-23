-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               10.2.13-MariaDB-log - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for eprime
DROP DATABASE IF EXISTS `eprime`;
CREATE DATABASE IF NOT EXISTS `eprime` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `eprime`;

-- Dumping structure for table eprime.buttons
DROP TABLE IF EXISTS `buttons`;
CREATE TABLE IF NOT EXISTS `buttons` (
  `id` int(11) NOT NULL,
  `label` text NOT NULL,
  `visible` int(11) NOT NULL DEFAULT 1,
  `stepid` int(10) unsigned NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.buttons: ~12 rows (approximately)
DELETE FROM `buttons`;
/*!40000 ALTER TABLE `buttons` DISABLE KEYS */;
INSERT INTO `buttons` (`id`, `label`, `visible`, `stepid`) VALUES
	(1, 'Course Content', 1, 1),
	(2, 'Login Issue', 1, 2),
	(3, 'Microsoft Office', 1, 3),
	(4, 'Archive Request', 1, 0),
	(5, 'Assignment Issue', 1, 0),
	(6, 'Live Escalation', 1, 0),
	(7, 'Course Materials', 1, 0),
	(8, 'Scrub Issue', 1, 11),
	(9, 'Webex', 1, 6),
	(10, 'Not Used', 0, 0),
	(11, 'Call Transfer', 1, 3),
	(12, 'Progress Report', 1, 1);
/*!40000 ALTER TABLE `buttons` ENABLE KEYS */;

-- Dumping structure for table eprime.errors
DROP TABLE IF EXISTS `errors`;
CREATE TABLE IF NOT EXISTS `errors` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `computername` text DEFAULT NULL,
  `user` text DEFAULT NULL,
  `error` text DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=429 DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.errors: ~142 rows (approximately)
DELETE FROM `errors`;
/*!40000 ALTER TABLE `errors` DISABLE KEYS */;
INSERT INTO `errors` (`id`, `computername`, `user`, `error`) VALUES
	(385, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:37 PM]: Form1.LoadFields() failed due to System.ArgumentOutOfRangeException with message: Index was out of range. Must be non-negative and less than the size of the collection.'),
	(386, 'DESKTOP-FFE643I', 'Edwin', 'Parameter name: index'),
	(387, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:00 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(388, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:00 PM]: FileOps.CsvRead(Cherwell_Exports/cherwellExport.csv) failed due to System.IO.FileNotFoundException with message: Could not find file \'D:\\Documents\\Old Projects\\EPrime\\Release\\Cherwell_Exports\\cherwellExport.csv\'.'),
	(389, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:00 PM]: FileOps.TxtRead(Cherwell_Exports/resExport.txt) failed due to System.IO.FileNotFoundException with message: Could not find file \'D:\\Documents\\Old Projects\\EPrime\\Release\\Cherwell_Exports\\resExport.txt\'.'),
	(390, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:00 PM]: FileOps.TxtRead(Cherwell_Exports/descExport.txt) failed due to System.IO.FileNotFoundException with message: Could not find file \'D:\\Documents\\Old Projects\\EPrime\\Release\\Cherwell_Exports\\descExport.txt\'.'),
	(391, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:00 PM]: Form1.LoadFields() failed due to System.ArgumentOutOfRangeException with message: Index was out of range. Must be non-negative and less than the size of the collection.'),
	(392, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: index'),
	(393, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:05 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(394, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: length'),
	(395, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:08 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(396, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: length'),
	(397, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:09 PM]: Form1.SetWizard() failed due to System.NullReferenceException with message: Object reference not set to an instance of an object.'),
	(398, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:10 PM]: Form1.SetWizard() failed due to System.NullReferenceException with message: Object reference not set to an instance of an object.'),
	(399, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:10 PM]: Form1.SetWizard() failed due to System.NullReferenceException with message: Object reference not set to an instance of an object.'),
	(400, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:11 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(401, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: length'),
	(402, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:17 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(403, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: length'),
	(404, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:18 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(405, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: length'),
	(406, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:25 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(407, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: length'),
	(408, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:27 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(409, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: length'),
	(410, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:29 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(411, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: length'),
	(412, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:32 PM]: Form1.SetWizard() failed due to System.NullReferenceException with message: Object reference not set to an instance of an object.'),
	(413, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:34 PM]: Form1.SetWizard() failed due to System.NullReferenceException with message: Object reference not set to an instance of an object.'),
	(414, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:35 PM]: Form1.SetWizard() failed due to System.NullReferenceException with message: Object reference not set to an instance of an object.'),
	(415, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:36 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(416, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: length'),
	(417, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:37 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(418, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: length'),
	(419, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:40 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(420, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: length'),
	(421, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:41 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(422, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: length'),
	(423, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:19:41 PM]: Form1.SetWizard() failed due to System.NullReferenceException with message: Object reference not set to an instance of an object.'),
	(424, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:21:31 PM]: FileOps.CsvRead(Cherwell_Exports/cherwellExport.csv) failed due to System.IO.FileNotFoundException with message: Could not find file \'D:\\Documents\\Old Projects\\EPrime\\Release\\Cherwell_Exports\\cherwellExport.csv\'.'),
	(425, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:21:31 PM]: FileOps.TxtRead(Cherwell_Exports/resExport.txt) failed due to System.IO.FileNotFoundException with message: Could not find file \'D:\\Documents\\Old Projects\\EPrime\\Release\\Cherwell_Exports\\resExport.txt\'.'),
	(426, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:21:31 PM]: FileOps.TxtRead(Cherwell_Exports/descExport.txt) failed due to System.IO.FileNotFoundException with message: Could not find file \'D:\\Documents\\Old Projects\\EPrime\\Release\\Cherwell_Exports\\descExport.txt\'.'),
	(427, 'DESKTOP-4G46EUE', 'Edwin', '[3/23/2018 12:21:31 PM]: Form1.LoadFields() failed due to System.ArgumentOutOfRangeException with message: Index was out of range. Must be non-negative and less than the size of the collection.'),
	(428, 'DESKTOP-4G46EUE', 'Edwin', 'Parameter name: index');
/*!40000 ALTER TABLE `errors` ENABLE KEYS */;

-- Dumping structure for table eprime.pending_values
DROP TABLE IF EXISTS `pending_values`;
CREATE TABLE IF NOT EXISTS `pending_values` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `incidentid` text NOT NULL,
  `value` longtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.pending_values: ~0 rows (approximately)
DELETE FROM `pending_values`;
/*!40000 ALTER TABLE `pending_values` DISABLE KEYS */;
INSERT INTO `pending_values` (`id`, `incidentid`, `value`) VALUES
	(3, '283611', 'csa');
/*!40000 ALTER TABLE `pending_values` ENABLE KEYS */;

-- Dumping structure for table eprime.setfields
DROP TABLE IF EXISTS `setfields`;
CREATE TABLE IF NOT EXISTS `setfields` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `subject` text NOT NULL,
  `description` longtext NOT NULL,
  `resolution` longtext NOT NULL,
  `lmssystem` text NOT NULL,
  `service` text NOT NULL,
  `category` text NOT NULL,
  `subcategory` text NOT NULL,
  `priority` text NOT NULL,
  `impact` text NOT NULL,
  `urgency` text NOT NULL,
  `cause` text NOT NULL,
  `command` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.setfields: ~9 rows (approximately)
DELETE FROM `setfields`;
/*!40000 ALTER TABLE `setfields` DISABLE KEYS */;
INSERT INTO `setfields` (`id`, `subject`, `description`, `resolution`, `lmssystem`, `service`, `category`, `subcategory`, `priority`, `impact`, `urgency`, `cause`, `command`) VALUES
	(1, 'Progress Report Request', '$name needs to access their progress reports. $name can do this by going to their student account center, which can be accessed by logging in to the student portal and clicking the icon at the top right that says student portal, logging in, and clicking on \'Unofficial Transcript.', '$name needs to access their progress reports. $name can do this by going to their student account center, which can be accessed by logging in to the student portal and clicking the icon at the top right that says student portal, logging in, and clicking on \'Unofficial Transcript.', '', 'Applications', 'Student Portal', 'Other', '4', 'Single Individual', 'Medium', 'Training/Explaination', ''),
	(2, 'Call Transfer', '$name needs to be transferred to $0.\r\nI transferred $name\'s call.', 'I transferred $name\'s call.', '', 'Contact Administration', 'Call Transfer', 'Call Transfer', '4', 'Single Individual', 'Medium', 'Training/Explaination', ''),
	(3, 'Call Transfer', '$name needs to be transferred to $0.\r\nI\'m unable to transfer $name to the person they\'re trying to reach.', '$name will need to call the number they\'re trying to reach later.', '', 'Contact Administration', 'Call Transfer', 'Call Transfer', '4', 'Single Individual', 'Medium', 'Training/Explaination', ''),
	(4, 'WebEx Access Issue', 'Course: $0\r\n\r\n$name is unable to access their WebEx lecture for their course. $name was able to access the lecture by Right-Click -> Open In New Tab and making sure the proper extensions were installed in Chrome.', '$name is now able to access their WebEx lecture.', '', 'Learning System Support', 'Online Meeting Software', 'Access Issue', '4', 'Single Individual', 'Medium', 'Training/Explaination', ''),
	(5, 'WebEx Access Issue', 'Course: $0\r\n\r\n$name is unable to access their WebEx lecture for their course. Right-Click -> Open In New Tab and making sure the proper extensions are installed in Chrome does not fix the issue.', '', '', 'Learning System Support', 'Online Meeting Software', 'Access Issue', '4', 'Single Individual', 'Medium', '', ''),
	(6, 'WebEx Access Issue', 'Course: $0\r\n\r\n$name is unable to access their WebEx lecture for their course. $name will have to reach out to their instructor to receive a working link as the one provided is invalid.', '$name will have to reach out to their instructor to receive a working link as the one provided is invalid.', '', 'Learning System Support', 'Online Meeting Software', 'Access Issue', '4', 'Single Individual', 'Medium', 'Training/Explaination', ''),
	(7, 'Scrub Issue', '$name Needs to Order Additional Scrubs\r\nI directed $name to go to the student portal, and select \'Online Bookstore\' under campus tools on the left. \r\nFrom there, have them select \'Contact Us\', and include as much information as possible about what they need, as this is the most direct way for them to contact the bookstore.', 'I directed $name to go to the student portal, and select \'Online Bookstore\' under campus tools on the left. \r\nFrom there, have them select \'Contact Us\', and include as much information as possible about what they need, as this is the most direct way for them to contact the bookstore.', '', 'Materials', 'Incorrect/Incomplete', 'Exchanges', '4', 'Single Individual', 'Medium', 'Training/Explaination', 'scrubs1'),
	(8, 'Scrub Issue', '$name never received their scrubs.\r\nI found $name\'s order. ', '', '', 'Materials', 'Incorrect/Incomplete', 'Missing / Never Received', '4', 'Single Individual', 'Medium', '', ''),
	(9, 'Course Submission Issue', '$name is in the AcceleratED program.\r\n$name is having an issue with Discussion board\r\n$name is using Firefox.\r\nI have the same issue logged in as $name.', '', '', 'Learning System Support', 'Submissions', 'Submission Error', '4', 'Single Individual', 'Medium', 'Training/Explaination', '');
/*!40000 ALTER TABLE `setfields` ENABLE KEYS */;

-- Dumping structure for table eprime.steps
DROP TABLE IF EXISTS `steps`;
CREATE TABLE IF NOT EXISTS `steps` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `set_text` longtext NOT NULL,
  `options` text NOT NULL,
  `options_steps` text NOT NULL,
  `yesbtn_text` text NOT NULL,
  `nobtn_text` text NOT NULL,
  `show_edit` int(11) NOT NULL DEFAULT 0,
  `yes_next_step` int(10) NOT NULL,
  `no_next_step` int(10) NOT NULL,
  `set_fields_id` int(10) NOT NULL,
  `prev_step` int(10) NOT NULL,
  `help_text` longtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.steps: ~26 rows (approximately)
DELETE FROM `steps`;
/*!40000 ALTER TABLE `steps` DISABLE KEYS */;
INSERT INTO `steps` (`id`, `set_text`, `options`, `options_steps`, `yesbtn_text`, `nobtn_text`, `show_edit`, `yes_next_step`, `no_next_step`, `set_fields_id`, `prev_step`, `help_text`) VALUES
	(1, '$name needs to access their progress reports. $name can do this by going to their student account center, which can be accessed by logging in to the student portal and clicking the icon at the top right that says student portal, logging in, and clicking on \'Unofficial Transcript.', '', '', 'Ok', '', 0, -1, 0, 1, -999, ''),
	(2, 'Use an AUTOCATEGORIZE button below to start the Troubleshooting Wizard.', '', '', '', '', 0, 0, 0, 0, 1, ''),
	(3, 'Please enter the name or title of the person that you need to transfer $name to. \r\nExample: \'her student advisor\'', '', '', 'Continue', '', 1, 4, 0, 0, -999, ''),
	(4, 'Are you able to transfer $name to the person that they were trying to reach?', '', '', 'Yes', 'No', 0, -1, 5, 2, 3, ''),
	(5, 'Please give $name the phone number or extension of the person that they\'re trying to reach, and recommend they call later.', '', '', 'Ok', '', 0, -1, 0, 3, 4, ''),
	(6, 'What course is this for?', '', '', 'Continue', '', 1, 7, 0, 0, -999, ''),
	(7, 'Are you the agent able to access the link from your computer?', '', '', 'Yes', 'No', 0, 8, 10, 0, 6, ''),
	(8, 'Have $name try to access the link using Right-Click -> Open In New Tab from Google Chrome and when prompted install the extension. If the link is having them download a file, make sure they install the ARF player from the download page.\r\n\r\nDoes this resolve the issue?', '', '', 'Yes', 'No', 0, -1, 9, 4, 7, ''),
	(9, 'Please give $name the incident id and Escalate the call by transferring to 6421. Please click Ok then Save and Exit before transferring!', '', '', 'Ok', '', 0, -1, 0, 5, 8, ''),
	(10, 'Let $name know that there is an issue with the link and they will have to contact their instructor to receive a working link.', '', '', 'Ok', '', 0, -1, 0, 6, 7, ''),
	(11, 'What can I help you with in regards to scrubs?\r\nComplete this sentence:\r\n$name ...', 'needs to order additional scrubs.,never received their scrubs.,needs to exchange their scrubs.', '12,14,15', '', '', 0, 0, 0, 0, -999, 'Test Help!\r\nhttp://ambassadored.com'),
	(12, 'Inform $name that he/she can order additional scrubs at the Online Bookstore on the Portal under Resources Icon. Additionally, inform the student that you will be sending them an e-mail with info on how to order additional scrubs.', '', '', 'Ok', '', 0, -1, 0, 7, 11, ''),
	(14, 'Were you able to find an order for $name\'s  materials?\r\n\r\nPress the \'?\' button below for more information...', '', '', 'Yes', 'No', 0, 15, 18, 0, 11, ''),
	(15, 'Has $name\'\'s order shipped yet?\r\n\r\nPress the \'?\' button below for more information...', '', '', 'Yes', 'No', 0, 17, 16, 0, 14, ''),
	(16, 'Confirm whether $name needs these shipped to the address they currently have on file with us. Then, click \'Save and Exit\' and escalate the ticket to Next Level (Bookstore).', '', '', 'Ok', '', 0, -1, 0, 8, 15, ''),
	(17, 'Please let $name know when the order was placed, whether it\'s shipped or not, and provide them with the tracking number if one is available.', '', '', 'Ok', '', 0, -1, 0, 8, 15, ''),
	(18, 'Inform $name that he/she can order additional scrubs at the Online Bookstore on the Portal under Resources Icon. Additionally, inform the student that you will be sending them an e-mail with info on how to order additional scrubs.', '', '', 'Ok', '', 0, -1, 0, 7, 14, ''),
	(19, 'Is $name in the AcceleratED program?', 'AcceleratED,Non-AcceleratED', '', '', '', 0, 0, 0, 0, -999, ''),
	(20, 'What is the issue $name is having?', 'Discussion Board,Quiz,Dropbox,Grade', '', '', '', 0, 0, 0, 0, 19, ''),
	(21, 'Is the caller using Firefox? (If the caller has lost a disccusion post, suggest using Word to type the discussions. They can then copy and paste their work into the discussion.)', 'using Firefox,not using Firefox', '', '', '', 0, 0, 0, 0, 20, ''),
	(22, 'Do you have the same error logged in as the caller?', 'I have the same issue,I do not have the same issue', '', '', '', 0, 0, 0, 0, 21, ''),
	(23, 'Do the settings allow the user to access the item? If not refer the user to their instructor. If yes, escalate for remote assistance (Live escalation line is 6421) ', '', '', 'Ok', '', 0, -1, 0, 9, 22, ''),
	(24, 'test', 'opt1,opt1,', '1,1,', 'lbl', '', 0, 2, 0, 0, 0, 'heppp'),
	(25, 'yess', '', '', '', '', 1, 0, 0, 1, 2, ''),
	(26, 'dfe', 'test', '2', '', '', 0, 0, 0, 0, 0, ''),
	(27, 'asf', 'test', '2', '', '', 0, 0, 0, 0, 0, '');
/*!40000 ALTER TABLE `steps` ENABLE KEYS */;

-- Dumping structure for table eprime.tickets
DROP TABLE IF EXISTS `tickets`;
CREATE TABLE IF NOT EXISTS `tickets` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `datetime` text NOT NULL,
  `useremail` text DEFAULT NULL,
  `subject` text DEFAULT NULL,
  `description` longtext DEFAULT NULL,
  `resolution` longtext DEFAULT NULL,
  `courseid` text DEFAULT NULL,
  `lmssystem` text DEFAULT NULL,
  `service` text DEFAULT NULL,
  `category` text DEFAULT NULL,
  `subcategory` text DEFAULT NULL,
  `priority` text DEFAULT NULL,
  `impact` text DEFAULT NULL,
  `urgency` text DEFAULT NULL,
  `incidentid` text NOT NULL,
  `fullname` text DEFAULT NULL,
  `email` text DEFAULT NULL,
  `campus` text DEFAULT NULL,
  `ssn` text DEFAULT NULL,
  `time` text DEFAULT NULL,
  `status` text DEFAULT NULL,
  `lastaction` text DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.tickets: ~10 rows (approximately)
DELETE FROM `tickets`;
/*!40000 ALTER TABLE `tickets` DISABLE KEYS */;
INSERT INTO `tickets` (`id`, `datetime`, `useremail`, `subject`, `description`, `resolution`, `courseid`, `lmssystem`, `service`, `category`, `subcategory`, `priority`, `impact`, `urgency`, `incidentid`, `fullname`, `email`, `campus`, `ssn`, `time`, `status`, `lastaction`) VALUES
	(16, '5/8/2016 5:39:40 PM', 'person1@email.com', 'subject', 'wtest\r\n!@#$!@#%#%^^%&*(*&)(&&&^//.,.,<><>\';\';:":":][}{}{][\\\\||\r\nline3', 'res', 'courseid', 'Angel', 'Learning System Support', 'Account', 'Block Request', '4', 'Single Individual', 'Medium', '267760', 'Edwin Cloud', 'no@email.com', 'FL - Accelerated', '0000', '00.92', 'In Progress', 'Forcefully Closed'),
	(17, '4/21/2016 6:58:41 PM', 'person1@email.com', '', '', '', '', '', '15K', '15K', 'Incident', '4', 'Single Individual', 'Medium', '281134', 'Corey Morris', 'no@email.com', 'FL - Tampa/Brandon', '0000', '00.20', 'In Progress', 'Forcefully Closed'),
	(18, '4/26/2016 4:33:02 PM', 'person1@email.com', '', '', '', '', '', '15K', '15K', 'Incident', '4', 'Single Individual', 'Medium', '282771', '', '', '', '', '00.10', 'In Progress', 'Forcefully Closed'),
	(19, '4/28/2016 5:22:28 PM', 'person1@email.com', 'Scrub Issue', '\r\nPeggy never received their scrubs.\r\nI found Peggy\'s order. ', 'I directed Peggy to go to the student portal, and select \'Online Bookstore\' under campus tools on the left. \r\nFrom there, have them select \'Contact Us\', and include as much information as possible about what they need, as this is the most direct way for them to contact the bookstore.\r\n', '', '', 'Materials', 'Incorrect/Incomplete', 'Missing / Never Received', '4', 'Single Individual', 'Medium', '283611', 'Peggy Sue', 'no@email.com', 'IL - Rockford', '0000', '15.73', 'Resolved', 'Forcefully Closed'),
	(20, '4/28/2016 5:40:38 PM', 'person1@email.com', 'NoodleBib Issue', 'Jonathan is having issues logging into NoodleBib. I was able to create an account in NoodleBib for Jonathan so that he may now access the site.', 'Jonathan is having issues logging into NoodleBib. I was able to create an account in NoodleBib for Jonathan so that he may now access the site.', '', '', 'Learning System Support', 'Unsupported', 'Unsupported Issue', '4', 'Single Individual', 'Medium', '283620', 'Jonathan Joe', 'no@email.com', 'MN - Bloomington', '0000', '11.82', 'Resolved', 'Forcefully Closed'),
	(21, '4/28/2016 7:21:22 PM', 'person1@email.com', 'Call Transfer', 'Cynthia is needing to speak to an Advisor, I have given her the number to cal tomorrow during business hours to the Advisor\'s Hotline.\r\nCynthia needs to be transferred to yes.\r\nI transferred Cynthia\'s call.', 'Cynthia is needing to speak to an Advisor, I have given her the number to cal tomorrow during business hours to the Advisor\'s Hotline.\r\nI transferred Cynthia\'s call.', '', '', 'Contact Administration', 'Call Transfer', 'Call Transfer', '4', 'Single Individual', 'Medium', '283654', 'Cynthia Rhet', 'no@email.com', 'Central Campus', '0000', '09.12', 'Resolved', 'Forcefully Closed'),
	(24, '5/3/2016 6:05:51 PM', 'person1@email.com', '', '', '', '', '', '15K', '15K', 'Incident', '4', 'Single Individual', 'Medium', '285414', 'Jeffrey Justin', 'no@email.com', 'FL - Accelerated', '0000', '00.08', 'In Progress', 'Forcefully Closed'),
	(25, '5/5/2016 6:58:29 PM', 'person1@email.com', '', '', '', '', '', '15K', '15K', 'Incident', '4', 'Single Individual', 'Medium', '286259', 'Catherine Smith', 'no@email.com', 'MN - Moorhead', '0000', '00.32', 'In Progress', 'Forcefully Closed'),
	(26, '3/23/2018 12:22:10 PM', '', '', '', '', '', 'BlackBoard', 'Materials', 'Access Code / Link', 'Initial Tutorial', '1', 'Company-wide', 'Emergency', '', '', '', '', '', '03.13', 'In Progress', 'Forcefully Closed');
/*!40000 ALTER TABLE `tickets` ENABLE KEYS */;

-- Dumping structure for table eprime.users
DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.users: ~0 rows (approximately)
DELETE FROM `users`;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id`, `username`, `password`, `role`) VALUES
	(1, 'user', 'password', 1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

-- Dumping structure for table eprime.web_users
DROP TABLE IF EXISTS `web_users`;
CREATE TABLE IF NOT EXISTS `web_users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.web_users: ~3 rows (approximately)
DELETE FROM `web_users`;
/*!40000 ALTER TABLE `web_users` DISABLE KEYS */;
INSERT INTO `web_users` (`id`, `username`, `password`, `role`) VALUES
	(1, 'edwin', '5f4dcc3b5aa765d61d8327deb882cf99', 1),
	(2, 'psc', '5f4dcc3b5aa765d61d8327deb882cf99', 0),
	(3, 'pscadmin', '5f4dcc3b5aa765d61d8327deb882cf99', 1);
/*!40000 ALTER TABLE `web_users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
