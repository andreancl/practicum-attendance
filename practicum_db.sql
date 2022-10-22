-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: practicum_db
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `attendance`
--

DROP TABLE IF EXISTS `attendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `attendance` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `PracticumID` bigint NOT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `FirstName` varchar(45) DEFAULT NULL,
  `Date` varchar(45) DEFAULT NULL,
  `TimeLogIn_AM` varchar(45) DEFAULT NULL,
  `TimeLogOut_AM` varchar(45) DEFAULT NULL,
  `AM_Status` varchar(45) DEFAULT NULL,
  `TimeLogIn_PM` varchar(45) DEFAULT NULL,
  `TimeLogOut_PM` varchar(45) DEFAULT NULL,
  `PM_Status` varchar(45) DEFAULT NULL,
  `DateCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Hours` double DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `PracticumID_idx` (`PracticumID`),
  KEY `LastName_idx` (`LastName`),
  KEY `FirstName_idx` (`FirstName`),
  CONSTRAINT `FirstName` FOREIGN KEY (`FirstName`) REFERENCES `practicum` (`FirstName`),
  CONSTRAINT `LastName` FOREIGN KEY (`LastName`) REFERENCES `practicum` (`LastName`),
  CONSTRAINT `PracticumID` FOREIGN KEY (`PracticumID`) REFERENCES `practicum` (`PracticumID`)
) ENGINE=InnoDB AUTO_INCREMENT=88 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendance`
--

LOCK TABLES `attendance` WRITE;
/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
INSERT INTO `attendance` VALUES (1,1801133,'Napao','Ninna Odette','2022-10-03','7:38:39 AM','11:44:21 AM','OUT','1:01:49 PM','4:40:10 PM','OUT','2022-10-08 05:38:39',NULL),(2,1802902,'Balacano','Jayson Jade','2022-10-03','8:01:58 AM','12:04:17 PM','OUT','1:01:54 PM','4:39:56 PM','OUT','2022-10-08 06:39:38',NULL),(3,1900632,'Bayron','Jay','2022-10-03','7:40:24 AM','11:39:08 AM','OUT','12:58:14 PM','3:53:18 PM','OUT','2022-10-11 07:40:24',NULL),(4,1902858,'Francisco','Mark Herbert','2022-10-03','7:40:35 AM','11:38:42 AM','OUT','12:58:19 PM','3:53:00 PM','OUT','2022-10-11 07:40:35',NULL),(5,1900588,'Petilla','Aileen Joy','2022-10-03','7:40:55 AM','11:44:27 AM','OUT','1:01:02 PM','4:39:49 PM','OUT','2022-10-11 07:40:55',NULL),(6,1801051,'Ragasa','Danica','2022-10-03','8:02:45 AM','11:39:13 AM','OUT','12:58:24 PM','4:53:34 PM','OUT','2022-10-19 09:02:45',NULL),(7,1901508,'Pagdato','Vincent Vien','2022-10-03','7:42:04 PM','11:38:47 AM','OUT','12:52:12 PM','3:53:12 PM','OUT','2022-10-19 13:07:54',NULL),(8,1901701,'Abajon','Earl Jerico','2022-10-03','7:45:04 PM','11:44:33 AM','OUT','1:02:21 PM','4:39:44 PM','OUT','2022-10-19 13:08:07',NULL),(9,1802972,'Adre','Jacelyn','2022-10-03','7:56:04 PM','11:38:52 AM','OUT','12:58:33 PM','3:53:24 PM','OUT','2022-10-19 16:32:04',NULL),(10,1901823,'Enriquez','Desseri','2022-10-03','8:01:58 AM','11:45:10 AM','OUT',NULL,'','','2022-10-11 06:01:58',NULL),(11,1901823,'Enriquez','Desseri','2022-10-04','7:59:04 AM','11:45:10 AM','OUT',NULL,'','','2022-10-04 07:59:04',NULL),(12,1901701,'Abajon','Earl Jerico','2022-10-04','7:59:15 AM','11:44:33 AM','OUT','1:02:21 PM','4:39:44 PM','OUT','2022-10-04 07:59:15',NULL),(13,1900588,'Petilla','Aileen Joy','2022-10-04','7:59:28 AM','11:44:27 AM','OUT','12:52:09 PM','4:43:12 PM','OUT','2022-10-04 07:59:28',NULL),(14,1901508,'Pagdato','Vincent Vien','2022-10-04','7:59:37 AM','11:38:47 AM','OUT','12:58:28 PM','3:53:12 PM','OUT','2022-10-04 07:59:37',NULL),(15,1801133,'Napao','Ninna Odette','2022-10-04','7:59:53 AM','11:44:21 AM','OUT','1:01:49 PM','4:40:10 PM','OUT','2022-10-04 07:59:53',NULL),(16,1802902,'Balacano','Jayson Jade','2022-10-04','8:00:08 AM','12:04:17 PM','OUT','1:01:54 PM','4:39:56 PM','OUT','2022-10-04 08:00:08',NULL),(17,1900632,'Bayron','Jay','2022-10-04',NULL,'','','12:58:14 PM','3:53:18 PM','OUT','2022-10-04 13:01:58',NULL),(18,1902858,'Francisco','Mark Herbert','2022-10-04',NULL,NULL,NULL,'12:58:19 PM','3:53:00 PM','OUT','2022-10-04 13:02:04',NULL),(19,1801051,'Ragasa','Danica','2022-10-04',NULL,'','','12:59:34 PM','4:37:28 PM','OUT','2022-10-04 13:02:15',NULL),(20,1802972,'Adre','Jacelyn','2022-10-04',NULL,'','','12:58:33 PM','3:53:24 PM','OUT','2022-10-04 13:05:52',NULL),(21,1801051,'Ragasa','Danica','2022-10-20','7:54:08 AM','11:39:13 AM','OUT','12:52:19 PM','4:53:32 PM','OUT','2022-10-20 16:54:08',NULL),(22,1802972,'Adre','Jacelyn','2022-10-20','7:54:56 PM','11:38:52 AM','OUT','12:58:33 PM','3:53:24 PM','OUT','2022-10-20 16:54:56',NULL),(23,1901508,'Pagdato','Vincent Vien','2022-10-21','7:52:59 PM','11:38:47 AM','OUT','12:58:28 PM','3:53:12 PM','OUT','2022-10-21 18:52:59',NULL),(24,1801133,'Napao','Ninna Odette','2022-10-21','7:53:58 PM','11:44:21 AM','OUT',NULL,'','','2022-10-21 18:53:58',NULL),(25,1900588,'Petilla','Aileen Joy','2022-10-21','7:51:14 AM','11:44:27 AM','OUT',NULL,'','','2022-10-21 19:41:14',NULL),(26,1801051,'Ragasa','Danica','2022-10-21','7:52:31 AM','11:39:13 AM','OUT','12:55:02 PM','4:45:58 PM','OUT','2022-10-21 19:42:31',NULL),(27,1901701,'Abajon','Earl Jerico','2022-10-21','7:44:47 AM','11:44:33 AM','OUT',NULL,'','','2022-10-21 19:44:47',NULL),(28,1902858,'Francisco','Mark Herbert','2022-10-21','7:46:25 AM','11:38:42 AM','OUT','12:58:19 PM','3:53:00 PM','OUT','2022-10-21 19:46:25',NULL),(29,1802972,'Adre','Jacelyn','2022-10-21','7:47:24 AM','11:38:52 AM','OUT','12:58:33 PM','3:53:24 PM','OUT','2022-10-21 19:47:24',NULL),(30,1901701,'Abajon','Earl Jerico','2022-10-12','8:06:34 AM','12:10:17 PM','OUT',NULL,'','','2022-10-22 07:59:30',NULL),(31,1901508,'Pagdato','Vincent Vien','2022-10-12','7:59:47 AM','12:10:35 PM','OUT','12:59:31 PM','4:47:59 PM','OUT','2022-10-22 07:59:47',NULL),(32,1802972,'Adre','Jacelyn','2022-10-12','8:00:10 AM','12:10:25 PM','OUT','','','','2022-10-22 08:00:10',NULL),(33,1901823,'Enriquez','Desseri','2022-10-12','8:00:17 AM','12:10:29 PM','OUT','12:59:05 PM','4:48:05 PM','OUT','2022-10-22 08:00:17',NULL),(34,1802902,'Balacano','Jayson Jade','2022-10-12','8:00:34 AM','12:07:14 PM','OUT',NULL,'','','2022-10-22 08:00:34',NULL),(35,1902858,'Francisco','Mark Herbert','2022-10-12','8:00:53 AM','12:07:45 PM','OUT','','','','2022-10-22 08:00:53',NULL),(36,1801133,'Napao','Ninna Odette','2022-10-15','6:53:38 AM','11:44:21 AM','OUT',NULL,'','','2022-10-15 06:53:38',NULL),(37,1802902,'Balacano','Jayson Jade','2022-10-15','6:53:49 AM','12:04:17 PM','OUT',NULL,'','','2022-10-15 06:53:49',NULL),(38,1900632,'Bayron','Jay','2022-10-15','6:53:57 AM','11:39:08 AM','OUT','12:58:14 PM','3:53:18 PM','OUT','2022-10-15 06:53:57',NULL),(39,1902858,'Francisco','Mark Herbert','2022-10-15','6:54:04 AM','11:38:42 AM','OUT','12:58:19 PM','3:53:00 PM','OUT','2022-10-15 06:54:04',NULL),(40,1900588,'Petilla','Aileen Joy','2022-10-15','6:54:11 AM','11:44:27 AM','OUT',NULL,'','','2022-10-15 06:54:11',NULL),(41,1801051,'Ragasa','Danica','2022-10-15','6:54:17 AM','11:39:13 AM','OUT','1:01:54 PM','3:53:07 PM','OUT','2022-10-15 06:54:17',NULL),(42,1901508,'Pagdato','Vincent Vien','2022-10-15','6:54:25 AM','11:38:47 AM','OUT','12:58:28 PM','3:53:12 PM','OUT','2022-10-15 06:54:25',NULL),(43,1901701,'Abajon','Earl Jerico','2022-10-15','6:54:44 AM','11:44:33 AM','OUT',NULL,'','','2022-10-15 06:54:44',NULL),(44,1802972,'Adre','Jacelyn','2022-10-15','6:54:54 AM','11:38:52 AM','OUT','12:58:33 PM','3:53:24 PM','OUT','2022-10-15 06:54:54',NULL),(45,1901823,'Enriquez','Desseri','2022-10-15','6:55:04 AM','11:45:10 AM','OUT',NULL,'','','2022-10-15 06:55:04',NULL),(57,1900632,'Bayron','Jay','2022-10-17','7:56:58 AM','11:39:08 AM','OUT',NULL,NULL,NULL,'2022-10-17 07:56:58',NULL),(58,1902858,'Francisco','Mark Herbert','2022-10-17','7:57:03 AM','11:38:42 AM','OUT',NULL,NULL,NULL,'2022-10-17 07:57:03',NULL),(59,1801051,'Ragasa','Danica','2022-10-17','7:57:08 AM','11:39:13 AM','OUT',NULL,NULL,NULL,'2022-10-17 07:57:08',NULL),(60,1901508,'Pagdato','Vincent Vien','2022-10-17','7:57:12 AM','11:38:47 AM','OUT',NULL,NULL,NULL,'2022-10-17 07:57:12',NULL),(61,1802972,'Adre','Jacelyn','2022-10-17','7:57:17 AM','11:38:52 AM','OUT',NULL,NULL,NULL,'2022-10-17 07:57:17',NULL),(62,1802902,'Balacano','Jayson Jade','2022-10-17',NULL,'','','12:53:01 PM','4:39:56 PM','OUT','2022-10-17 12:53:01',NULL),(63,1801133,'Napao','Ninna Odette','2022-10-17',NULL,NULL,NULL,'12:53:07 PM','4:40:10 PM','OUT','2022-10-17 12:53:07',NULL),(64,1900588,'Petilla','Aileen Joy','2022-10-17',NULL,NULL,NULL,'12:53:12 PM','4:39:49 PM','OUT','2022-10-17 12:53:12',NULL),(65,1901823,'Enriquez','Desseri','2022-10-17',NULL,NULL,NULL,'12:53:18 PM','4:40:05 PM','OUT','2022-10-17 12:53:18',NULL),(66,1901701,'Abajon','Earl Jerico','2022-10-17',NULL,NULL,NULL,'12:53:24 PM','4:39:44 PM','OUT','2022-10-17 12:53:24',NULL),(70,1801133,'Napao','Ninna Odette','2022-10-12',NULL,NULL,NULL,'12:58:09 PM','4:47:28 PM','OUT','2022-10-22 12:58:09',NULL),(71,1900632,'Bayron','Jay','2022-10-12',NULL,NULL,NULL,'12:58:15 PM','4:47:33 PM','OUT','2022-10-22 12:58:15',NULL),(72,1900588,'Petilla','Aileen Joy','2022-10-12',NULL,NULL,NULL,'12:58:20 PM','4:47:45 PM','OUT','2022-10-22 12:58:20',NULL),(73,1801051,'Ragasa','Danica','2022-10-12',NULL,NULL,NULL,'12:58:26 PM','4:47:39 PM','OUT','2022-10-22 12:58:26',NULL),(79,1901701,'Abajon','Earl Jerico','2022-10-22','11:17:51 AM','11:21:38 AM','OUT','11:35:58 AM',NULL,'IN','2022-10-22 11:17:51',NULL),(80,1802972,'Adre','Jacelyn','2022-10-22','11:19:03 AM','11:23:48 AM','OUT','11:37:26 AM',NULL,'IN','2022-10-22 11:19:03',NULL),(81,1901508,'Pagdato','Vincent Vien','2022-10-22','11:20:43 AM','11:24:56 AM','OUT','11:34:10 AM',NULL,'IN','2022-10-22 11:20:43',NULL),(82,1902858,'Francisco','Mark Herbert','2022-10-22','11:20:57 AM','11:26:41 AM','OUT',NULL,NULL,NULL,'2022-10-22 11:20:57',NULL),(83,1900632,'Bayron','Jay','2022-10-22','11:27:53 AM','11:30:56 AM','OUT',NULL,NULL,NULL,'2022-10-22 11:27:53',NULL),(84,1802902,'Balacano','Jayson Jade','2022-10-22','11:28:46 AM','11:31:47 AM','OUT',NULL,NULL,NULL,'2022-10-22 11:28:46',NULL),(85,1801051,'Ragasa','Danica','2022-10-22','11:37:55 AM',NULL,'IN',NULL,NULL,NULL,'2022-10-22 11:37:55',NULL),(86,1900588,'Petilla','Aileen Joy','2022-10-22','11:39:14 AM','11:39:17 AM','OUT','11:39:21 AM',NULL,'IN','2022-10-22 11:39:14',NULL),(87,1801133,'Napao','Ninna Odette','2022-10-22','11:40:50 AM','11:40:54 AM','OUT','11:40:57 AM','11:40:59 AM','OUT','2022-10-22 11:40:50',NULL);
/*!40000 ALTER TABLE `attendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `practicum`
--

DROP TABLE IF EXISTS `practicum`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `practicum` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `PracticumID` bigint NOT NULL,
  `LastName` varchar(45) NOT NULL,
  `FirstName` varchar(45) NOT NULL,
  `Course` char(100) NOT NULL,
  `Venue` char(45) NOT NULL,
  `Assignment` char(45) NOT NULL,
  `TotalHours` bigint DEFAULT NULL,
  `Batch` char(45) NOT NULL,
  `SchoolYear` varchar(45) DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `DateTimeCreated` datetime DEFAULT NULL,
  `DateTimeUpdated` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `PracticumID` (`PracticumID`),
  KEY `LastName` (`LastName`),
  KEY `FirstName` (`FirstName`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `practicum`
--

LOCK TABLES `practicum` WRITE;
/*!40000 ALTER TABLE `practicum` DISABLE KEYS */;
INSERT INTO `practicum` VALUES (1,1800885,'Rafael','Andrea Mae Nicole','BS Computer Science','Admission Office','Filing Permit',NULL,'August','2021-2022','2022-07-25','2022-09-01',NULL,NULL),(2,1801523,'Concepcion','Joshua','BS Computer Science','Accounting Office','Encoding',NULL,'August','2021-2022','2022-07-25','2022-09-03',NULL,NULL),(3,1800524,'Visperas','Anthony','BS Computer Science','Admission Office','Filing Credentials',NULL,'August','2021-2022','2022-07-25','2022-09-01',NULL,NULL),(4,1802989,'Mandolado','Ryan Mark','BS Computer Science','Records Section','Filing Credentials',NULL,'August','2021-2022','2022-07-25','2022-09-01',NULL,NULL),(5,1802053,'Cadion','Trina Paula','BS Computer Science','Admission Office','Verification of Grades',NULL,'August','2021-2022','2022-07-25','2022-09-01',NULL,NULL),(6,1802314,'Dotollo','Justine Kayle','BS Computer Science','Admission Office','Window 5',NULL,'July','2021-2022','2022-06-23','2022-07-25',NULL,NULL),(7,1802441,'Lopez','Angeluv Tatiana','BS Computer Science','Admission Office','Window 9',NULL,'July','2021-2022','2022-06-23','2022-07-25',NULL,NULL),(8,1802486,'Martinez','Gerico Nicolas','BS Computer Science','Accounting Office','Window 5',NULL,'July','2021-2022','2022-06-23','2022-07-25',NULL,NULL),(9,1803924,'Loreno','Mary Joy','BS Computer Science','Admission Office','Front Desk',NULL,'September','2021-2022','2022-09-05','2022-10-01',NULL,NULL),(10,1801958,'Ruaya','Nhecy','BS Computer Science','Admission Office','Carding',NULL,'July','2021-2022','2022-06-23','2022-07-25',NULL,NULL),(11,1802442,'Landicho','Harold','BS Computer Science','Accounting Office','Encoding',NULL,'July','2021-2022','2022-06-23','2022-07-25',NULL,NULL),(12,1801806,'Flores','Ana Lyn','BS Computer Science','Accounting Office','Encoding',NULL,'August','2021-2022','2022-07-25','2022-09-01',NULL,NULL),(13,1801090,'Morabe','Enrico Dominic','BS Computer Science','Admission Office','Background Investigation',NULL,'July','2021-2022','2022-06-23','2022-07-25',NULL,NULL),(16,1802902,'Balacano','Jayson Jade','BS Business Administration - MM','Records Section','Evaluation',NULL,'October','2022-2023','2022-10-03','2022-10-31',NULL,NULL),(17,1900632,'Bayron','Jay','BS Business Administration - FM','Admission Office','Assistant',NULL,'October','2022-2023','2022-10-03','2022-10-31',NULL,NULL),(18,1902858,'Francisco','Mark Herbert','BS Computer Science','Admission Office','Encoding',NULL,'October','2022-2023','2022-10-03','2022-10-31',NULL,NULL),(19,1801133,'Napao','Ninna Odette','BS Foreign Service','Admission Office','Carding',NULL,'October','2022-2023','2022-10-03','2022-10-31',NULL,NULL),(20,1900588,'Petilla','Aileen Joy','BS Foreign Service','Admission Office','Window 10',NULL,'October','2022-2023','2022-10-03','2022-10-31',NULL,NULL),(21,1801051,'Ragasa','Danica','BS Business Administration - HRDM','Admission Office','Verification of Grades',NULL,'October','2022-2023','2022-10-03','2022-10-31',NULL,NULL),(22,1901508,'Pagdato','Vincent Vien','BS Computer Science','Accounting Office','Assistant',NULL,'October','2022-2023','2022-10-03','2022-10-31',NULL,NULL),(23,1901701,'Abajon','Earl Jerico','BS Business Administration - MM','Admission Office','Encoding',NULL,'October','2022-2023','2022-10-03','2022-10-31',NULL,NULL),(24,1802972,'Adre','Jacelyn','AB Political Science','Admission Office','Front Desk',NULL,'October','2022-2023','2022-10-03','2022-10-31',NULL,NULL),(25,1901823,'Enriquez','Desseri','BS Business Administration - HRDM','Admission Office','Background Investigation',NULL,'October','2022-2023','2022-10-03','2022-10-31',NULL,NULL);
/*!40000 ALTER TABLE `practicum` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` varchar(45) DEFAULT NULL,
  `FullName` char(45) DEFAULT NULL,
  `Username` varchar(12) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `SecretQuestion` varchar(45) DEFAULT NULL,
  `SecretAnswer` varchar(45) DEFAULT NULL,
  `UserTypeId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserId_UNIQUE` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,NULL,NULL,'admin','admin','What is the name of your first pet?','Enzo',1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-10-22 11:41:40
