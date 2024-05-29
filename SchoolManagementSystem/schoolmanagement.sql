-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: schoolmanagement
-- ------------------------------------------------------
-- Server version	8.3.0

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
-- Table structure for table `authorization`
--

DROP TABLE IF EXISTS `authorization`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `authorization` (
  `Login` varchar(255) NOT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `Role` enum('Student','Teacher','Admin') DEFAULT NULL,
  `StudentIdentifier` varchar(255) DEFAULT NULL,
  `TeacherIdentifier` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Login`),
  KEY `StudentIdentifier` (`StudentIdentifier`),
  KEY `TeacherIdentifier` (`TeacherIdentifier`),
  CONSTRAINT `authorization_ibfk_1` FOREIGN KEY (`StudentIdentifier`) REFERENCES `students` (`StudentIdentifier`) ON DELETE CASCADE,
  CONSTRAINT `authorization_ibfk_2` FOREIGN KEY (`TeacherIdentifier`) REFERENCES `teachers` (`TeacherIdentifier`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `authorization`
--

LOCK TABLES `authorization` WRITE;
/*!40000 ALTER TABLE `authorization` DISABLE KEYS */;
INSERT INTO `authorization` VALUES ('1','d74ff0ee8da3b9806b18c877dbf29bbde50b5bd8e4dad7a3a725000feb82e8f1','Student','1',NULL),('admin','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Admin',NULL,NULL),('bondarenko_petro','d74ff0ee8da3b9806b18c877dbf29bbde50b5bd8e4dad7a3a725000feb82e8f1','Student','bondarenko_petro',NULL),('ivanov_olosandr','eb0b4270edb36c1ea88cc99ee34e45b591da06b486f6b3e7fde5ba7a9c283349','Teacher',NULL,'ivanov_olosandr'),('koval_olena','d74ff0ee8da3b9806b18c877dbf29bbde50b5bd8e4dad7a3a725000feb82e8f1','Student','koval_olena',NULL),('kravchenko_ulia','eb0b4270edb36c1ea88cc99ee34e45b591da06b486f6b3e7fde5ba7a9c283349','Teacher',NULL,'kravchenko_ulia'),('lisenko_maria','d74ff0ee8da3b9806b18c877dbf29bbde50b5bd8e4dad7a3a725000feb82e8f1','Student','lisenko_maria',NULL),('moroz_irina','eb0b4270edb36c1ea88cc99ee34e45b591da06b486f6b3e7fde5ba7a9c283349','Teacher',NULL,'moroz_irina'),('olga_androsova','d74ff0ee8da3b9806b18c877dbf29bbde50b5bd8e4dad7a3a725000feb82e8f1','Student','olga_androsova',NULL),('petrov_dmytro','eb0b4270edb36c1ea88cc99ee34e45b591da06b486f6b3e7fde5ba7a9c283349','Teacher',NULL,'petrov_dmytro'),('shevchenko_ivan','d74ff0ee8da3b9806b18c877dbf29bbde50b5bd8e4dad7a3a725000feb82e8f1','Student','shevchenko_ivan',NULL),('sidorova_anna','eb0b4270edb36c1ea88cc99ee34e45b591da06b486f6b3e7fde5ba7a9c283349','Teacher',NULL,'sidorova_anna'),('teststudent','d74ff0ee8da3b9806b18c877dbf29bbde50b5bd8e4dad7a3a725000feb82e8f1','Student','teststudent',NULL),('testtecher1','d74ff0ee8da3b9806b18c877dbf29bbde50b5bd8e4dad7a3a725000feb82e8f1','Teacher',NULL,'testtecher1'),('zaisev_andriy','d74ff0ee8da3b9806b18c877dbf29bbde50b5bd8e4dad7a3a725000feb82e8f1','Student','zaisev_andriy',NULL);
/*!40000 ALTER TABLE `authorization` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grades`
--

DROP TABLE IF EXISTS `grades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grades` (
  `GradeID` int NOT NULL AUTO_INCREMENT,
  `StudentID` int DEFAULT NULL,
  `TeacherID` int DEFAULT NULL,
  `Grade` int DEFAULT NULL,
  `DateAssigned` datetime DEFAULT NULL,
  PRIMARY KEY (`GradeID`),
  KEY `StudentID` (`StudentID`),
  KEY `TeacherID` (`TeacherID`),
  CONSTRAINT `grades_ibfk_1` FOREIGN KEY (`StudentID`) REFERENCES `students` (`StudentID`),
  CONSTRAINT `grades_ibfk_2` FOREIGN KEY (`TeacherID`) REFERENCES `teachers` (`TeacherID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grades`
--

LOCK TABLES `grades` WRITE;
/*!40000 ALTER TABLE `grades` DISABLE KEYS */;
INSERT INTO `grades` VALUES (1,1,1,11,'2024-05-28 00:00:00'),(2,2,1,11,'2024-05-28 00:00:00'),(5,7,6,11,'2024-05-29 00:00:00'),(6,4,6,1,'2024-05-29 00:00:00'),(7,6,6,12,'2024-05-29 00:00:00');
/*!40000 ALTER TABLE `grades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `StudentID` int NOT NULL AUTO_INCREMENT,
  `LastName` varchar(255) DEFAULT NULL,
  `FirstName` varchar(255) DEFAULT NULL,
  `BirthDate` date DEFAULT NULL,
  `Class` varchar(255) DEFAULT NULL,
  `StudentGroup` varchar(255) DEFAULT NULL,
  `StudentIdentifier` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StudentID`),
  UNIQUE KEY `StudentIdentifier` (`StudentIdentifier`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,'Шевченко','Іван','2005-04-12','10','А','shevchenko_ivan'),(2,'Коваль','Олена','2006-05-23','11','Б','koval_olena'),(3,'Бондаренко','Петро','2004-03-14','12','В','bondarenko_petro'),(4,'Лисенко','Марія','2005-07-19','10','А','lisenko_maria'),(5,'Зайцев','Андрій','2006-11-30','11','Б','zaisev_andriy'),(6,'Test','Test','2024-05-28','11','А','teststudent'),(7,'Андросова','Ольга','1985-09-19','11','А','olga_androsova'),(9,'1','1','2024-05-29','1','А','1');
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tasks`
--

DROP TABLE IF EXISTS `tasks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tasks` (
  `TaskID` int NOT NULL AUTO_INCREMENT,
  `TaskType` varchar(255) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Status` varchar(255) DEFAULT NULL,
  `CreationDate` datetime DEFAULT NULL,
  `CompletionDate` datetime DEFAULT NULL,
  `StudentID` int DEFAULT NULL,
  `TeacherID` int DEFAULT NULL,
  PRIMARY KEY (`TaskID`),
  KEY `StudentID` (`StudentID`),
  KEY `TeacherID` (`TeacherID`),
  CONSTRAINT `tasks_ibfk_1` FOREIGN KEY (`StudentID`) REFERENCES `students` (`StudentID`),
  CONSTRAINT `tasks_ibfk_2` FOREIGN KEY (`TeacherID`) REFERENCES `teachers` (`TeacherID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tasks`
--

LOCK TABLES `tasks` WRITE;
/*!40000 ALTER TABLE `tasks` DISABLE KEYS */;
INSERT INTO `tasks` VALUES (2,'Проект','Проект з фізики про електромагнетизм','Завершено','2023-03-20 09:00:00','2023-04-01 23:59:59',2,2),(3,'Завдання','Завдання з хімії про органічні сполуки','В процесі','2023-04-05 09:00:00','2023-04-20 23:59:59',3,3),(4,'Лабораторна робота','Лабораторна робота з біології про поділ клітин','В очікуванні','2023-04-10 09:00:00','2023-04-18 23:59:59',4,4),(5,'Есе','Есе з англійської мови про Шекспіра','Завершено','2023-02-28 09:00:00','2023-03-10 23:59:59',5,5),(11,'Есе','Есе з англійської мови про Шекспіра','Завершено','2023-02-28 00:00:00','2023-03-10 00:00:00',2,6),(12,'Есе','Есе з англійської мови про Шекспіра','Завершено','2023-02-28 00:00:00','2023-03-10 00:00:00',5,6),(13,'Есе','Есе з англійської мови про Шекспіра','Завершено','2023-02-28 00:00:00','2023-03-10 00:00:00',6,6),(14,'1','1','1','2024-05-29 00:00:00','2024-05-29 00:00:00',9,6);
/*!40000 ALTER TABLE `tasks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teachers`
--

DROP TABLE IF EXISTS `teachers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teachers` (
  `TeacherID` int NOT NULL AUTO_INCREMENT,
  `LastName` varchar(255) DEFAULT NULL,
  `FirstName` varchar(255) DEFAULT NULL,
  `Subject` varchar(255) DEFAULT NULL,
  `Qualification` varchar(255) DEFAULT NULL,
  `TeacherIdentifier` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`TeacherID`),
  UNIQUE KEY `TeacherIdentifier` (`TeacherIdentifier`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teachers`
--

LOCK TABLES `teachers` WRITE;
/*!40000 ALTER TABLE `teachers` DISABLE KEYS */;
INSERT INTO `teachers` VALUES (1,'Іванов','Олександр','Математика','Кандидат наук','ivanov_olosandr'),(2,'Петров','Дмитро','Фізика','Магістр','petrov_dmytro'),(3,'Сидорова','Анна','Хімія','Кандидат наук','sidorova_anna'),(4,'Мороз','Ірина','Біологія','Магістр','moroz_irina'),(5,'Кравченко','Юлія','Англійська мова','Магістр','kravchenko_ulia'),(6,'Testtecher1','test','test','Магістр','testtecher1');
/*!40000 ALTER TABLE `teachers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'schoolmanagement'
--

--
-- Dumping routines for database 'schoolmanagement'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-29 10:57:09
