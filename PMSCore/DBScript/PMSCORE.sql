-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: pms
-- ------------------------------------------------------
-- Server version	8.0.23

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
-- Table structure for table `tbl_branch`
--

DROP TABLE IF EXISTS `tbl_branch`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_branch` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CompanyId` int NOT NULL,
  `BranchName` varchar(100) NOT NULL,
  `PhoneNo` varchar(50) DEFAULT NULL,
  `EmailId` varchar(50) DEFAULT NULL,
  `Address` varchar(500) DEFAULT NULL,
  `IsActive` tinyint DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_branch`
--

LOCK TABLES `tbl_branch` WRITE;
/*!40000 ALTER TABLE `tbl_branch` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_branch` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_company`
--

DROP TABLE IF EXISTS `tbl_company`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_company` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `LabName` varchar(100) DEFAULT NULL,
  `SloganName` varchar(50) DEFAULT NULL,
  `PhoneNo` varchar(50) DEFAULT NULL,
  `EmailId` varchar(50) DEFAULT NULL,
  `Website` varchar(50) DEFAULT NULL,
  `Address` varchar(200) DEFAULT NULL,
  `CompanyLogo` varchar(500) DEFAULT NULL,
  `ShowDetail` tinyint DEFAULT NULL,
  `IsActive` tinyint DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_company`
--

LOCK TABLES `tbl_company` WRITE;
/*!40000 ALTER TABLE `tbl_company` DISABLE KEYS */;
INSERT INTO `tbl_company` VALUES (1,'demo','demo','000000000000',NULL,NULL,'noida',NULL,NULL,1,'2021-04-30 03:37:41',NULL,0),(2,'demo','demo','000000000000',NULL,NULL,'noida',NULL,NULL,1,'2021-04-30 03:37:41',NULL,0),(3,'demo','demo','000000000000',NULL,NULL,'noida',NULL,NULL,1,'2021-04-30 03:38:11',NULL,0),(4,'demo','demo','000000000000',NULL,NULL,'noida',NULL,NULL,1,'2021-04-30 03:38:32',NULL,0),(5,'demo','demo','000000000000',NULL,NULL,'noida',NULL,NULL,1,'2021-04-30 03:40:29',NULL,0),(6,'demo','demo','000000000000',NULL,NULL,'noida',NULL,NULL,1,'2021-04-30 03:40:57',NULL,0),(7,'demo','demo','000000000000',NULL,NULL,'noida',NULL,NULL,1,'2021-04-30 03:42:16',NULL,0),(8,'demo','demo','000000000000',NULL,NULL,'noida',NULL,NULL,1,'2021-04-30 03:42:57',NULL,0);
/*!40000 ALTER TABLE `tbl_company` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_doctor`
--

DROP TABLE IF EXISTS `tbl_doctor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_doctor` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `DocReferenceNo` varchar(20) DEFAULT NULL,
  `DoctorName` varchar(50) DEFAULT NULL,
  `Gender` bigint DEFAULT NULL,
  `MobileNo` bigint DEFAULT NULL,
  `EmailId` varchar(50) DEFAULT NULL,
  `Address` varchar(200) DEFAULT NULL,
  `Specialization` bigint DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  `CID` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_doctor`
--

LOCK TABLES `tbl_doctor` WRITE;
/*!40000 ALTER TABLE `tbl_doctor` DISABLE KEYS */;
INSERT INTO `tbl_doctor` VALUES (5,'','DoctorName',2,123456789,'email.com','updateaddresssss',41,'2021-05-30 10:37:03','2021-05-30 15:53:40',0,0),(6,'','DoctorNameupdate',2,12345678900000,'emailupdate','addressupdate',41,'2021-05-30 14:58:08','2021-05-30 15:24:02',0,0),(8,'','DoctorName',2,12345678900000,'email.com','updateaddresssss',41,'2021-05-30 15:49:22',NULL,0,0),(9,'','DoctorName',2,12345678900000,'email.com','addresssssdfsaf',41,'2021-05-30 15:50:51','2021-05-30 16:36:34',0,0),(10,'','DoctorName',2,12345678900000,NULL,NULL,0,'2021-05-30 16:10:03',NULL,0,0);
/*!40000 ALTER TABLE `tbl_doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_doctorcommisondetails`
--

DROP TABLE IF EXISTS `tbl_doctorcommisondetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_doctorcommisondetails` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `DoctorId` int DEFAULT NULL,
  `DepartmentId` int DEFAULT NULL,
  `CommissionAmount` decimal(18,2) DEFAULT NULL,
  `PaidAmount` decimal(18,2) DEFAULT NULL,
  `CommissonCreatedDate` datetime DEFAULT NULL,
  `CommissionPaidDate` datetime DEFAULT NULL,
  `PaidStatus` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_doctorcommisondetails`
--

LOCK TABLES `tbl_doctorcommisondetails` WRITE;
/*!40000 ALTER TABLE `tbl_doctorcommisondetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_doctorcommisondetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_doctorcommission`
--

DROP TABLE IF EXISTS `tbl_doctorcommission`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_doctorcommission` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `DoctorId` int DEFAULT NULL,
  `DepartmentId` int DEFAULT NULL,
  `CommissionInRupees` int DEFAULT NULL,
  `CommissionInPercentage` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_doctorcommission`
--

LOCK TABLES `tbl_doctorcommission` WRITE;
/*!40000 ALTER TABLE `tbl_doctorcommission` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_doctorcommission` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_expense`
--

DROP TABLE IF EXISTS `tbl_expense`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_expense` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ExpReferenceNo` int DEFAULT NULL,
  `Type` int DEFAULT NULL,
  `PaidTo` varchar(50) DEFAULT NULL,
  `Amount` decimal(18,2) DEFAULT NULL,
  `Date` datetime DEFAULT NULL,
  `PaymentType` int DEFAULT NULL,
  `BankName` varchar(50) DEFAULT NULL,
  `ChequeNo` varchar(50) DEFAULT NULL,
  `ChequeDate` datetime DEFAULT NULL,
  `CardTransactionNo` varchar(50) DEFAULT NULL,
  `ConfirmAmount` decimal(18,2) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastUpdatedDate` datetime DEFAULT NULL,
  `CID` int DEFAULT NULL,
  `BID` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_expense`
--

LOCK TABLES `tbl_expense` WRITE;
/*!40000 ALTER TABLE `tbl_expense` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_expense` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_hospitalstaff`
--

DROP TABLE IF EXISTS `tbl_hospitalstaff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_hospitalstaff` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `StaffReferenceId` varchar(20) DEFAULT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `MobileNo` bigint DEFAULT NULL,
  `EmailId` bigint DEFAULT NULL,
  `Gandar` bigint DEFAULT NULL,
  `MritalStatus` bigint DEFAULT NULL,
  `SpauseName` varchar(100) DEFAULT NULL,
  `DateOfBirth` datetime DEFAULT NULL,
  `AnniversaryDate` datetime DEFAULT NULL,
  `StaffType` bigint DEFAULT NULL,
  `Address` varchar(500) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  `CID` bigint DEFAULT NULL,
  `UserId` bigint DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_hospitalstaff`
--

LOCK TABLES `tbl_hospitalstaff` WRITE;
/*!40000 ALTER TABLE `tbl_hospitalstaff` DISABLE KEYS */;
INSERT INTO `tbl_hospitalstaff` VALUES (1,NULL,'Mohd','Ali',9015505890,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'2021-06-25 19:49:40',NULL,0,0);
/*!40000 ALTER TABLE `tbl_hospitalstaff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_master`
--

DROP TABLE IF EXISTS `tbl_master`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_master` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  `IsActive` tinyint DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  `CID` int DEFAULT NULL,
  `BID` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_master`
--

LOCK TABLES `tbl_master` WRITE;
/*!40000 ALTER TABLE `tbl_master` DISABLE KEYS */;
INSERT INTO `tbl_master` VALUES (1,'Gender',1,'2021-03-13 21:26:51',NULL,0,0,0),(2,'Relation',1,'2021-03-13 21:26:52',NULL,0,0,0),(3,'Religion',1,'2021-03-13 21:26:52',NULL,0,0,0),(4,'NamePrefix',1,'2021-03-13 21:26:52',NULL,0,0,0),(5,'Specialization',1,'2021-03-13 21:26:52',NULL,0,0,0),(6,'EmployeeType',1,'2021-03-13 21:26:52',NULL,0,0,0),(7,'ProfileName',1,'2021-03-13 21:26:52',NULL,0,0,0),(8,'PathologyDepartment',1,'2021-03-13 21:26:52',NULL,0,0,0),(9,'TestHead',1,'2021-03-13 21:26:52',NULL,0,0,0),(10,'ExpenseType',1,'2021-03-13 21:26:53',NULL,0,0,0),(11,'MritalStatus',1,'2021-03-13 21:26:53',NULL,0,0,0),(12,'TestType',1,'2021-05-29 17:20:39',NULL,0,0,0),(13,'SampleType',1,'2021-06-19 10:02:13',NULL,0,0,0);
/*!40000 ALTER TABLE `tbl_master` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_masterdetail`
--

DROP TABLE IF EXISTS `tbl_masterdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_masterdetail` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MID` int DEFAULT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Rate` decimal(18,2) DEFAULT NULL,
  `PrintName` varchar(50) DEFAULT NULL,
  `Status` tinyint DEFAULT NULL,
  `Remarks` varchar(255) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  `CID` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_masterdetail`
--

LOCK TABLES `tbl_masterdetail` WRITE;
/*!40000 ALTER TABLE `tbl_masterdetail` DISABLE KEYS */;
INSERT INTO `tbl_masterdetail` VALUES (2,1,'Male',20.00,'M',1,'0000','2021-03-20 06:09:37',NULL,0,0),(3,7,'Lipid profile',0.00,'Lipid Profile',1,'Remarks','2021-03-20 15:45:44',NULL,0,0),(4,6,'Reception',0.00,'Receptions',1,'Employee type','2021-03-20 15:47:43','2021-03-20 16:44:45',0,0),(5,10,'Direct Expenses',0.00,'PrintName',1,'Remarks','2021-03-20 15:49:34','2021-04-19 13:34:35',0,0),(6,1,'Female',0.00,'F',1,'Remarks','2021-03-20 15:52:23',NULL,0,0),(7,11,'Single',0.00,'Single',1,'remarks','2021-03-20 15:59:28','2021-05-16 11:13:57',0,0),(8,2,'Husband',0.00,'PrintName',1,'Remarks','2021-03-20 16:04:42',NULL,0,0),(9,11,'Married',0.00,'Married',1,'Remarks','2021-03-20 16:11:53','2021-05-16 11:13:34',0,0),(10,10,'Other',0.00,'Other',1,'sdfaf','2021-03-20 16:13:57',NULL,0,0),(16,4,'Mr.',0.00,'Mr.',1,'asdfaf','2021-03-20 16:17:11',NULL,0,0),(17,4,'Master',0.00,'Master',1,'asdfa','2021-03-20 16:18:21',NULL,0,0),(18,7,'New Name',50.00,'New Name',1,'Reactive','2021-03-20 16:19:01',NULL,0,0),(20,3,'Hindu',0.00,'Hindu',1,'Remarks','2021-03-20 16:51:28','2021-03-20 16:51:36',0,0),(21,9,'New Test Head',0.00,'TD',1,'New Test Head Remarks','2021-03-20 16:52:06','2021-03-20 16:52:14',0,0),(22,1,'Other',0.00,'Other',1,'Hello gender','2021-03-21 21:14:44',NULL,0,0),(24,6,'Hello',0.00,'Hello',1,'fsds','2021-03-21 21:36:41','2021-03-21 22:30:08',0,0),(26,11,'other',0.00,'other',1,'afdadsf','2021-03-21 21:41:56','2021-03-21 21:42:28',0,0),(27,0,NULL,0.00,NULL,1,NULL,'2021-03-22 06:13:41',NULL,0,0),(28,0,NULL,0.00,NULL,0,NULL,'2021-03-22 06:13:49',NULL,0,0),(29,0,NULL,0.00,NULL,1,NULL,'2021-03-22 06:14:29',NULL,0,0),(30,0,NULL,0.00,NULL,1,NULL,'2021-03-22 06:14:33',NULL,0,0),(35,8,'LAB',0.00,'LAB',1,NULL,'2021-05-22 22:22:19','2021-05-22 22:23:03',0,0),(36,8,'X-RAY',0.00,'X-RAY',1,NULL,'2021-05-22 22:22:47',NULL,0,0),(37,12,'Normal',0.00,'Normal',1,NULL,'2021-05-29 17:22:08',NULL,0,0),(38,12,'Heading',0.00,'Heading',1,NULL,'2021-05-29 17:22:21',NULL,0,0),(40,4,'Dr.',0.00,'Dr.',1,NULL,'2021-05-30 08:09:01',NULL,0,0),(41,5,'Special',0.00,'Special',1,NULL,'2021-05-30 16:01:37',NULL,0,0),(42,6,'sda',0.00,'asdf',1,NULL,'2021-05-30 16:32:12',NULL,0,0),(43,13,'Blood',0.00,'Blood',1,NULL,'2021-06-19 10:03:09',NULL,0,0);
/*!40000 ALTER TABLE `tbl_masterdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_module`
--

DROP TABLE IF EXISTS `tbl_module`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_module` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ModuleName` varchar(100) DEFAULT NULL,
  `CID` int DEFAULT NULL,
  `BID` int DEFAULT NULL,
  `IsActive` tinyint DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_module`
--

LOCK TABLES `tbl_module` WRITE;
/*!40000 ALTER TABLE `tbl_module` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_module` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_patient`
--

DROP TABLE IF EXISTS `tbl_patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_patient` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `PataientReferenceNo` varchar(20) DEFAULT NULL,
  `Title` bigint NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Age` datetime NOT NULL,
  `Gender` bigint DEFAULT NULL,
  `MobileNo` bigint DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Address` varchar(500) DEFAULT NULL,
  `MaritalStatus` bigint DEFAULT NULL,
  `Religion` bigint DEFAULT NULL,
  `Relation` bigint DEFAULT NULL,
  `RelationName` varchar(50) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  `CID` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_patient`
--

LOCK TABLES `tbl_patient` WRITE;
/*!40000 ALTER TABLE `tbl_patient` DISABLE KEYS */;
INSERT INTO `tbl_patient` VALUES (1,NULL,16,'demo','2021-06-25 21:05:29',2,9015505890,'email@email.com','addresssss',NULL,NULL,NULL,NULL,'2021-06-25 21:05:29',NULL,0,0);
/*!40000 ALTER TABLE `tbl_patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_payment`
--

DROP TABLE IF EXISTS `tbl_payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_payment` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `BookingId` bigint NOT NULL,
  `DepartmentName` varchar(50) DEFAULT NULL,
  `TotalAmount` decimal(18,2) DEFAULT NULL,
  `DiscountAmount` decimal(18,2) DEFAULT NULL,
  `PaidAmount` decimal(18,2) DEFAULT NULL,
  `BalanceAmount` decimal(18,2) DEFAULT NULL,
  `DepositDate` datetime DEFAULT NULL,
  `PaymentType` bigint DEFAULT NULL,
  `BankName` varchar(255) DEFAULT NULL,
  `ChequeNo` varchar(50) DEFAULT NULL,
  `ChequeDate` datetime DEFAULT NULL,
  `CardTransactionNo` varchar(50) DEFAULT NULL,
  `ConfirmAmount` varchar(3) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  `CID` bigint DEFAULT NULL,
  `UserId` bigint DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_payment`
--

LOCK TABLES `tbl_payment` WRITE;
/*!40000 ALTER TABLE `tbl_payment` DISABLE KEYS */;
INSERT INTO `tbl_payment` VALUES (1,1,'Pathology',550.00,0.00,550.00,0.00,'2021-06-25 21:05:30',1,NULL,NULL,NULL,NULL,NULL,'2021-06-25 21:05:30',NULL,0,0),(2,2,'Pathology',650.00,0.00,650.00,0.00,'2021-06-26 07:29:35',1,NULL,NULL,NULL,NULL,NULL,'2021-06-26 07:29:35',NULL,0,0);
/*!40000 ALTER TABLE `tbl_payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_profiledetails`
--

DROP TABLE IF EXISTS `tbl_profiledetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_profiledetails` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `ProfileId` bigint NOT NULL,
  `TestId` bigint DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `CID` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_profiledetails`
--

LOCK TABLES `tbl_profiledetails` WRITE;
/*!40000 ALTER TABLE `tbl_profiledetails` DISABLE KEYS */;
INSERT INTO `tbl_profiledetails` VALUES (5,3,7,'2021-06-17 07:45:34',0,0),(7,3,20,'2021-06-17 08:08:03',0,0),(8,3,20,'2021-06-17 20:10:06',0,0),(9,3,16,'2021-06-17 20:10:13',0,0),(11,18,7,'2021-06-27 11:53:55',0,0),(12,18,12,'2021-06-27 11:53:57',0,0),(13,18,2,'2021-06-27 11:54:01',0,0);
/*!40000 ALTER TABLE `tbl_profiledetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_testbooking`
--

DROP TABLE IF EXISTS `tbl_testbooking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_testbooking` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `PatientId` bigint NOT NULL,
  `BookingReferenceNo` int DEFAULT NULL,
  `RefBy` bigint DEFAULT NULL,
  `SampleBy` bigint DEFAULT NULL,
  `SampleType` bigint DEFAULT NULL,
  `BookingDate` datetime DEFAULT NULL,
  `ReportDate` datetime DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastUpdatedDate` datetime DEFAULT NULL,
  `CID` bigint DEFAULT NULL,
  `UserId` bigint DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_testbooking`
--

LOCK TABLES `tbl_testbooking` WRITE;
/*!40000 ALTER TABLE `tbl_testbooking` DISABLE KEYS */;
INSERT INTO `tbl_testbooking` VALUES (1,1,NULL,6,1,43,'2021-06-25 21:05:29',NULL,'2021-06-25 21:05:29',NULL,0,0),(2,1,NULL,5,1,43,'2021-06-26 07:29:35',NULL,'2021-06-26 07:29:35',NULL,0,0);
/*!40000 ALTER TABLE `tbl_testbooking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_testbookingdetails`
--

DROP TABLE IF EXISTS `tbl_testbookingdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_testbookingdetails` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `BookingId` bigint DEFAULT NULL,
  `TestId` bigint DEFAULT NULL,
  `HeadId` bigint DEFAULT NULL,
  `ProfileId` bigint DEFAULT NULL,
  `Rate` decimal(18,2) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastUpdatedDate` datetime DEFAULT NULL,
  `CID` bigint DEFAULT NULL,
  `UserId` bigint DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_testbookingdetails`
--

LOCK TABLES `tbl_testbookingdetails` WRITE;
/*!40000 ALTER TABLE `tbl_testbookingdetails` DISABLE KEYS */;
INSERT INTO `tbl_testbookingdetails` VALUES (1,1,6,2,0,500.00,'2021-06-25 21:05:29',NULL,0,0),(2,1,0,0,18,50.00,'2021-06-25 21:05:29',NULL,0,0),(4,2,6,2,0,500.00,'2021-06-26 07:29:35',NULL,0,0),(5,2,2,2,0,100.00,'2021-06-26 07:29:35',NULL,0,0),(6,2,0,0,18,50.00,'2021-06-26 07:29:35',NULL,0,0);
/*!40000 ALTER TABLE `tbl_testbookingdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_testbookingdraft`
--

DROP TABLE IF EXISTS `tbl_testbookingdraft`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_testbookingdraft` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `TestName` varchar(50) DEFAULT NULL,
  `TestId` bigint NOT NULL,
  `HeadId` bigint NOT NULL,
  `ProfileId` bigint NOT NULL,
  `Rate` decimal(18,2) NOT NULL,
  `CID` bigint DEFAULT NULL,
  `UserId` bigint DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_testbookingdraft`
--

LOCK TABLES `tbl_testbookingdraft` WRITE;
/*!40000 ALTER TABLE `tbl_testbookingdraft` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_testbookingdraft` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_testhead`
--

DROP TABLE IF EXISTS `tbl_testhead`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_testhead` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `DepartmentId` bigint NOT NULL,
  `HeadName` varchar(100) DEFAULT NULL,
  `PrintName` varchar(100) DEFAULT NULL,
  `IsActive` varchar(1) DEFAULT NULL,
  `CID` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_testhead`
--

LOCK TABLES `tbl_testhead` WRITE;
/*!40000 ALTER TABLE `tbl_testhead` DISABLE KEYS */;
INSERT INTO `tbl_testhead` VALUES (2,35,'New test head','test head','1',0,0,'2021-05-29 15:55:17',NULL);
/*!40000 ALTER TABLE `tbl_testhead` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_testmaster`
--

DROP TABLE IF EXISTS `tbl_testmaster`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_testmaster` (
  `Id` bigint NOT NULL AUTO_INCREMENT,
  `TestReferenceNo` varchar(20) DEFAULT NULL,
  `DepartmentId` bigint NOT NULL,
  `HeadId` bigint NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Rate` decimal(18,2) DEFAULT NULL,
  `DefaultValue` varchar(50) DEFAULT NULL,
  `RangeFrom` varchar(50) DEFAULT NULL,
  `RangeTo` varchar(50) DEFAULT NULL,
  `Unit` varchar(50) DEFAULT NULL,
  `Formula` varchar(100) DEFAULT NULL,
  `Method` varchar(100) DEFAULT NULL,
  `Interpretations` varchar(5000) DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  `CID` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_testmaster`
--

LOCK TABLES `tbl_testmaster` WRITE;
/*!40000 ALTER TABLE `tbl_testmaster` DISABLE KEYS */;
INSERT INTO `tbl_testmaster` VALUES (1,'',35,2,'new test',200.00,NULL,'0','20','uml',NULL,NULL,NULL,'2021-05-30 17:52:28',NULL,0,0),(2,'',35,2,'testName',100.00,NULL,'0','10',NULL,NULL,NULL,NULL,'2021-05-30 17:56:57',NULL,0,0),(3,'',35,2,'testwithinterpretations',2000.00,'Normal',NULL,NULL,NULL,NULL,NULL,'<p><strong>Test:This is demo cycle for save ck editor data into tha database</strong></p>\n','2021-05-30 18:10:22',NULL,0,0),(4,'',35,2,'testwithinterpretations',2000.00,'Normal',NULL,NULL,NULL,'30/34-35','30+20+40+20=100','<p><strong>Test:This is demo cycle for save ck editor data into tha database</strong></p>\n','2021-05-30 18:11:32',NULL,0,0),(5,'',35,2,'testwithinterpretations',2000.00,'Normal',NULL,NULL,NULL,'30/34-35','30+20+40+20=100','<p><strong>Test:This is demo cycle for save ck editor data into tha database</strong></p>\n','2021-05-30 18:11:59',NULL,0,0),(6,'',35,2,'test demo',500.00,'Normal','0','150','uml',NULL,NULL,'<p>hello dear this is interpretation</p>\n','2021-06-04 20:07:26',NULL,0,0),(7,'',35,2,'Hello test',0.00,'de','0','100','unit','formula','mehtod','','2021-06-04 20:59:07',NULL,0,0),(8,'',35,2,'Hello test',0.00,'default range','0','100','unit','formula','mehtod','','2021-06-04 21:37:56',NULL,0,0),(9,'',35,2,'Hello test',10000.00,'default range','100','500','kg','formula','mehtod','','2021-06-04 21:38:47',NULL,0,0),(10,'',35,2,'new',10000.00,'default range','100','500','kg','formula','condition','<p>interpretations</p>\n','2021-06-04 21:38:59',NULL,0,0),(11,'',35,2,'testwithinterpretations',2000.00,'Normal','100','500','kkk',NULL,NULL,'<p>hjgjklhtyjhcgfvccfbv</p>\n','2021-06-04 21:43:55',NULL,0,0),(12,'',35,2,'sdf',90.00,NULL,NULL,NULL,NULL,NULL,NULL,'<p>sdfgdhsdfh</p>\n','2021-06-04 21:58:03',NULL,0,0),(13,'',35,2,'testwithinterpretations',2000.00,'Normal','100','500','gg','30/34-35','30+20+40+20=100','<p>sdfhjkl;kjhgfdsfgh</p>\n','2021-06-04 22:10:56',NULL,0,0),(14,'',35,2,'testwithinterpretations',2000.00,NULL,NULL,'500','date','formula','30+20+40+20=100',NULL,'2021-06-12 11:52:37',NULL,0,0),(15,'',35,2,'new',2000.00,'Normal','100','500','second date','30/34-35','30+20+40+20=100','<p>mnnnl;kjl;j;l</p>\n','2021-06-12 11:53:11',NULL,0,0),(16,'',35,2,'new',2000.00,'Normal','100','500','ASDDAFEWFDFDSA','30/34-35','30+20+40+20=100','<p>SADFFSAFDFASDsdfgsdgg</p>\n','2021-06-12 11:54:45',NULL,0,0),(17,'',35,2,'testwithinterpretations',2000.00,'Normal','100','500','vb','30/34-35','30+20+40+20=100','<p>vbnfgdgds dfgdds sdfgd</p>\n','2021-06-12 11:59:19',NULL,0,0),(18,'',35,2,'testwithinterpretations',2000.00,'Normal','100','500','dfssafa','30/34-35','30+20+40+20=100','<p>sdfasf sdfsdf asdfsdasdfd fsadfs asdfs</p>\n','2021-06-12 12:19:24',NULL,0,0),(19,'',35,2,'testwithinterpretations',2000.00,NULL,NULL,NULL,NULL,NULL,NULL,'<p>rsdffgb</p>\n','2021-06-12 12:21:19',NULL,0,0),(20,'',35,2,'testwithinterpretations',2000.00,NULL,NULL,NULL,NULL,'30/34-35','30+20+40+20=100','<p>WAEFSHJKL;KJHDSFAFGJK</p>\n','2021-06-13 07:02:09',NULL,0,0);
/*!40000 ALTER TABLE `tbl_testmaster` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_testresult`
--

DROP TABLE IF EXISTS `tbl_testresult`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_testresult` (
  `Id` int NOT NULL,
  `BookingId` int DEFAULT NULL,
  `TestId` int DEFAULT NULL,
  `TestName` varchar(50) DEFAULT NULL,
  `Result` varchar(50) DEFAULT NULL,
  `RangeFrom` varchar(50) DEFAULT NULL,
  `RangeTo` varchar(50) DEFAULT NULL,
  `Unit` varchar(50) DEFAULT NULL,
  `Note` varchar(300) DEFAULT NULL,
  `InterPretation` varchar(5000) DEFAULT NULL,
  `Precaution` varchar(5000) DEFAULT NULL,
  `Status` tinyint DEFAULT NULL,
  `CID` int DEFAULT NULL,
  `BID` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_testresult`
--

LOCK TABLES `tbl_testresult` WRITE;
/*!40000 ALTER TABLE `tbl_testresult` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_testresult` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_userlogin`
--

DROP TABLE IF EXISTS `tbl_userlogin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_userlogin` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `StafId` int NOT NULL,
  `UserName` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `UserType` int NOT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  `BID` int NOT NULL,
  `CID` int NOT NULL,
  `IsActive` tinyint DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_userlogin`
--

LOCK TABLES `tbl_userlogin` WRITE;
/*!40000 ALTER TABLE `tbl_userlogin` DISABLE KEYS */;
INSERT INTO `tbl_userlogin` VALUES (1,0,'admin','admin',0,NULL,NULL,0,0,1),(2,0,'admin2','admin2',0,NULL,NULL,0,0,1),(3,0,'admin2','admin2',0,NULL,NULL,0,0,1),(4,0,'admin3','admin3',0,NULL,NULL,0,0,1);
/*!40000 ALTER TABLE `tbl_userlogin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_userpermission`
--

DROP TABLE IF EXISTS `tbl_userpermission`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_userpermission` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` int DEFAULT NULL,
  `ModuleId` int DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
  `LastModifiedDate` datetime DEFAULT NULL,
  `IsActive` tinyint DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_userpermission`
--

LOCK TABLES `tbl_userpermission` WRITE;
/*!40000 ALTER TABLE `tbl_userpermission` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_userpermission` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'pms'
--
/*!50003 DROP PROCEDURE IF EXISTS `SP_WhileLoop` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_WhileLoop`(
)
BEGIN
DECLARE StrValues varchar(500);
SET StrValues='a,b,c,d,';
label1:WHILE FIND_IN_SET('',StrValues)>0 DO
SET @AmountValue=SUBSTRING_INDEX(StrValues,',',1);  
select @AmountValue;
SET StrValues =  SUBSTR(REPLACE(StrValues,SUBSTRING_INDEX(StrValues,',',1),''),2);
END WHILE label1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_CompanyOperation` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_CompanyOperation`(
IN P_Id bigint,
IN P_LabName varchar(50),
IN P_SloganName varchar(50),
IN P_PhoneNo varchar(50),
IN P_EmailId varchar(50),
IN P_Website varchar(50),
IN P_Status int,
IN P_Address varchar(100),
IN P_CompanyLogo varchar(100),
IN P_ShowDetails int,
IN P_UserId int,
IN P_Action Varchar(1)
)
BEGIN
IF P_Action='I' THEN
INSERT INTO tbl_Company(LabName,SloganName,PhoneNo,EmailId,Website,Address,CompanyLogo,ShowDetail,IsActive,CreatedDate,UserId)
values(P_LabName,P_SloganName,P_PhoneNo,P_EmailId,P_Website,P_Address,P_CompanyLogo,P_ShowDetails,P_Status,Now(),P_UserId);
ELSEIF P_ACTION = 'U' THEN
UPDATE tbl_Company SET NLabName=P_LabName,SloganName=P_SloganName,PhoneNo=PhoneNo,EmailId=EmailId,Website=P_Website,Address=P_Address,CompanyLogo=P_CompanyLogo,ShowDetail=P_ShowDetails,IsActive=P_Status,LastModifiedDate=now(),UserId=P_UserId Where Id=P_Id;
ELSEIF P_ACTION = 'D' THEN
DELETE FROM tbl_Company Where Id=P_Id;
ELSEIF P_ACTION = 'E' THEN
SELECT * FROM tbl_Company Where Id=P_Id;
END IF;
SELECT LabName,SloganName,PhoneNo,EmailId,Website,Address,CompanyLogo,ShowDetail, CASE WHEN IsActive =1  THEN "Active" ELSE "Deactive" END  AS Status FROM tbl_Company order by Id asc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_DoctoreOperations` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_DoctoreOperations`(
IN P_Id bigint,
IN P_Name varchar(50),
IN P_Gender bigint,
IN P_MobileNo bigint,
IN P_EmailId varchar(50),
IN P_Address varchar(50),
IN P_Specialization bigint,
IN P_CID int,
IN P_UserId int,
IN P_Action Varchar(1)
)
BEGIN
IF P_Action='I' THEN
INSERT INTO tbl_doctor(DocReferenceNo,DoctorName,Gender,MobileNo,EmailId,Address,Specialization,CreatedDate,CID,UserId)
values('',P_Name,P_Gender,P_MobileNo,P_EmailId,P_Address,P_Specialization,Now(),P_CID,P_UserId);
ELSEIF P_ACTION = 'U' THEN
UPDATE tbl_doctor SET DoctorName=P_Name,Gender=P_Gender,MobileNo=P_MobileNo,EmailId=P_EmailId,Address=P_Address,Specialization=P_Specialization,LastModifiedDate=Now(),CID=P_CID,UserId=P_UserId Where Id=P_Id;
ELSEIF P_ACTION = 'D' THEN
DELETE FROM tbl_doctor Where Id=P_Id;
ELSEIF P_ACTION = 'E' THEN
SELECT * FROM tbl_doctor Where Id=P_Id;
END IF;
select dc.Id,dc.DoctorName,mdg.Name as Gender,dc.MobileNo,dc.EmailId,dc.Address,mds.Name as Specialization from tbl_doctor As dc 
INNER JOIN tbl_MasterDetail as mdg on dc.Gender=mdg.Id 
INNER JOIN tbl_MasterDetail as mds on dc.Specialization=mds.Id order by dc.Id desc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_GetCommonData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_GetCommonData`(
IN P_MID VARCHAR(500),
IN P_Id long,
IN P_IsTestBooking bool,
IN P_CID long,
IN P_UserId long,
IN P_Action int
)
BEGIN
IF P_Action=1 THEN
Select Id,Name from tbl_Master where IsActive=1 order by Name Asc;
ELSEIF P_ACTION = 2 THEN
CREATE TEMPORARY TABLE MasterDetails(Id INT,TextName VARCHAR(50),MID INT);
label1:WHILE FIND_IN_SET('',P_MID)>0 DO
SET @MID=SUBSTRING_INDEX(P_MID,',',1);
INSERT INTO MasterDetails(Id,TextName,MID)  
select ID,Name,MID From tbl_MasterDetail where Status=1 AND MID=@MID;
SET P_MID =  SUBSTR(P_MID,POSITION(',' IN P_MID)+1,LENGTH(P_MID)-(POSITION(','IN P_MID)-1));
/*SUBSTR(REPLACE(P_MID,SUBSTRING_INDEX(P_MID,',',1),''),2);*/
END WHILE label1;
SELECT Id,TextName as Name,MID FROM MasterDetails;
DROP TEMPORARY TABLE MasterDetails;
ELSEIF P_ACTION = 3 THEN
select Id ,HeadName as Name from tbl_TestHead where IsActive=1 AND DepartmentId=P_Id;
SELECT Id,Name,Rate,HeadId FROM tbl_TestMaster WHERE HeadId=P_Id ORDER BY Name ASC;
END IF;
IF P_IsTestBooking = true THEN
DELETE FROM tbl_testbookingdraft WHERE CID= P_CID AND UserId=P_UserId;
SELECT Id,DoctorName FROM tbl_Doctor Order by DoctorName asc;
SELECT Id,CONCAT(FirstName,' ',LastName) AS StaffName FROM tbl_HospitalStaff Order By FirstName ASC;
SELECT Id,Name,Rate from tbl_MasterDetail where MID=7 Order By Name ASC;
END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_GetMasterDetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_GetMasterDetails`(
IN P_MID VARCHAR(500)
)
BEGIN
CREATE TEMPORARY TABLE MasterDetails(Id INT,TextName VARCHAR(50),MID INT);
label1:WHILE FIND_IN_SET('',P_MID)>0 DO
SET @MID=SUBSTRING_INDEX(P_MID,',',1);
INSERT INTO MasterDetails(Id,TextName,MID)  
select ID,Name,MID From tbl_MasterDetail where MID=@MID;
SET P_MID =  SUBSTR(REPLACE(P_MID,SUBSTRING_INDEX(P_MID,',',1),''),2);
END WHILE label1;
SELECT Id,TextName as Name,MID FROM MasterDetails;
DROP TEMPORARY TABLE MasterDetails;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_GetProfileDetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_GetProfileDetails`(
IN P_Id bigint,
IN P_ProfileId bigint,
IN P_TestId bigint,
IN P_CID int,
IN P_UserId int,
In P_Action Varchar(1)
)
BEGIN
IF P_Action='I' THEN
INSERT INTO tbl_Profiledetails(ProfileId,TestId,CreatedDate,CID,UserId)
values(P_ProfileId,P_TestId,now(),P_CID,P_UserId);
ELSEIF P_Action='D' THEN
Delete from tbl_Profiledetails where Id=P_Id;
END IF;
select PD.Id,MD.Name as ProfileName,TM.Name as TestName from tbl_Profiledetails as PD INNER JOIN tbl_MasterDetail AS MD ON PD.ProfileId=MD.Id
INNER JOIN tbl_TestMaster AS TM ON PD.TestId=TM.Id where PD.ProfileId=P_ProfileId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_MaintainMasterOperation` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_MaintainMasterOperation`(
IN P_Id bigint,
IN P_MID int,
IN P_Name varchar(50),
IN P_PtintName varchar(50),
IN P_Status int,
IN P_Rate decimal(18,2),
IN P_Remarks varchar(100),
IN P_CID int,
IN P_UserId int,
IN P_Action Varchar(1)
)
BEGIN
IF P_Action='I' THEN
INSERT INTO tbl_MasterDetail(MID,NAME,Rate,PrintName,Status,Remarks,CreatedDate,CID,UserId)
values(P_MID,P_Name,P_Rate,P_PtintName,P_Status,P_Remarks,Now(),P_CID,P_UserId);
ELSEIF P_ACTION = 'U' THEN
UPDATE tbl_MasterDetail SET NAME=P_Name,Rate=P_Rate,PrintName=P_PtintName,Status=P_Status,Remarks=P_Remarks,LastModifiedDate=Now(),UserId=P_UserId Where Id=P_Id AND MID=P_MID;
ELSEIF P_ACTION = 'D' THEN
DELETE FROM tbl_MasterDetail Where Id=P_Id AND MID=P_MID;
ELSEIF P_ACTION = 'E' THEN
SELECT * FROM tbl_MasterDetail Where Id=P_Id AND MID=P_MID;
END IF;
SELECT Id,Name,Rate,PrintName, CASE WHEN Status =1  THEN "Active" ELSE "Deactive" END  AS Status ,Remarks FROM tbl_MasterDetail WHERE MID=P_MID order by Name asc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_SearchBookingData` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_SearchBookingData`(
IN P_Id long,
IN P_FromDate datetime,
IN P_ToDate datetime,
IN P_CID long,
IN P_UserId long,
IN P_Action long
)
BEGIN
IF P_Action=1 THEN
SELECT TB.Id,P.Name as PatientName,MDP.Name as Gender,P.Age,MD.Name as SampleType,P.Address,TB.BookingDate FROM tbl_TestBooking AS TB 
INNER JOIN tbl_Patient as P ON TB.PatientId=P.Id INNER JOIN tbl_MasterDetail AS MD  ON TB.SampleType=MD.Id 
INNER JOIN tbl_MasterDetail AS MDP  ON P.Gender=MDP.Id
WHERE DATE_FORMAT(TB.BookingDate, "%d %M %Y")>= DATE_FORMAT(P_FromDate, "%d %M %Y") AND DATE_FORMAT(TB.BookingDate, "%d %M %Y")<=DATE_FORMAT(P_ToDate, "%d %M %Y");
ELSEIF P_Action=2 THEN
SELECT TM.Id,TBD.BookingId,TM.Name as TestName,TM.DefaultValue,TM.RangeFrom,TM.RangeTo,TM.Interpretations FROM tbl_TestBookingdetails AS TBD 
INNER JOIN tbl_TestMaster AS TM ON TBD.TestId=TM.Id where TBD.BookingId=P_Id
UNION ALL
SELECT TM.Id,TBD.BookingId,TM.Name as TestName,TM.DefaultValue,TM.RangeFrom,TM.RangeTo,TM.Interpretations FROM tbl_TestBookingdetails AS TBD 
INNER JOIN tbl_ProfileDetails AS PD ON TBD.ProfileId=PD.ProfileId INNER JOIN tbl_TestMaster AS TM ON TM.Id=PD.TestId where TBD.BookingId=P_Id;
END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_TestBookingDraft` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_TestBookingDraft`(

IN P_Id long,
IN P_TestId long,
IN P_HeadId long,
IN P_ProfileId long,
IN P_Rate decimal(18,2),
IN P_CID long,
IN P_UserId long,
IN P_Action int
)
BEGIN
DECLARE Message int;
IF P_Action=1 THEN
 IF(P_TestId>0) THEN
	IF NOT EXISTS(Select * from tbl_testbookingdraft where TestId=P_TestId AND HeadId=P_HeadId) THEN
		INSERT INTO tbl_testbookingdraft(TestName,TestId,HeadId,ProfileId,Rate,CID,UserId)
        SELECT Name,P_TestId,P_HeadId,P_ProfileId,Rate,P_CID,P_UserId FROM tbl_TestMaster WHERE Id=P_TestId AND HeadId=P_HeadId;
        SET Message=0;
			ELSE
				SET Message=1;
			END IF;
 ELSE IF NOT EXISTS(Select * from tbl_testbookingdraft where ProfileId=P_ProfileId) THEN
		INSERT INTO tbl_testbookingdraft(TestName,TestId,HeadId,ProfileId,Rate,CID,UserId)
        SELECT Name,P_TestId,P_HeadId,P_ProfileId,Rate,P_CID,P_UserId FROM tbl_MasterDetail WHERE Id=P_ProfileId;
        SET Message=0;
			ELSE
				SET Message=2;
			END IF;
 END IF;
ELSEIF P_Action=2 THEN
DELETE FROM tbl_testbookingdraft WHERE Id=P_Id;
 SET Message=0;
END IF;
Select Message as Flag;
SELECT * FROM tbl_testbookingdraft;
SELECT SUM(Rate) as TotalAmount FROM tbl_testbookingdraft;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_TestBookingOperations` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_TestBookingOperations`(
IN P_Id long,
IN P_PatientType long,
IN P_TitleId long,
IN P_PatientName VARCHAR(50),
IN P_GendarId long,
IN P_PatientAge DATETIME,
IN P_MobileNo long,
IN P_Email VARCHAR(50),
IN P_Address VARCHAR(50),
IN P_ReferredById long,
IN P_SampleById long,
IN P_SampleTypeId long,
IN P_TotalAmount Decimal(18,2),
IN P_DiscountAmount Decimal(18,2),
IN P_PaidAmount Decimal(18,2),
IN P_BalanceAmount Decimal(18,2),
IN P_CID long,
IN P_UserId long,
IN P_Action long
)
BEGIN
DECLARE NewPatientId,NewBookingId BIGINT;
IF(P_Action=1)THEN
IF(P_PatientType=1)THEN
INSERT INTO tbl_Patient(Title,Name,Age,Gender,MobileNo,Email,Address,CreatedDate,CID,UserId)VALUES(P_TitleId,P_PatientName,now(),P_GendarId,P_MobileNo,P_Email,P_Address,now(),P_CID,P_UserId);
SET NewPatientId=(Select LAST_INSERT_ID());
ELSE
SET NewPatientId=P_Id;
END IF;
INSERT INTO tbl_TestBooking(PatientId,RefBy,SampleBy,SampleType,BookingDate,CreatedDate,CID,UserId)VALUES(NewPatientId,P_ReferredById,P_SampleById,P_SampleTypeId,now(),Now(),P_CID,P_UserId);
SET NewBookingId=(Select LAST_INSERT_ID());
INSERT INTO tbl_TestBookingDetails(BookingId,TestId,HeadId,ProfileId,Rate,CreatedDate,CID,UserId)
SELECT NewBookingId,TestId, HeadId, ProfileId,Rate,now(), CID, UserId FROM tbl_testbookingdraft;
INSERT INTO tbl_Payment(BookingId,DepartmentName,TotalAmount,DiscountAmount,PaidAmount,BalanceAmount,DepositDate,PaymentType,CreatedDate,CID,UserId)
VALUES(NewBookingId,'Pathology',P_TotalAmount,P_DiscountAmount,P_PaidAmount,P_BalanceAmount,now(),1,now(),P_CID,P_UserId);
END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_TestHead` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_TestHead`(
IN P_Id bigint,
IN P_DepartmentId bigint,
IN P_Name varchar(50),
IN P_PtintName varchar(50),
IN P_Status int,
IN P_CID int,
IN P_UserId int,
IN P_Action Varchar(1)
)
BEGIN
IF P_Action='I' THEN
INSERT INTO tbl_TestHead(DepartmentId,HeadName,PrintName,IsActive,CreatedDate,CID,UserId)
values(P_DepartmentId,P_Name,P_PtintName,P_Status,Now(),P_CID,P_UserId);
ELSEIF P_ACTION = 'U' THEN
UPDATE tbl_TestHead SET HeadName=P_Name,PrintName=P_PtintName,IsActive=P_Status,LastModifiedDate=Now(),UserId=P_UserId Where Id=P_Id AND DepartmentId=P_DepartmentId;
ELSEIF P_ACTION = 'D' THEN
DELETE FROM tbl_TestHead Where Id=P_Id AND DepartmentId=P_DepartmentId;
ELSEIF P_ACTION = 'E' THEN
SELECT * FROM tbl_TestHead Where Id=P_Id AND DepartmentId=P_DepartmentId;
END IF;
SELECT Id,HeadName as Name,PrintName, CASE WHEN IsActive =1  THEN "Active" ELSE "Deactive" END  AS Status FROM tbl_TestHead WHERE DepartmentId=P_DepartmentId order by Name asc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_TestHeadOperations` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_TestHeadOperations`(
IN P_Id bigint,
IN P_DepartmentId bigint,
IN P_Name varchar(50),
IN P_PtintName varchar(50),
IN P_Status int,
IN P_CID int,
IN P_UserId int,
IN P_Action Varchar(1)
)
BEGIN
IF P_Action='I' THEN
INSERT INTO tbl_TestHead(DepartmentId,HeadName,PrintName,IsActive,CreatedDate,CID,UserId)
values(P_DepartmentId,P_Name,P_PtintName,P_Status,Now(),P_CID,P_UserId);
ELSEIF P_ACTION = 'U' THEN
UPDATE tbl_TestHead SET HeadName=P_Name,PrintName=P_PtintName,IsActive=P_Status,LastModifiedDate=Now(),UserId=P_UserId Where Id=P_Id AND DepartmentId=P_DepartmentId;
ELSEIF P_ACTION = 'D' THEN
DELETE FROM tbl_TestHead Where Id=P_Id AND DepartmentId=P_DepartmentId;
ELSEIF P_ACTION = 'E' THEN
SELECT * FROM tbl_TestHead Where Id=P_Id AND DepartmentId=P_DepartmentId;
END IF;
SELECT Id,HeadName as Name,PrintName, CASE WHEN IsActive =1  THEN "Active" ELSE "Deactive" END  AS Status FROM tbl_TestHead WHERE DepartmentId=P_DepartmentId order by Name asc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_TestOperations` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_TestOperations`(
IN P_Id bigint,
IN P_DepartmentId bigint,
IN P_Department_Id bigint,
IN P_HeadId bigint,
IN P_Head_Id bigint,
IN P_Name varchar(50),
IN P_Rate decimal(18,2),
IN P_DefaultValue varchar(50),
IN P_RangeFrom varchar(50),
IN P_RangeTo varchar(50),
IN P_Unit varchar(50),
IN P_Formula varchar(100),
IN P_Method varchar(100),
IN P_Interpretations varchar(5000),
IN P_CID int,
IN P_UserId int,
IN P_Action Varchar(1)
)
BEGIN
IF P_Action='I' THEN
INSERT INTO tbl_TestMaster(TestReferenceNo,DepartmentId,HeadId,Name,Rate,DefaultValue,RangeFrom,RangeTo,Unit,Formula,Method,Interpretations,CreatedDate,CID,UserId)
values('',P_Department_Id, P_Head_Id,P_Name,P_Rate,P_DefaultValue,P_RangeFrom,P_RangeTo,P_Unit,P_Formula,P_Method,P_Interpretations,Now(),P_CID,P_UserId);
ELSEIF P_ACTION = 'U' THEN
UPDATE tbl_TestMaster SET DepartmentId=P_Department_Id, HeadId=P_Head_Id,Name=P_Name,Rate=P_Rate,DefaultValue=P_DefaultValue,RangeFrom=P_RangeFrom,RangeTo=P_RangeTo,Unit=P_Unit,Formula=P_Formula,Method=P_Method,Interpretations=P_Interpretations,LastModifiedDate=Now(),CID=P_CID,UserId=P_UserId Where Id=P_Id;
ELSEIF P_ACTION = 'D' THEN
DELETE FROM tbl_TestMaster Where Id=P_Id;
ELSEIF P_ACTION = 'E' THEN
SELECT * FROM tbl_TestMaster Where Id=P_Id;
END IF;
SELECT Id,DepartmentId as DepartmentName,HeadId as HeadName ,Name as TestName, Rate as TestRate FROM tbl_TestMaster where DepartmentId=P_DepartmentId and HeadId=P_HeadId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_UserOperations` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_UserOperations`(
IN P_Id int,
IN P_UserName varchar(20),
IN P_Password varchar(20),
IN P_StaffId int,
IN P_UserType int,
IN P_CID int,
IN P_BID int,
IN P_ACTION varchar(1)
)
BEGIN
IF P_ACTION = 'I' THEN
        INSERT INTO tbl_UserLogin(StafId, UserName, Password, UserType, CreatedDate, BID, CID, IsActive)
        VALUES(P_StaffId,P_UserName,P_Password,P_UserType,now(),P_CID,P_BID,1);
    ELSEIF P_ACTION = 'U' THEN
    UPDATE tbl_UserLogin SET UserName=P_UserName, Password=P_Password, UserType=P_UserType, LastModifiedDate=now() where Id=P_Id;
    ELSEIF P_ACTION = 'D' THEN
     DELETE FROM tbl_UserLogin WHERE Id=P_Id;
     ELSEIF P_ACTION = 'G' THEN
     SELECT * FROM tbl_UserLogin WHERE Id=P_Id;
     ELSE
     SELECT 'Operation Not Performed';
    END IF;
    IF P_ACTION != 'G' THEN
    SELECT * FROM tbl_UserLogin order by Id Desc;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `USP_ValidateUser` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `USP_ValidateUser`(
IN P_UserName varchar(20),
IN P_Password varchar(20)
)
BEGIN
SELECT * FROM tbl_UserLogin where UserName=P_UserName AND Password=P_Password AND IsActive=1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-29 11:19:18
