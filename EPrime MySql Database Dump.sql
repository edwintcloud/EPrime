-- --------------------------------------------------------
-- Host:                         eprime.duckdns.org
-- Server version:               5.5.49-0+deb8u1 - (Debian)
-- Server OS:                    debian-linux-gnu
-- HeidiSQL Version:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
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
  `visible` int(11) NOT NULL DEFAULT '1',
  `stepid` int(10) unsigned NOT NULL DEFAULT '0',
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
  `computername` text,
  `user` text,
  `error` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=387 DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.errors: ~132 rows (approximately)
DELETE FROM `errors`;
/*!40000 ALTER TABLE `errors` DISABLE KEYS */;
INSERT INTO `errors` (`id`, `computername`, `user`, `error`) VALUES
	(245, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:04:11 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(246, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:04:13 PM]: Form1.SetWizard() failed due to System.NullReferenceException with message: Object reference not set to an instance of an object.'),
	(247, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:04:15 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(248, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:04:20 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(249, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:04:20 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(250, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:05:36 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(251, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:07:32 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(252, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:07:38 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(253, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:26:27 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(254, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:26:58 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(255, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:39:01 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(256, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:39:07 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(257, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:42:25 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(258, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:43:00 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(259, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:43:02 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(260, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:43:51 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(261, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:43:53 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(262, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:43:54 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(263, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:43:55 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(264, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:46:55 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(265, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:46:57 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(266, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:46:58 PM]: Form1.SetWizard() failed due to System.FormatException with message: Input string was not in a correct format.'),
	(267, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:52:27 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(268, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:54:04 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(269, 'DESKTOP-FFE643I', 'Edwin', '[4/27/2016 8:54:10 PM]: Form1.SetWizard() failed due to System.NullReferenceException with message: Object reference not set to an instance of an object.'),
	(270, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 12:56:18 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(271, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:05:04 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(272, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:20:21 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(273, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:23:26 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(274, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:26:35 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(275, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:29:08 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(276, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:30:24 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(277, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:31:46 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(278, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:32:51 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(279, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:35:34 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(280, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:38:35 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(281, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:39:31 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(282, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:40:58 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(283, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:42:04 AM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(284, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 12:51:11 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(285, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 12:54:47 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(286, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 12:56:13 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(287, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 12:57:30 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(288, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 1:29:33 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(289, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 2:34:38 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(290, 'DESKTOP-FFE643I', 'Edwin', '[4/28/2016 2:35:28 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(291, 'DESKTOP-FFE643I', 'Edwin', '[5/1/2016 4:26:44 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(292, 'DESKTOP-FFE643I', 'Edwin', '[5/1/2016 4:27:22 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(293, 'DESKTOP-FFE643I', 'Edwin', '[5/1/2016 4:29:26 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(294, 'DESKTOP-FFE643I', 'Edwin', '[5/1/2016 4:30:11 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(295, 'DESKTOP-FFE643I', 'Edwin', '[5/1/2016 4:31:08 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(296, 'DESKTOP-FFE643I', 'Edwin', '[5/1/2016 4:37:39 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(297, 'DESKTOP-FFE643I', 'Edwin', '[5/1/2016 4:38:30 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(298, 'DESKTOP-FFE643I', 'Edwin', '[5/1/2016 4:40:30 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(299, 'DESKTOP-FFE643I', 'Edwin', '[5/1/2016 4:42:43 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(300, 'DESKTOP-FFE643I', 'Edwin', '[5/1/2016 4:43:32 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(301, 'DESKTOP-FFE643I', 'Edwin', '[5/1/2016 4:47:27 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(302, 'DESKTOP-FFE643I', 'Edwin', '[5/1/2016 4:48:23 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(303, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 4:45:55 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(304, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 5:49:12 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(305, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 5:50:40 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(306, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 5:52:48 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(307, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:03:13 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(308, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:20:55 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(309, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:21:11 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(310, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:24:07 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(311, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:24:21 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(312, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:24:41 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(313, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:31:51 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(314, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:42:38 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(315, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:43:19 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(316, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:46:01 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(317, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:46:32 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(318, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:51:08 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(319, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 6:53:04 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(320, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 7:40:15 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(321, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 7:43:30 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(322, 'DESKTOP-FFE643I', 'Edwin', '[5/2/2016 7:53:25 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(323, 'DESKTOP-FFE643I', 'Edwin', '[5/4/2016 4:18:43 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(324, 'DESKTOP-FFE643I', 'Edwin', '[5/4/2016 4:23:51 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(325, 'DESKTOP-FFE643I', 'Edwin', '[5/4/2016 4:37:55 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(326, 'DESKTOP-FFE643I', 'Edwin', '[5/4/2016 5:05:43 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(327, 'DESKTOP-FFE643I', 'Edwin', '[5/4/2016 5:37:04 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(328, 'DESKTOP-FFE643I', 'Edwin', '[5/4/2016 5:38:48 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(329, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 4:39:34 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(330, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 4:45:38 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(331, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 4:51:04 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(332, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 4:55:47 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(333, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 4:56:52 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(334, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:02:56 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(335, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:05:05 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(336, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:08:59 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(337, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:13:10 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(338, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:19:19 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(339, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:20:55 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(340, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:24:48 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(341, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:29:22 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(342, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:30:50 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(343, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:31:28 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(344, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:32:54 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(345, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:34:47 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(346, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:37:26 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(347, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:38:11 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(348, 'DESKTOP-FFE643I', 'Edwin', '[5/8/2016 5:38:44 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(349, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:19:05 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(350, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:19:06 PM]: FileOps.CsvRead(Cherwell_Exports/cherwellExport.csv) failed due to System.IO.FileNotFoundException with message: Could not find file \'C:\\Users\\Edwin\\Documents\\Visual Studio 2015\\Projects\\EPrime\\EPrime\\bin\\Release\\Cherwell_Exports\\cherwellExport.csv\'.'),
	(351, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:19:06 PM]: FileOps.TxtRead(Cherwell_Exports/resExport.txt) failed due to System.IO.FileNotFoundException with message: Could not find file \'C:\\Users\\Edwin\\Documents\\Visual Studio 2015\\Projects\\EPrime\\EPrime\\bin\\Release\\Cherwell_Exports\\resExport.txt\'.'),
	(352, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:19:06 PM]: FileOps.TxtRead(Cherwell_Exports/descExport.txt) failed due to System.IO.FileNotFoundException with message: Could not find file \'C:\\Users\\Edwin\\Documents\\Visual Studio 2015\\Projects\\EPrime\\EPrime\\bin\\Release\\Cherwell_Exports\\descExport.txt\'.'),
	(353, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:19:06 PM]: Form1.LoadFields() failed due to System.ArgumentOutOfRangeException with message: Index was out of range. Must be non-negative and less than the size of the collection.'),
	(354, 'DESKTOP-FFE643I', 'Edwin', 'Parameter name: index'),
	(355, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:19:10 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(356, 'DESKTOP-FFE643I', 'Edwin', 'Parameter name: length'),
	(357, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:19:13 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(358, 'DESKTOP-FFE643I', 'Edwin', 'Parameter name: length'),
	(359, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:19:14 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(360, 'DESKTOP-FFE643I', 'Edwin', 'Parameter name: length'),
	(361, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:19:17 PM]: Form1.SetWizard() failed due to System.ArgumentOutOfRangeException with message: Length cannot be less than zero.'),
	(362, 'DESKTOP-FFE643I', 'Edwin', 'Parameter name: length'),
	(363, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:10 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(364, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:11 PM]: FileOps.CsvRead(Cherwell_Exports/cherwellExport.csv) failed due to System.IO.FileNotFoundException with message: Could not find file \'C:\\Users\\Edwin\\Desktop\\EPrime Release\\Release\\Cherwell_Exports\\cherwellExport.csv\'.'),
	(365, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:11 PM]: FileOps.TxtRead(Cherwell_Exports/resExport.txt) failed due to System.IO.FileNotFoundException with message: Could not find file \'C:\\Users\\Edwin\\Desktop\\EPrime Release\\Release\\Cherwell_Exports\\resExport.txt\'.'),
	(366, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:11 PM]: FileOps.TxtRead(Cherwell_Exports/descExport.txt) failed due to System.IO.FileNotFoundException with message: Could not find file \'C:\\Users\\Edwin\\Desktop\\EPrime Release\\Release\\Cherwell_Exports\\descExport.txt\'.'),
	(367, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:11 PM]: Form1.LoadFields() failed due to System.ArgumentOutOfRangeException with message: Index was out of range. Must be non-negative and less than the size of the collection.'),
	(368, 'DESKTOP-FFE643I', 'Edwin', 'Parameter name: index'),
	(369, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:25 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(370, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:25 PM]: MySql.GetButtons() failed due to MySql.Data.MySqlClient.MySqlException with message: Unable to connect to any of the specified MySQL hosts.'),
	(371, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:25 PM]: Form1.LoadBtns() failed due to System.ArgumentOutOfRangeException with message: Index was out of range. Must be non-negative and less than the size of the collection.'),
	(372, 'DESKTOP-FFE643I', 'Edwin', 'Parameter name: index'),
	(373, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:25 PM]: FileOps.CsvRead(Cherwell_Exports/cherwellExport.csv) failed due to System.IO.FileNotFoundException with message: Could not find file \'C:\\Users\\Edwin\\Desktop\\EPrime Release\\Release\\Cherwell_Exports\\cherwellExport.csv\'.'),
	(374, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:25 PM]: FileOps.TxtRead(Cherwell_Exports/resExport.txt) failed due to System.IO.FileNotFoundException with message: Could not find file \'C:\\Users\\Edwin\\Desktop\\EPrime Release\\Release\\Cherwell_Exports\\resExport.txt\'.'),
	(375, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:25 PM]: FileOps.TxtRead(Cherwell_Exports/descExport.txt) failed due to System.IO.FileNotFoundException with message: Could not find file \'C:\\Users\\Edwin\\Desktop\\EPrime Release\\Release\\Cherwell_Exports\\descExport.txt\'.'),
	(376, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:25 PM]: Form1.LoadFields() failed due to System.ArgumentOutOfRangeException with message: Index was out of range. Must be non-negative and less than the size of the collection.'),
	(377, 'DESKTOP-FFE643I', 'Edwin', 'Parameter name: index'),
	(378, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:25 PM]: MySql.UpdateTicket() failed due to MySql.Data.MySqlClient.MySqlException with message: Unable to connect to any of the specified MySQL hosts.'),
	(379, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:28 PM]: MySql.SendErrors() failed due to MySql.Data.MySqlClient.MySqlException with message: Unable to connect to any of the specified MySQL hosts.'),
	(380, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:28 PM]: MySql.UpdateTicket() failed due to MySql.Data.MySqlClient.MySqlException with message: Unable to connect to any of the specified MySQL hosts.'),
	(381, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:36 PM]: Environment.GetCommandLineArgs() failed due to System.IndexOutOfRangeException with message: Index was outside the bounds of the array.'),
	(382, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:37 PM]: FileOps.CsvRead(Cherwell_Exports/cherwellExport.csv) failed due to System.IO.FileNotFoundException with message: Could not find file \'C:\\Users\\Edwin\\Desktop\\EPrime Release\\Release\\Cherwell_Exports\\cherwellExport.csv\'.'),
	(383, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:37 PM]: FileOps.TxtRead(Cherwell_Exports/resExport.txt) failed due to System.IO.FileNotFoundException with message: Could not find file \'C:\\Users\\Edwin\\Desktop\\EPrime Release\\Release\\Cherwell_Exports\\resExport.txt\'.'),
	(384, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:37 PM]: FileOps.TxtRead(Cherwell_Exports/descExport.txt) failed due to System.IO.FileNotFoundException with message: Could not find file \'C:\\Users\\Edwin\\Desktop\\EPrime Release\\Release\\Cherwell_Exports\\descExport.txt\'.'),
	(385, 'DESKTOP-FFE643I', 'Edwin', '[5/12/2016 1:30:37 PM]: Form1.LoadFields() failed due to System.ArgumentOutOfRangeException with message: Index was out of range. Must be non-negative and less than the size of the collection.'),
	(386, 'DESKTOP-FFE643I', 'Edwin', 'Parameter name: index');
/*!40000 ALTER TABLE `errors` ENABLE KEYS */;


-- Dumping structure for table eprime.pending_values
DROP TABLE IF EXISTS `pending_values`;
CREATE TABLE IF NOT EXISTS `pending_values` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `incidentid` text NOT NULL,
  `value` longtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.pending_values: ~1 rows (approximately)
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
  `show_edit` int(11) NOT NULL DEFAULT '0',
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
  `useremail` text,
  `subject` text,
  `description` longtext,
  `resolution` longtext,
  `courseid` text,
  `lmssystem` text,
  `service` text,
  `category` text,
  `subcategory` text,
  `priority` text,
  `impact` text,
  `urgency` text,
  `incidentid` text NOT NULL,
  `fullname` text,
  `email` text,
  `campus` text,
  `ssn` text,
  `time` text,
  `status` text,
  `lastaction` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.tickets: ~10 rows (approximately)
DELETE FROM `tickets`;
/*!40000 ALTER TABLE `tickets` DISABLE KEYS */;
INSERT INTO `tickets` (`id`, `datetime`, `useremail`, `subject`, `description`, `resolution`, `courseid`, `lmssystem`, `service`, `category`, `subcategory`, `priority`, `impact`, `urgency`, `incidentid`, `fullname`, `email`, `campus`, `ssn`, `time`, `status`, `lastaction`) VALUES
	(16, '5/8/2016 5:39:40 PM', 'edwin.cloud1@personalsupportcenter.com', 'subject', 'wtest\r\n!@#$!@#%#%^^%&*(*&)(&&&^//.,.,<><>\';\';:":":][}{}{][\\\\||\r\nline3', 'res', 'courseid', 'Angel', 'Learning System Support', 'Account', 'Block Request', '4', 'Single Individual', 'Medium', '267760', 'Edwin Cloud', 'edwintcloud@gmail.com', 'FL - Accelerated', '8222', '00.92', 'In Progress', 'Forcefully Closed'),
	(17, '4/21/2016 6:58:41 PM', 'edwin.cloud1@personalsupportcenter.com', '', '', '', '', '', '15K', '15K', 'Incident', '4', 'Single Individual', 'Medium', '281134', 'Corey Morris', 'corey.morris@smail.rasmussen.edu', 'FL - Tampa/Brandon', '6326', '00.20', 'In Progress', 'Forcefully Closed'),
	(18, '4/26/2016 4:33:02 PM', 'edwin.cloud1@personalsupportcenter.com', '', '', '', '', '', '15K', '15K', 'Incident', '4', 'Single Individual', 'Medium', '282771', '', '', '', '', '00.10', 'In Progress', 'Forcefully Closed'),
	(19, '4/28/2016 5:22:28 PM', 'edwin.cloud1@personalsupportcenter.com', 'Scrub Issue', '\r\nPeggy never received their scrubs.\r\nI found Peggy\'s order. ', 'I directed Peggy to go to the student portal, and select \'Online Bookstore\' under campus tools on the left. \r\nFrom there, have them select \'Contact Us\', and include as much information as possible about what they need, as this is the most direct way for them to contact the bookstore.\r\n', '', '', 'Materials', 'Incorrect/Incomplete', 'Missing / Never Received', '4', 'Single Individual', 'Medium', '283611', 'Peggy Caruth', 'peggy.caruth@smail.rasmussen.edu', 'IL - Rockford', '0114', '15.73', 'Resolved', 'Forcefully Closed'),
	(20, '4/28/2016 5:40:38 PM', 'edwin.cloud1@personalsupportcenter.com', 'NoodleBib Issue', 'Jonathan is having issues logging into NoodleBib. I was able to create an account in NoodleBib for Jonathan so that he may now access the site.', 'Jonathan is having issues logging into NoodleBib. I was able to create an account in NoodleBib for Jonathan so that he may now access the site.', '', '', 'Learning System Support', 'Unsupported', 'Unsupported Issue', '4', 'Single Individual', 'Medium', '283620', 'Jonathan Burke', 'jonathan.burke@smail.rasmussen.edu', 'MN - Bloomington', '5385', '11.82', 'Resolved', 'Forcefully Closed'),
	(21, '4/28/2016 7:21:22 PM', 'edwin.cloud1@personalsupportcenter.com', 'Call Transfer', 'Cynthia is needing to speak to an Advisor, I have given her the number to cal tomorrow during business hours to the Advisor\'s Hotline.\r\nCynthia needs to be transferred to yes.\r\nI transferred Cynthia\'s call.', 'Cynthia is needing to speak to an Advisor, I have given her the number to cal tomorrow during business hours to the Advisor\'s Hotline.\r\nI transferred Cynthia\'s call.', '', '', 'Contact Administration', 'Call Transfer', 'Call Transfer', '4', 'Single Individual', 'Medium', '283654', 'Cynthia Collins', 'cynthia.collins@smail.rasmussen.edu', 'Central Campus', '3535', '09.12', 'Resolved', 'Forcefully Closed'),
	(23, '5/1/2016 4:55:46 PM', 'Joel.Kozlick@personalsupportcenter.com', 'Concerns', 'To: (Personal Support Center) help@personalsupportcenter.com\r\nFrom: (Michelle MacDonald) Michelle.MacDonald@rasmussen.edu\r\nHello, \r\nI have three concerns.\r\nI cannot access the mid-quarter student survey results in blackboard.\r\nI am receiving the message in the screen shot attached.\r\nMy name was changed in Blackboard and I cannot correct this.\r\nThank-you.\r\nMichelle\r\nDr. Michelle MacDonald, DNP, RN, PHN, CNS\r\nRN to BSN Online Program Faculty\r\nSchool of Nursing – Rasmussen College\r\nMobile: 218-464-3950\r\nmichelle.macdonald@Rasmussen.edu\r\nwww.Rasmussen.edu \r\nConfidentiality. This electronic transmission is strictly confidential to the sender and intended solely for the addressee. It may contain information which is covered by legal, professional or other privilege. If you are not the intended addressee, or someone authorized by the intended addressee to receive transmissions on behalf of the addressee, you must not retain, disclose in any form, copy or take any action in reliance on this transmission. If you have received this transmission in error, please notify the sender as soon as possible and destroy this message.', '', 'NA', '', 'Learning System Support', 'Account', 'Credentials Question', '3', 'Company-wide', 'Urgent/Emergency', '283278', 'Michelle MacDonald', 'Michelle.MacDonald@rasmussen.edu', 'Rasmussen - Online', '', '45.82', 'Pending', 'Forcefully Closed'),
	(24, '5/3/2016 6:05:51 PM', 'edwin.cloud1@personalsupportcenter.com', '', '', '', '', '', '15K', '15K', 'Incident', '4', 'Single Individual', 'Medium', '285414', 'Jeffrey Hublit', 'jeffrey.hublit@smail.rasmussen.edu', 'FL - Accelerated', '9506', '00.08', 'In Progress', 'Forcefully Closed'),
	(25, '5/5/2016 6:58:29 PM', 'edwin.cloud1@personalsupportcenter.com', '', '', '', '', '', '15K', '15K', 'Incident', '4', 'Single Individual', 'Medium', '286259', 'Catherine Bauer', 'catherine.bauer@smail.rasmussen.edu', 'MN - Moorhead', '0557', '00.32', 'In Progress', 'Forcefully Closed'),
	(26, '5/12/2016 1:30:41 PM', '', '', '', '', '', '', '15K', '15K', 'Incident', '1', 'Company-wide', 'Emergency', '', '', '', '', '', '00.07', 'In Progress', 'Forcefully Closed');
/*!40000 ALTER TABLE `tickets` ENABLE KEYS */;


-- Dumping structure for table eprime.users
DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.users: ~1 rows (approximately)
DELETE FROM `users`;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id`, `username`, `password`, `role`) VALUES
	(1, 'edwin', 'edwint253', 1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;


-- Dumping structure for table eprime.web_users
DROP TABLE IF EXISTS `web_users`;
CREATE TABLE IF NOT EXISTS `web_users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Dumping data for table eprime.web_users: ~3 rows (approximately)
DELETE FROM `web_users`;
/*!40000 ALTER TABLE `web_users` DISABLE KEYS */;
INSERT INTO `web_users` (`id`, `username`, `password`, `role`) VALUES
	(1, 'edwin', '747eb42e71508e9bff58958064673152', 1),
	(2, 'psc', '0da5a8017f2f0ac4bbb35061ca011361', 0),
	(3, 'pscadmin', '0da5a8017f2f0ac4bbb35061ca011361', 1);
/*!40000 ALTER TABLE `web_users` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
