-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: multicarbono
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `CLIENTE`
--

DROP TABLE IF EXISTS `CLIENTE`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `CLIENTE` (
  `CNPJ` text NOT NULL,
  `RAZAO_SOCIAL` varchar(80) NOT NULL,
  `NOME_FANTASIA` varchar(80) NOT NULL,
  `IE` varchar(12) NOT NULL,
  `DT_CADASTRO` datetime NOT NULL,
  `SALDO` decimal(8,2) NOT NULL,
  `SITUACAO` varchar(1) NOT NULL,
  `ID_CLIENTE` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID_CLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `CLIENTE`
--

LOCK TABLES `CLIENTE` WRITE;
/*!40000 ALTER TABLE `CLIENTE` DISABLE KEYS */;
INSERT INTO `CLIENTE` VALUES ('123','Gerdau Aços Finos Ltda','Gerdau Aços Finos','123','2021-05-13 00:31:00',1230.00,'A',1),('124','Gerdau Aços Longos Ltda','Gerdau Aços Longs','124','2021-05-13 00:31:00',1200.00,'A',2);
/*!40000 ALTER TABLE `CLIENTE` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ENDERECO_CLIENTE`
--

DROP TABLE IF EXISTS `ENDERECO_CLIENTE`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ENDERECO_CLIENTE` (
  `ID_ENDERECO` int NOT NULL AUTO_INCREMENT,
  `ID_CLIENTE` int DEFAULT NULL,
  `ENDERECO` text NOT NULL,
  `CEP` varchar(9) NOT NULL,
  `TIPO_ENDERECO` char(1) NOT NULL,
  PRIMARY KEY (`ID_ENDERECO`),
  KEY `ID_CLIENTE_idx` (`ID_CLIENTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ENDERECO_CLIENTE`
--

LOCK TABLES `ENDERECO_CLIENTE` WRITE;
/*!40000 ALTER TABLE `ENDERECO_CLIENTE` DISABLE KEYS */;
/*!40000 ALTER TABLE `ENDERECO_CLIENTE` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ITEM_NOTA`
--

DROP TABLE IF EXISTS `ITEM_NOTA`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ITEM_NOTA` (
  `ID_ITEM_NF` int NOT NULL AUTO_INCREMENT,
  `ID_NF` int NOT NULL,
  `ID_ITEM_PEDIDO` int NOT NULL,
  `COD_PRODUTO` int NOT NULL,
  `QTDE_PESADA` float NOT NULL,
  `SUBTOTAL_ITEM_NF` float DEFAULT NULL,
  PRIMARY KEY (`ID_ITEM_NF`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ITEM_NOTA`
--

LOCK TABLES `ITEM_NOTA` WRITE;
/*!40000 ALTER TABLE `ITEM_NOTA` DISABLE KEYS */;
/*!40000 ALTER TABLE `ITEM_NOTA` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ITEM_PEDIDO`
--

DROP TABLE IF EXISTS `ITEM_PEDIDO`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ITEM_PEDIDO` (
  `ID_PEDIDO` int NOT NULL,
  `ID_PRODUTO` int NOT NULL,
  `CFOP` int NOT NULL,
  `QTDE` float NOT NULL,
  `ID_ITEM_PEDIDO` int NOT NULL AUTO_INCREMENT,
  `SUBTOTAL_ITEM_PEDIDO` float DEFAULT NULL,
  PRIMARY KEY (`ID_ITEM_PEDIDO`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ITEM_PEDIDO`
--

LOCK TABLES `ITEM_PEDIDO` WRITE;
/*!40000 ALTER TABLE `ITEM_PEDIDO` DISABLE KEYS */;
INSERT INTO `ITEM_PEDIDO` VALUES (0,1,1,2,0,NULL);
/*!40000 ALTER TABLE `ITEM_PEDIDO` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `NOTA_FISCAL`
--

DROP TABLE IF EXISTS `NOTA_FISCAL`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `NOTA_FISCAL` (
  `ID_NF` int NOT NULL AUTO_INCREMENT,
  `ID_PEDIDO` int DEFAULT NULL,
  `NUM_NF` int DEFAULT NULL,
  `CHAVE` int DEFAULT NULL,
  `NATUREZA_OPER` text,
  `DT_EMISSAO` datetime DEFAULT NULL,
  `DT_SAIDA` datetime DEFAULT NULL,
  `VR_FRETE` decimal(8,2) DEFAULT NULL,
  `QTDE_EMBALAGENS` int DEFAULT NULL,
  `CNPJ_EMITENTE` text,
  `TRANSMITIDA` varchar(1) NOT NULL DEFAULT 'N',
  `VALOR_NOTA` float DEFAULT NULL,
  PRIMARY KEY (`ID_NF`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `NOTA_FISCAL`
--

LOCK TABLES `NOTA_FISCAL` WRITE;
/*!40000 ALTER TABLE `NOTA_FISCAL` DISABLE KEYS */;
/*!40000 ALTER TABLE `NOTA_FISCAL` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `PEDIDO`
--

DROP TABLE IF EXISTS `PEDIDO`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `PEDIDO` (
  `NUM_PEDIDO` int NOT NULL,
  `CNPJ_CLIENTE` text NOT NULL,
  `ID_USUARIO` int NOT NULL,
  `DT_EMISSAO` datetime NOT NULL,
  `DT_CARREGA` datetime NOT NULL,
  `OBS` varchar(80) DEFAULT NULL,
  `TIPO_FRETE` text NOT NULL,
  `ID_PEDIDO` int NOT NULL AUTO_INCREMENT,
  `VALOR_PEDIDO` float DEFAULT NULL,
  PRIMARY KEY (`ID_PEDIDO`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `PEDIDO`
--

LOCK TABLES `PEDIDO` WRITE;
/*!40000 ALTER TABLE `PEDIDO` DISABLE KEYS */;
INSERT INTO `PEDIDO` VALUES (123,'123',1,'2021-05-23 00:38:00','2021-05-23 00:38:00',NULL,'CIF',1,NULL);
/*!40000 ALTER TABLE `PEDIDO` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `PRODUTO`
--

DROP TABLE IF EXISTS `PRODUTO`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `PRODUTO` (
  `COD_PRODUTO` int NOT NULL,
  `DESCRICAO` varchar(80) NOT NULL,
  `ATIVO` varchar(1) DEFAULT NULL,
  `NCM_SH` int DEFAULT NULL,
  `CST` int DEFAULT NULL,
  `UNIDADE` text,
  `VR_UNITARIO` decimal(8,2) DEFAULT NULL,
  `ALI_ICMS` decimal(8,2) DEFAULT NULL,
  `ALI_IPI` decimal(8,2) DEFAULT NULL,
  `ID_PRODUTO` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID_PRODUTO`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `PRODUTO`
--

LOCK TABLES `PRODUTO` WRITE;
/*!40000 ALTER TABLE `PRODUTO` DISABLE KEYS */;
INSERT INTO `PRODUTO` VALUES (2,'Grafite','A',123,123,'kg',1000.00,10.00,10.00,3),(44,'Grafite Especial','A',1,5,'kg',1010.00,10.00,10.00,5);
/*!40000 ALTER TABLE `PRODUTO` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `TELEFONE`
--

DROP TABLE IF EXISTS `TELEFONE`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `TELEFONE` (
  `ID_TELEFONE` int NOT NULL AUTO_INCREMENT,
  `ID_CLIENTE` int NOT NULL,
  `NUM_TELEFONE` text NOT NULL,
  `CONTATO` text NOT NULL,
  PRIMARY KEY (`ID_TELEFONE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `TELEFONE`
--

LOCK TABLES `TELEFONE` WRITE;
/*!40000 ALTER TABLE `TELEFONE` DISABLE KEYS */;
/*!40000 ALTER TABLE `TELEFONE` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `TRANSPORTADOR`
--

DROP TABLE IF EXISTS `TRANSPORTADOR`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `TRANSPORTADOR` (
  `ID_TRANSPORTADOR` int NOT NULL AUTO_INCREMENT,
  `CNPJ_TRANSPORTADOR` text NOT NULL,
  `RAZAO_SOCIAL` text NOT NULL,
  `IE_TRANSPORTADOR` int DEFAULT NULL,
  `ENDERECO_TRANSP` text NOT NULL,
  PRIMARY KEY (`ID_TRANSPORTADOR`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `TRANSPORTADOR`
--

LOCK TABLES `TRANSPORTADOR` WRITE;
/*!40000 ALTER TABLE `TRANSPORTADOR` DISABLE KEYS */;
INSERT INTO `TRANSPORTADOR` VALUES (1,'123','Rodopress',123,'Rodovia 01, km 245');
/*!40000 ALTER TABLE `TRANSPORTADOR` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `USUARIO`
--

DROP TABLE IF EXISTS `USUARIO`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `USUARIO` (
  `ID_USUARIO` int NOT NULL AUTO_INCREMENT,
  `NOME` text,
  `DT_NASCIMENTO` datetime DEFAULT NULL,
  `CARGO` text,
  `ENDERECO` text,
  `LOGIN` text,
  `EMAIL` text,
  `STATUS` char(1) DEFAULT NULL,
  `DT_CRIACAO` datetime DEFAULT NULL,
  `NIVEL_ACESSO` text,
  `SENHA` text,
  PRIMARY KEY (`ID_USUARIO`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `USUARIO`
--

LOCK TABLES `USUARIO` WRITE;
/*!40000 ALTER TABLE `USUARIO` DISABLE KEYS */;
INSERT INTO `USUARIO` VALUES (1,'analista','2021-05-11 22:19:00','analista','rua 03','analista','analista@multicarbonos.com.br','A','2021-05-11 22:19:00','2','qXzqbGvUwYDKhxLYI53GfA=='),(3,'admin','2021-05-13 19:20:00','administrador','rua 1','admin','admin@multicarbonos.com.br','A','2021-05-13 19:21:00','1','qXzqbGvUwYDKhxLYI53GfA==');
/*!40000 ALTER TABLE `USUARIO` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-05-25 23:06:44
