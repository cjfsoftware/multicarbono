-- `multicarbono-db`.CLIENTE definition

CREATE TABLE `CLIENTE` (
  `CNPJ` text NOT NULL,
  `RAZAO_SOCIAL` varchar(80) NOT NULL,
  `NOME_FANTASIA` varchar(80) NOT NULL,
  `IE` varchar(12) NOT NULL,
  `DT_CADASTRO` datetime NOT NULL,
  `SALDO` decimal(8,2) NOT NULL,
  `SITUACAO` varchar(32) NOT NULL,
  `ID_CLIENTE` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID_CLIENTE`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- `multicarbono-db`.ENDERECO_CLIENTE definition

CREATE TABLE `ENDERECO_CLIENTE` (
  `ID_ENDERECO` int NOT NULL AUTO_INCREMENT,
  `ID_CLIENTE` int DEFAULT NULL,
  `ENDERECO` text NOT NULL,
  `CEP` varchar(9) NOT NULL,
  `TIPO_ENDERECO` varchar(32) NOT NULL,
  PRIMARY KEY (`ID_ENDERECO`),
  KEY `ID_CLIENTE_idx` (`ID_CLIENTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- `multicarbono-db`.ITEM_NOTA definition

CREATE TABLE `ITEM_NOTA` (
  `ID_ITEM_NF` int NOT NULL AUTO_INCREMENT,
  `ID_NF` int NOT NULL,
  `ID_ITEM_PEDIDO` int NOT NULL,
  `COD_PRODUTO` int NOT NULL,
  `QTDE_PESADA` float NOT NULL,
  `SUBTOTAL_ITEM_NF` float DEFAULT NULL,
  PRIMARY KEY (`ID_ITEM_NF`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- `multicarbono-db`.ITEM_PEDIDO definition

CREATE TABLE `ITEM_PEDIDO` (
  `ID_PEDIDO` int NOT NULL,
  `ID_PRODUTO` int NOT NULL,
  `CFOP` int NOT NULL,
  `QTDE` float NOT NULL,
  `ID_ITEM_PEDIDO` int NOT NULL AUTO_INCREMENT,
  `SUBTOTAL_ITEM_PEDIDO` float DEFAULT NULL,
  PRIMARY KEY (`ID_ITEM_PEDIDO`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- `multicarbono-db`.NOTA_FISCAL definition

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- `multicarbono-db`.PEDIDO definition

CREATE TABLE `PEDIDO` (
  `NUM_PEDIDO` int NOT NULL,
  `CNPJ_CLIENTE` text NOT NULL,
  `ID_USUARIO` int NOT NULL,
  `DT_EMISSAO` datetime NOT NULL,
  `DT_CARREGA` datetime NOT NULL,
  `OBS` varchar(80) DEFAULT NULL,
  `TIPO_FRETE` varchar(32) NOT NULL,
  `ID_PEDIDO` int NOT NULL AUTO_INCREMENT,
  `VALOR_PEDIDO` float DEFAULT NULL,
  `ID_TRANSPORT` int NOT NULL,
  `NF_EMITIDA` tinyint(1) NOT NULL DEFAULT '0',
  `VALOR_PAGAR` float NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID_PEDIDO`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- `multicarbono-db`.PRODUTO definition

CREATE TABLE `PRODUTO` (
  `COD_PRODUTO` int NOT NULL,
  `DESCRICAO` varchar(80) NOT NULL,
  `ATIVO` tinyint(1) NOT NULL,
  `NCM_SH` int DEFAULT NULL,
  `CST` int DEFAULT NULL,
  `UNIDADE` varchar(32) DEFAULT NULL,
  `VR_UNITARIO` decimal(8,2) DEFAULT NULL,
  `ALI_ICMS` decimal(8,2) DEFAULT NULL,
  `ALI_IPI` decimal(8,2) DEFAULT NULL,
  `ID_PRODUTO` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID_PRODUTO`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- `multicarbono-db`.TELEFONE definition

CREATE TABLE `TELEFONE` (
  `ID_TELEFONE` int NOT NULL AUTO_INCREMENT,
  `ID_CLIENTE` int NOT NULL,
  `NUM_TELEFONE` text NOT NULL,
  `CONTATO` text NOT NULL,
  PRIMARY KEY (`ID_TELEFONE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- `multicarbono-db`.TRANSPORTADOR definition

CREATE TABLE `TRANSPORTADOR` (
  `ID_TRANSPORTADOR` int NOT NULL AUTO_INCREMENT,
  `CNPJ_TRANSPORTADOR` text NOT NULL,
  `RAZAO_SOCIAL` text NOT NULL,
  `IE_TRANSPORTADOR` int DEFAULT NULL,
  `ENDERECO_TRANSP` text NOT NULL,
  PRIMARY KEY (`ID_TRANSPORTADOR`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- `multicarbono-db`.USUARIO definition

CREATE TABLE `USUARIO` (
  `ID_USUARIO` int NOT NULL AUTO_INCREMENT,
  `NOME` text,
  `DT_NASCIMENTO` datetime NOT NULL,
  `CARGO` text,
  `ENDERECO` varchar(32) DEFAULT NULL,
  `LOGIN` text,
  `EMAIL` text,
  `STATUS` tinyint(1) NOT NULL DEFAULT '1',
  `DT_CRIACAO` datetime DEFAULT NULL,
  `NIVEL_ACESSO` varchar(32) DEFAULT NULL,
  `SENHA` text,
  PRIMARY KEY (`ID_USUARIO`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;