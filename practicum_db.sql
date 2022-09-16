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
  `Id` int NOT NULL,
  `PracticumID` bigint NOT NULL,
  `PracticumName` varchar(45) DEFAULT NULL,
  `Assignment` char(45) NOT NULL,
  `Date` date NOT NULL,
  `TimeLogIn_AM` time NOT NULL,
  `TimeLogOut_AM` time NOT NULL,
  `TimeLogIn_PM` time NOT NULL,
  `TimeLogOut_PM` time NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `PracticumID_idx` (`PracticumID`),
  KEY `Assignment_idx` (`Assignment`),
  KEY `PracticumName_idx` (`PracticumName`),
  CONSTRAINT `Assignment` FOREIGN KEY (`Assignment`) REFERENCES `practicum` (`Assignment`),
  CONSTRAINT `PracticumID` FOREIGN KEY (`PracticumID`) REFERENCES `practicum` (`PracticumID`),
  CONSTRAINT `PracticumName` FOREIGN KEY (`PracticumName`) REFERENCES `practicum` (`PracticumName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendance`
--

LOCK TABLES `attendance` WRITE;
/*!40000 ALTER TABLE `attendance` DISABLE KEYS */;
/*!40000 ALTER TABLE `attendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `practicum`
--

DROP TABLE IF EXISTS `practicum`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `practicum` (
  `Id` int NOT NULL,
  `PracticumID` bigint NOT NULL,
  `PracticumName` varchar(45) NOT NULL,
  `Course` char(45) NOT NULL,
  `ContactNumber` bigint NOT NULL,
  `Venue` char(45) NOT NULL,
  `Assignment` char(45) NOT NULL,
  `TotalHours` bigint DEFAULT NULL,
  `Batch` char(45) NOT NULL,
  `DateTimeCreated` datetime DEFAULT NULL,
  `DateTimeUpdated` datetime DEFAULT NULL,
  PRIMARY KEY (`PracticumID`),
  KEY `PracticumName` (`PracticumName`),
  KEY `Assignment` (`Assignment`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `practicum`
--

LOCK TABLES `practicum` WRITE;
/*!40000 ALTER TABLE `practicum` DISABLE KEYS */;
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

-- Dump completed on 2022-09-17  2:31:54
