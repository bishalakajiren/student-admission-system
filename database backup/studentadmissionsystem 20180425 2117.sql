-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.45-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema sas
--

CREATE DATABASE IF NOT EXISTS sas;
USE sas;

--
-- Definition of table `course`
--

DROP TABLE IF EXISTS `course`;
CREATE TABLE `course` (
  `course_id` int(11) NOT NULL,
  `course_name` varchar(20) default NULL,
  `course_fee` decimal(10,2) default NULL,
  `course_duration` varchar(15) default NULL,
  `qualification` varchar(20) default NULL,
  PRIMARY KEY  (`course_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `course`
--

/*!40000 ALTER TABLE `course` DISABLE KEYS */;
INSERT INTO `course` (`course_id`,`course_name`,`course_fee`,`course_duration`,`qualification`) VALUES 
 (108,' bba ','12000.00',' 3yrs ',' 12 '),
 (109,' BA ','11000.00',' 3yrs ',' 12 '),
 (110,' MCA ','17500.00',' 3YRS ',' BCA '),
 (111,' MA ','17000.00',' 2 ',' BA '),
 (112,'  bsc  ','12000.00',' 3 ',' hs '),
 (113,' BCA ','15000.00',' 3 ',' 12 ');
/*!40000 ALTER TABLE `course` ENABLE KEYS */;


--
-- Definition of table `payment`
--

DROP TABLE IF EXISTS `payment`;
CREATE TABLE `payment` (
  `course_fees` decimal(10,2) default NULL,
  `payment_id` int(11) NOT NULL,
  `student_id` int(11) default NULL,
  `course_id` int(11) default NULL,
  PRIMARY KEY  (`payment_id`),
  KEY `student_id` (`student_id`),
  KEY `course_id` (`course_id`),
  CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `student` (`student_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `payment_ibfk_2` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payment`
--

/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` (`course_fees`,`payment_id`,`student_id`,`course_id`) VALUES 
 ('15000.00',101,101,113);
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;


--
-- Definition of table `student`
--

DROP TABLE IF EXISTS `student`;
CREATE TABLE `student` (
  `student_id` int(11) NOT NULL,
  `student_name` varchar(20) default NULL,
  `roll_no` varchar(10) default NULL,
  `course_id` int(11) default NULL,
  `address` varchar(50) default NULL,
  PRIMARY KEY  (`student_id`),
  KEY `course_id` (`course_id`),
  CONSTRAINT `student_ibfk_1` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` (`student_id`,`student_name`,`roll_no`,`course_id`,`address`) VALUES 
 (101,' Bishal ',' 1 ',108,' Kahilipara '),
 (102,' suman ',' 2 ',109,' beltola '),
 (103,' abc ',' 987654321',112,' GJHKGUYTGIUT '),
 (104,' suman ',' 13 ',109,' sixmile '),
 (105,' bishal ',' 9001 ',109,' ghhhjj ');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
