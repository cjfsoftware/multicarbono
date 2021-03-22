CREATE TABLE `endereco_cliente` (
  `ID_ENDERCO` int NOT NULL,
  `ID_CLIENTE` int DEFAULT NULL,
  `CNPJ_CLIENTE` text NOT NULL,
  `ENDERECO` text NOT NULL,
  `CEP` varchar(9) NOT NULL,
  `TIPO_ENDERECO` char(1) NOT NULL,
  PRIMARY KEY (`ID_ENDERCO`),
  KEY `ID_CLIENTE_idx` (`ID_CLIENTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `funcionario` (
  `ID_FUNCIONARIO` int NOT NULL,
  `NOME` text NOT NULL,
  `DT_NASCIMENTO` datetime NOT NULL,
  `CARGO` text NOT NULL,
  `ENDERECO` text,
  `LOGIN` text,
  `E-MAIL` text,
  `STATUS` char(1) DEFAULT NULL,
  `DT_CRIACAO` datetime NOT NULL,
  `NIVEL_ACESSO` text,
  `funcionariocol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID_FUNCIONARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `cliente` (
  `CNPJ` text NOT NULL,
  `RAZAO_SOCIAL` varchar(80) NOT NULL,
  `NOME_FANTASIA` varchar(80) NOT NULL,
  `IE` decimal(12,0) NOT NULL,
  `DT_CADASTRO` datetime NOT NULL,
  `SALDO` decimal(8,2) NOT NULL,
  `SITUACAO` varchar(1) NOT NULL,
  `ID_CLIENTE` int NOT NULL,
  PRIMARY KEY (`ID_CLIENTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `item_nota` (
  `ID_ITEM_NF` int NOT NULL,
  `ID_NF` int NOT NULL,
  `ID_ITEM_PEDIDO` int NOT NULL,
  `COD_PRODUTO` int NOT NULL,
  `QTDE_PESADA` float NOT NULL,
  `item_notacol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID_ITEM_NF`),
  KEY `FK_ID_ITEM_PEDIDO_idx` (`ID_ITEM_PEDIDO`),
  CONSTRAINT `FK_ID_ITEM_PEDIDO` FOREIGN KEY (`ID_ITEM_PEDIDO`) REFERENCES `item_pedido` (`ID_PEDIDO`),
  CONSTRAINT `FK_ID_NF` FOREIGN KEY (`ID_ITEM_NF`) REFERENCES `nota_fiscal` (`ID_NF`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `item_pedido` (
  `ID_PEDIDO` int NOT NULL,
  `ID_PRODUTO` int NOT NULL,
  `CFOP` int NOT NULL,
  `QTDE` float NOT NULL,
  `ID_ITEM_PEDIDO` int NOT NULL,
  PRIMARY KEY (`ID_ITEM_PEDIDO`),
  KEY `FK_ID_PEDIDO_idx` (`ID_PEDIDO`),
  CONSTRAINT `FK_ID_PEDIDO` FOREIGN KEY (`ID_PEDIDO`) REFERENCES `pedido` (`ID_PEDIDO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `nota_fiscal` (
  `ID_NF` int NOT NULL,
  `ID_PEDIDO` int DEFAULT NULL,
  `NUM_NF` int DEFAULT NULL,
  `CHAVE` int DEFAULT NULL,
  `NATUREZA_OPER` text,
  `DT_EMISSAO` datetime DEFAULT NULL,
  `DT_SAIDA` datetime DEFAULT NULL,
  `VR_FRETE` decimal(8,2) DEFAULT NULL,
  `QTDE_EMBALAGENS` int DEFAULT NULL,
  `CNPJ_EMITENTE` text,
  PRIMARY KEY (`ID_NF`),
  KEY `ID_PEDIDO_idx` (`ID_PEDIDO`),
  CONSTRAINT `ID_PEDIDO` FOREIGN KEY (`ID_PEDIDO`) REFERENCES `pedido` (`ID_PEDIDO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `pedido` (
  `NUM_PEDIDO` int NOT NULL,
  `CNPJ_CLIENTE` decimal(14,0) NOT NULL,
  `CPF_FUNC` decimal(11,0) NOT NULL,
  `DT_EMISSAO` datetime NOT NULL,
  `DT_CARREGA` datetime NOT NULL,
  `OBS` varchar(80) DEFAULT NULL,
  `TIPO_FRETE` varchar(1) NOT NULL,
  `NUM_NF` int NOT NULL,
  `ID_PEDIDO` int NOT NULL,
  PRIMARY KEY (`ID_PEDIDO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `produto` (
  `COD_PRODUTO` int NOT NULL,
  `DESCRICAO` varchar(80) NOT NULL,
  `ATIVO` varchar(1) DEFAULT NULL,
  `NCM_SH` int DEFAULT NULL,
  `CST` int DEFAULT NULL,
  `UNIDADE` int DEFAULT NULL,
  `VR_UNITARIO` decimal(8,2) DEFAULT NULL,
  `ALI_ICMS` decimal(8,2) DEFAULT NULL,
  `ALI_IPI` decimal(8,2) DEFAULT NULL,
  `ID_PRODUTO` int NOT NULL,
  PRIMARY KEY (`ID_PRODUTO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `telefone` (
  `ID_TELEFONE` int NOT NULL,
  `ID_CLIENTE` int NOT NULL,
  `TELEFONE` text NOT NULL,
  `CONTATO` text NOT NULL,
  `telefonecol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID_TELEFONE`),
  KEY `FK_ID_CLIENTE_idx` (`ID_CLIENTE`),
  CONSTRAINT `FK_ID_CLIENTE` FOREIGN KEY (`ID_CLIENTE`) REFERENCES `cliente` (`ID_CLIENTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `transportador` (
  `ID_TRANSPORTADOR` int NOT NULL,
  `CNPJ_TRANSPORTADOR` text NOT NULL,
  `RAZAO_SOCIAL` text NOT NULL,
  `IE_TRANSPORTADOR` int DEFAULT NULL,
  `ENDERECO_TRANSP` text NOT NULL,
  `transportadorcol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID_TRANSPORTADOR`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
