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
  `TimeLogIn_PM` varchar(45) DEFAULT NULL,
  `TimeLogOut_PM` varchar(45) DEFAULT NULL,
  `Status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `PracticumID_idx` (`PracticumID`),
  KEY `LastName_idx` (`LastName`),
  KEY `FirstName_idx` (`FirstName`),
  CONSTRAINT `FirstName` FOREIGN KEY (`FirstName`) REFERENCES `practicum` (`FirstName`),
  CONSTRAINT `LastName` FOREIGN KEY (`LastName`) REFERENCES `practicum` (`LastName`),
  CONSTRAINT `PracticumID` FOREIGN KEY (`PracticumID`) REFERENCES `practicum` (`PracticumID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendance`
--

LOCK TABLES `attendance` WRITE;
/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
INSERT INTO `attendance` VALUES (1,1800885,'Rafael','Andrea Mae Nicole','2022-10-03','6:19:28 AM','6:19:35 AM',NULL,NULL,'Out'),(2,1801523,'Concepcion','Joshua','2022-10-03','6:30:43 AM','6:32:33 AM',NULL,NULL,'Out');
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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `practicum`
--

LOCK TABLES `practicum` WRITE;
/*!40000 ALTER TABLE `practicum` DISABLE KEYS */;
INSERT INTO `practicum` VALUES (1,1800885,'Rafael','Andrea Mae Nicole','BS Computer Science','Admission Office','Filing Permit',NULL,'August','2021-2022','2022-07-25','2022-09-01',NULL,NULL),(2,1801523,'Concepcion','Joshua','BS Computer Science','Accounting Office','Encoding',NULL,'August','2021-2022','2022-07-25','2022-09-03',NULL,NULL),(3,1800524,'Visperas','Anthony','BS Computer Science','Admission Office','Filing Credentials',NULL,'August','2021-2022','2022-07-25','2022-09-01',NULL,NULL),(4,1802989,'Mandolado','Ryan Mark','BS Computer Science','Records Section','Filing Credentials',NULL,'August','2021-2022','2022-07-25','2022-09-01',NULL,NULL),(5,1802053,'Cadion','Trina Paula','BS Computer Science','Admission Office','Verification of Grades',NULL,'August','2021-2022','2022-07-25','2022-09-01',NULL,NULL),(6,1802314,'Dotollo','Justine Kayle','BS Computer Science','Admission Office','Window 5',NULL,'July','2021-2022','2022-06-23','2022-07-25',NULL,NULL),(7,1802441,'Lopez','Angeluv Tatiana','BS Computer Science','Admission Office','Window 9',NULL,'July','2021-2022','2022-06-23','2022-07-25',NULL,NULL),(8,1802486,'Martinez','Gerico Nicolas','BS Computer Science','Accounting Office','Window 5',NULL,'July','2021-2022','2022-06-23','2022-07-25',NULL,NULL),(9,1803924,'Loreno','Mary Joy','BS Computer Science','Admission Office','Front Desk',NULL,'September','2021-2022','2022-09-05','2022-10-01',NULL,NULL),(10,1801958,'Ruaya','Nhecy','BS Computer Science','Admission Office','Carding',NULL,'July','2021-2022','2022-06-23','2022-07-25',NULL,NULL),(11,1802442,'Landicho','Harold','BS Computer Science','Accounting Office','Encoding',NULL,'July','2021-2022','2022-06-23','2022-07-25',NULL,NULL),(12,1801806,'Flores','Ana Lyn','BS Computer Science','Accounting Office','Encoding',NULL,'August','2021-2022','2022-07-25','2022-09-01',NULL,NULL),(13,1801090,'Morabe','Enrico Dominic','BS Computer Science','Admission Office','Background Investigation',NULL,'July','2021-2022','2022-06-23','2022-07-25',NULL,NULL);
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

-- Dump completed on 2022-10-03  6:36:10
