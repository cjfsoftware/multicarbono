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
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
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
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES ('123','Gerdau Aços Finos Ltda','Gerdau Aços Finos','123','2021-05-13 00:31:00',1230.00,'A',1),('124','Gerdau Aços Longos Ltda','Gerdau Aços Longs','124','2021-05-13 00:31:00',1200.00,'A',2);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `endereco_cliente`
--

DROP TABLE IF EXISTS `endereco_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `endereco_cliente` (
  `ID_ENDERECO` int NOT NULL AUTO_INCREMENT,
  `ID_CLIENTE` int DEFAULT NULL,
  `ENDERECO` text NOT NULL,
  `CEP` varchar(9) NOT NULL,
  `TIPO_ENDERECO` char(1) NOT NULL,
  PRIMARY KEY (`ID_ENDERECO`),
  KEY `ID_CLIENTE_idx` (`ID_CLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endereco_cliente`
--

LOCK TABLES `endereco_cliente` WRITE;
/*!40000 ALTER TABLE `endereco_cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `endereco_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_nota`
--

DROP TABLE IF EXISTS `item_nota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item_nota` (
  `ID_ITEM_NF` int NOT NULL AUTO_INCREMENT,
  `ID_NF` int NOT NULL,
  `ID_ITEM_PEDIDO` int NOT NULL,
  `COD_PRODUTO` int NOT NULL,
  `QTDE_PESADA` float NOT NULL,
  `SUBTOTAL_ITEM_NF` float DEFAULT NULL,
  `QTDE_PEDIDO` float DEFAULT NULL,
  PRIMARY KEY (`ID_ITEM_NF`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_nota`
--

LOCK TABLES `item_nota` WRITE;
/*!40000 ALTER TABLE `item_nota` DISABLE KEYS */;
INSERT INTO `item_nota` VALUES (1,0,34,123,11,NULL,NULL),(27,1,27,12,11,NULL,NULL),(34,2,34,123,11,NULL,NULL),(36,2,36,5,0,NULL,NULL),(40,3,40,45543,13,NULL,NULL),(41,3,41,43,11,NULL,NULL),(42,3,42,7365,13,NULL,NULL),(44,4,44,5,11,NULL,NULL);
/*!40000 ALTER TABLE `item_nota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_pedido`
--

DROP TABLE IF EXISTS `item_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item_pedido` (
  `ID_PEDIDO` int NOT NULL,
  `ID_PRODUTO` int NOT NULL,
  `CFOP` int NOT NULL,
  `QTDE` float NOT NULL,
  `ID_ITEM_PEDIDO` int NOT NULL AUTO_INCREMENT,
  `SUBTOTAL_ITEM_PEDIDO` float DEFAULT NULL,
  PRIMARY KEY (`ID_ITEM_PEDIDO`)
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_pedido`
--

LOCK TABLES `item_pedido` WRITE;
/*!40000 ALTER TABLE `item_pedido` DISABLE KEYS */;
INSERT INTO `item_pedido` VALUES (1,12,12,1,27,NULL),(2,3,12,1200,34,3540),(2,5,1,200,36,620),(3,45543,534354,534,40,NULL),(3,43,4343,354345,41,NULL),(3,7365,6565,653,42,NULL),(5,6,1,5,43,6),(4,5,5,4000,44,12400),(2,3,12,455,45,1342.25),(4,5,23,120,46,372);
/*!40000 ALTER TABLE `item_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nota_fiscal`
--

DROP TABLE IF EXISTS `nota_fiscal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nota_fiscal` (
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nota_fiscal`
--

LOCK TABLES `nota_fiscal` WRITE;
/*!40000 ALTER TABLE `nota_fiscal` DISABLE KEYS */;
INSERT INTO `nota_fiscal` VALUES (4,1,123,1234,'venda','2021-05-27 00:36:00','2021-05-27 00:36:00',123.00,12,'123','N',NULL),(5,3,12,12,'venda','2021-05-30 22:04:00','2021-05-30 22:04:00',12.00,2,'12','N',NULL),(6,3,0,0,NULL,'0001-01-01 00:00:00','0001-01-01 00:00:00',0.00,0,NULL,'N',NULL),(7,2,0,0,NULL,'0001-01-01 00:00:00','0001-01-01 00:00:00',0.00,0,NULL,'N',NULL),(8,5,0,0,NULL,'0001-01-01 00:00:00','0001-01-01 00:00:00',0.00,0,NULL,'N',NULL),(9,5,0,0,NULL,'0001-01-01 00:00:00','0001-01-01 00:00:00',0.00,0,NULL,'N',NULL);
/*!40000 ALTER TABLE `nota_fiscal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido` (
  `NUM_PEDIDO` int NOT NULL,
  `CNPJ_CLIENTE` text NOT NULL,
  `ID_USUARIO` int NOT NULL,
  `DT_EMISSAO` datetime NOT NULL,
  `DT_CARREGA` datetime NOT NULL,
  `OBS` varchar(80) DEFAULT NULL,
  `TIPO_FRETE` text NOT NULL,
  `ID_PEDIDO` int NOT NULL AUTO_INCREMENT,
  `VALOR_PEDIDO` decimal(8,2) DEFAULT NULL,
  `ID_TRANSPORT` int DEFAULT NULL,
  `NF_EMITIDA` varchar(1) DEFAULT 'N',
  `ID_CLIENTE` int DEFAULT NULL,
  `VALOR_PAGAR` decimal(8,2) DEFAULT NULL,
  PRIMARY KEY (`ID_PEDIDO`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` VALUES (123,'12345632',12,'2021-05-30 10:37:00','2021-05-30 10:37:00','TESTE','FOB',2,4160.00,22,'Y',1,NULL),(4,'12345632',1,'2021-06-02 23:56:00','2021-06-02 23:56:00',NULL,'FOB',4,12400.00,1,'N',1,NULL),(333,'12345632',1,'2021-06-03 01:04:00','2021-06-03 01:04:00',NULL,'FOB',5,6.00,2,'N',1,NULL);
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produto`
--

DROP TABLE IF EXISTS `produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produto` (
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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produto`
--

LOCK TABLES `produto` WRITE;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` VALUES (2,'Grafite','A',123,123,'kg',2.95,10.00,10.00,3),(44,'Grafite Especial','A',1,5,'kg',3.10,10.00,10.00,5),(12,'Coque verde','A',123,123,'kg',1.20,12.00,12.00,6),(4,'Grafite Sintético','A',123,123,'kg',1.50,10.00,10.00,7);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefone`
--

DROP TABLE IF EXISTS `telefone`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `telefone` (
  `ID_TELEFONE` int NOT NULL AUTO_INCREMENT,
  `ID_CLIENTE` int NOT NULL,
  `NUM_TELEFONE` text NOT NULL,
  `CONTATO` text NOT NULL,
  `E-MAIL` text,
  PRIMARY KEY (`ID_TELEFONE`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefone`
--

LOCK TABLES `telefone` WRITE;
/*!40000 ALTER TABLE `telefone` DISABLE KEYS */;
INSERT INTO `telefone` VALUES (2,1,'1130322145','João - Supply Chain',NULL);
/*!40000 ALTER TABLE `telefone` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transportador`
--

DROP TABLE IF EXISTS `transportador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transportador` (
  `ID_TRANSPORTADOR` int NOT NULL AUTO_INCREMENT,
  `CNPJ_TRANSPORTADOR` text NOT NULL,
  `RAZAO_SOCIAL` text NOT NULL,
  `IE_TRANSPORTADOR` int DEFAULT NULL,
  `ENDERECO_TRANSP` text NOT NULL,
  PRIMARY KEY (`ID_TRANSPORTADOR`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transportador`
--

LOCK TABLES `transportador` WRITE;
/*!40000 ALTER TABLE `transportador` DISABLE KEYS */;
INSERT INTO `transportador` VALUES (1,'123','Rodopress',123,'Rodovia 01, km 245');
/*!40000 ALTER TABLE `transportador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
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
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'analista','2021-05-11 22:19:00','analista','rua 03','analista','analista@multicarbonos.com.br','A','2021-05-11 22:19:00','2','123'),(3,'admin','2021-05-13 19:20:00','administrador','rua 1','admin','admin@multicarbonos.com.br','A','2021-05-13 19:21:00','1','123');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-03 22:15:12
