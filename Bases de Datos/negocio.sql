CREATE DATABASE  IF NOT EXISTS `negocios`;
USE `negocios`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: negocios
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `id_cliente` varchar(50) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `telefono` varchar(30) NOT NULL,
  `direccion_id` int NOT NULL COMMENT 'TRIAL',
  PRIMARY KEY (`id_cliente`),
  KEY `FK_cliente_direccion_idx` (`direccion_id`),
  CONSTRAINT `FK_cliente_direccion` FOREIGN KEY (`direccion_id`) REFERENCES `direccion` (`id_direccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES ('1010102','joan','herrera','23423535',4),('1347475','daniel','alzate','33324434',1),('7237339','josue','kerguelen','92383324',5),('7237340','andres','sanchez','64747474',2),('73293234','aldo','leao','55555555',3);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `direccion`
--

DROP TABLE IF EXISTS `direccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `direccion` (
  `id_direccion` int NOT NULL AUTO_INCREMENT,
  `pais` varchar(15) NOT NULL,
  `departamento` varchar(20) NOT NULL,
  `ciudad` varchar(20) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  PRIMARY KEY (`id_direccion`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3 COMMENT='TRIAL';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `direccion`
--

LOCK TABLES `direccion` WRITE;
/*!40000 ALTER TABLE `direccion` DISABLE KEYS */;
INSERT INTO `direccion` VALUES (1,'Colombia','Antioquia','Medellin','Calle 8 #84b 65'),(2,'Colombia','Antioquia','Envigado','Calle 7 sur #21a 32'),(3,'Estados Unidos','Florida','Miami','Parkway 7 23-45'),(4,'Peru','Lima','Lima','Lim  54 a #32'),(5,'Colombia','Bogota','Cundinamarca','Calle 34 #54 sur 32');
/*!40000 ALTER TABLE `direccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `id_empleado` varchar(40) NOT NULL,
  `nombre` varchar(40) NOT NULL,
  `apellido` varchar(40) NOT NULL,
  `direccion_id` int NOT NULL,
  `telefono` varchar(45) NOT NULL,
  PRIMARY KEY (`id_empleado`),
  KEY `FK_empleado_direccion_idx` (`direccion_id`),
  CONSTRAINT `FK_empleado_direccion` FOREIGN KEY (`direccion_id`) REFERENCES `direccion` (`id_direccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COMMENT='TRIAL';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES ('1000124768','Juliana','Restrepo',2,''),('1000645421','Juan Jose','Herrera Mendoza',1,''),('1099848489','Camila','Valencia',4,''),('43768980','Jackeline','Mendoza',5,''),('705596390','Ruben','Herrera',3,'');
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `id_producto` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(40) NOT NULL COMMENT 'TRIAL',
  `valor` double NOT NULL,
  `categoria` int NOT NULL,
  `proveedor_id` int NOT NULL,
  PRIMARY KEY (`id_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3 COMMENT='TRIAL';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'camisa',24000,1,2),(2,'pantalon',30000,2,1),(3,'gorra',50000,3,1),(4,'correa',20000,2,2),(5,'cadena',10000,3,2);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `id_user` int NOT NULL AUTO_INCREMENT COMMENT 'TRIAL',
  `username` varchar(20) NOT NULL COMMENT 'TRIAL',
  `email` varchar(50) NOT NULL COMMENT 'TRIAL',
  `password` varchar(20) NOT NULL COMMENT 'TRIAL',
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COMMENT='TRIAL';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'jotamen','j@gmail.com','12345'),(2,'rube','r@gmail.com','4321'),(3,'cam','c@gmail.com','567');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-01 11:29:46
