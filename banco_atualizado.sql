CREATE DATABASE  IF NOT EXISTS `locauto` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `locauto`;
-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: locauto
-- ------------------------------------------------------
-- Server version	5.6.17-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
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
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(45) DEFAULT NULL,
  `login_web` varchar(45) DEFAULT NULL,
  `senha_web` varchar(45) DEFAULT NULL,
  `cnh` varchar(45) DEFAULT NULL,
  `validade_cnh` date DEFAULT NULL,
  `logradouro` varchar(45) DEFAULT NULL,
  `numero` int(11) DEFAULT NULL,
  `complemento` varchar(45) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `cep` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'thish@fwfo','','','54654654','2018-01-01','x',1,'','','  ,   -','',''),(2,'nayara.julio@gmail.com','','','25639856999','0000-00-00','Avenida Jose Antonio Ferrarezi',29999,'Parque dos Servidores','Bloco 3 Ap 205','14094-160','Ribeirão Preto',''),(3,'nayara.julio@gmail.com','','','25639856999','0000-00-00','Avenida Jose Antonio Ferrarezi',29999,'Parque dos Servidores','Bloco 3 Ap 205','14094-160','Ribeirão Preto',''),(4,'nayara.julio@gmail.com','','','','0000-00-00','Avenida Jose Antonio Ferrarezi',123,'Parque dos Servidores','','  ,   -','',''),(5,'nayara.julio@gmail.com','','','','0000-00-00','Avenida Jose Antonio Ferrarezi',1,'Parque dos Servidores','','  ,   -','',''),(6,'nayara.julio@gmail.com','','','','0000-00-00','Avenida Jose Antonio Ferrarezi',1,'Parque dos Servidores','','  ,   -','',''),(7,'nayara.julio@gmail.com','','','','0000-00-00','Avenida Jose Antonio Ferrarezi',1,'Parque dos Servidores','','  ,   -','',''),(8,'nayara.julio@gmail.com','','','','0000-00-00','Avenida Jose Antonio Ferrarezi',1,'Parque dos Servidores','','  ,   -','',''),(9,'nayara.julio@gmail.com','','','','0000-00-00','Avenida Jose Antonio Ferrarezi',1,'Parque dos Servidores','','  ,   -','',''),(10,'nayara.julio@gmail.com','','','25639856999','0000-00-00','Avenida Jose Antonio Ferrarezi',22,'Parque dos Servidores','','  ,   -','',''),(11,'nayara.julio@gmail.com','','','25639856999','0000-00-00','Avenida Jose Antonio Ferrarezi',29999,'Parque dos Servidores','Bloco 3 Ap 205','14094-160','Ribeirão Preto',''),(12,'nayara.julio@gmail.com','','','25639856999','0000-00-00','Avenida Jose Antonio Ferrarezi',555,'Parque dos Servidores','','  ,   -','',''),(13,'','','','25639856999','0000-00-00','Avenida Jose Antonio Ferrarezi',85,'Parque dos Servidores','','  ,   -','','SP 	 ');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `locacao`
--

DROP TABLE IF EXISTS `locacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `locacao` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `codigo_cliente` int(11) NOT NULL,
  `codigo_veiculo` int(11) NOT NULL,
  `data_locacao` datetime DEFAULT NULL,
  `data_prev_devolucao` datetime DEFAULT NULL,
  `data_devolucao` datetime DEFAULT NULL,
  `forma_pagamento` varchar(45) DEFAULT NULL,
  `valor_total` double DEFAULT NULL,
  `pago` varchar(1) DEFAULT NULL,
  `valor_caucao` double DEFAULT NULL,
  `valor_opc` double DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `codigo_cliente_3_idx` (`codigo_cliente`),
  KEY `codigo_veiculo_idx` (`codigo_veiculo`),
  CONSTRAINT `codigo_cliente_3` FOREIGN KEY (`codigo_cliente`) REFERENCES `cliente` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `codigo_veiculo` FOREIGN KEY (`codigo_veiculo`) REFERENCES `veiculo` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locacao`
--

LOCK TABLES `locacao` WRITE;
/*!40000 ALTER TABLE `locacao` DISABLE KEYS */;
INSERT INTO `locacao` VALUES (1,2,2,'2016-05-22 00:00:00','2016-05-24 00:00:00',NULL,'Dinheiro',1114,'0',0,10);
/*!40000 ALTER TABLE `locacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `opcional`
--

DROP TABLE IF EXISTS `opcional`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `opcional` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(45) DEFAULT NULL,
  `valor` double DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opcional`
--

LOCK TABLES `opcional` WRITE;
/*!40000 ALTER TABLE `opcional` DISABLE KEYS */;
INSERT INTO `opcional` VALUES (1,'Assento de elevação',10),(2,'Cadeira de bebê',20),(3,'Cobertura do carro',41),(4,'Cobertura para terceiros',40),(5,'Navegador GPS',50);
/*!40000 ALTER TABLE `opcional` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoa_fisica`
--

DROP TABLE IF EXISTS `pessoa_fisica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoa_fisica` (
  `codigo_cliente` int(11) NOT NULL,
  `nome` varchar(45) DEFAULT NULL,
  `cpf` varchar(45) DEFAULT NULL,
  `rg` varchar(45) DEFAULT NULL,
  `outro_documento` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codigo_cliente`),
  CONSTRAINT `codigo_cliente_1` FOREIGN KEY (`codigo_cliente`) REFERENCES `cliente` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoa_fisica`
--

LOCK TABLES `pessoa_fisica` WRITE;
/*!40000 ALTER TABLE `pessoa_fisica` DISABLE KEYS */;
INSERT INTO `pessoa_fisica` VALUES (1,'Thiago','323,664,258-05','01',''),(2,'Nayara cristina NAscimento Julio','___,___,___-__','478723957',''),(3,'Nayara cristina NAscimento Julio','___,___,___-__','478723957',''),(11,'Nayara cristina NAscimento Julio','___,___,___-__','478723957','');
/*!40000 ALTER TABLE `pessoa_fisica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoa_juridica`
--

DROP TABLE IF EXISTS `pessoa_juridica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoa_juridica` (
  `codigo_cliente` int(11) NOT NULL,
  `razao_social` varchar(45) DEFAULT NULL,
  `nome_fantasia` varchar(45) DEFAULT NULL,
  `cnpj` varchar(45) DEFAULT NULL,
  `insc_estadual` varchar(45) DEFAULT NULL,
  `contato` varchar(45) DEFAULT NULL,
  `nome_condutor` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codigo_cliente`),
  CONSTRAINT `codigo_cliente_2` FOREIGN KEY (`codigo_cliente`) REFERENCES `cliente` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoa_juridica`
--

LOCK TABLES `pessoa_juridica` WRITE;
/*!40000 ALTER TABLE `pessoa_juridica` DISABLE KEYS */;
INSERT INTO `pessoa_juridica` VALUES (4,'Tintas exppresse ltds','','11,221,111/1111-11','','',''),(5,'Tintas exppresse ltds','','11,221,111/1111-11','','',''),(6,'Tintas exppresse ltds','','11,221,111/1111-11','','',''),(7,'Tintas exppresse ltds','','11,221,111/1111-11','','',''),(8,'Tintas exppresse ltds','','11,221,111/1111-11','','',''),(9,'Tintas exppresse ltds','','11,221,111/1111-11','','',''),(10,'Tintas exppresse ltds','','11,221,111/1111-11','','','Nayara cristina NAscimento Julio'),(12,'Tintas exppresse ltds','','11,221,111/1111-11','','','Nayara cristina NAscimento Julio'),(13,'Teste','Teste','55,226,633/6655-88','','','Nayara cristina NAscimento Julio');
/*!40000 ALTER TABLE `pessoa_juridica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `situacao_veiculo`
--

DROP TABLE IF EXISTS `situacao_veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `situacao_veiculo` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `situacao_veiculo`
--

LOCK TABLES `situacao_veiculo` WRITE;
/*!40000 ALTER TABLE `situacao_veiculo` DISABLE KEYS */;
INSERT INTO `situacao_veiculo` VALUES (1,'Ativo'),(2,'Ativo'),(3,'Inativo');
/*!40000 ALTER TABLE `situacao_veiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefone_cliente`
--

DROP TABLE IF EXISTS `telefone_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `telefone_cliente` (
  `codigo_cliente` int(11) NOT NULL,
  `codigo_tipo_telefone` int(11) NOT NULL,
  `telefone` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo_cliente`,`codigo_tipo_telefone`,`telefone`),
  KEY `codigo_tipo_telefone_idx` (`codigo_tipo_telefone`),
  CONSTRAINT `codigo_cliente` FOREIGN KEY (`codigo_cliente`) REFERENCES `cliente` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `codigo_tipo_telefone` FOREIGN KEY (`codigo_tipo_telefone`) REFERENCES `tipo_telefone` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefone_cliente`
--

LOCK TABLES `telefone_cliente` WRITE;
/*!40000 ALTER TABLE `telefone_cliente` DISABLE KEYS */;
INSERT INTO `telefone_cliente` VALUES (3,1,'23232333'),(9,1,'123'),(10,1,'3344567'),(11,1,'22536695'),(12,1,'526333'),(2,2,'34343'),(3,2,'34343'),(9,2,'423'),(13,2,'558888');
/*!40000 ALTER TABLE `telefone_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_telefone`
--

DROP TABLE IF EXISTS `tipo_telefone`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_telefone` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_telefone`
--

LOCK TABLES `tipo_telefone` WRITE;
/*!40000 ALTER TABLE `tipo_telefone` DISABLE KEYS */;
INSERT INTO `tipo_telefone` VALUES (1,'Celular'),(2,'Comercial'),(3,'Contato');
/*!40000 ALTER TABLE `tipo_telefone` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_veiculo`
--

DROP TABLE IF EXISTS `tipo_veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_veiculo` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(45) DEFAULT NULL,
  `ar_condicionado` varchar(1) DEFAULT NULL,
  `vidro_eletrico` varchar(1) DEFAULT NULL,
  `trava_eletrica` varchar(1) DEFAULT NULL,
  `portas` varchar(1) DEFAULT NULL,
  `abs` varchar(1) DEFAULT NULL,
  `air_bag` varchar(1) DEFAULT NULL,
  `valor_diaria` double DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_veiculo`
--

LOCK TABLES `tipo_veiculo` WRITE;
/*!40000 ALTER TABLE `tipo_veiculo` DISABLE KEYS */;
INSERT INTO `tipo_veiculo` VALUES (1,'E','T','F','F','F','F','T',28),(2,'Economico','F','T','F','F','F','T',552),(3,'Flex','T','F','F',NULL,'T','F',320);
/*!40000 ALTER TABLE `tipo_veiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `login` varchar(45) DEFAULT NULL,
  `senha` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Nayara Cristina Nascimento Julio','','Naya','123');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `v_locpendpf`
--

DROP TABLE IF EXISTS `v_locpendpf`;
/*!50001 DROP VIEW IF EXISTS `v_locpendpf`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_locpendpf` AS SELECT 
 1 AS `Id_loc`,
 1 AS `Nome`,
 1 AS `data_loc`,
 1 AS `data_prev`,
 1 AS `Veiculo`,
 1 AS `Valor_Total`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_locpendpj`
--

DROP TABLE IF EXISTS `v_locpendpj`;
/*!50001 DROP VIEW IF EXISTS `v_locpendpj`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `v_locpendpj` AS SELECT 
 1 AS `Id_loc`,
 1 AS `Nome`,
 1 AS `data_loc`,
 1 AS `data_prev`,
 1 AS `Veiculo`,
 1 AS `Valor_Total`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `veiculo`
--

DROP TABLE IF EXISTS `veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `veiculo` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `codigo_tipo_veiculo` int(11) NOT NULL,
  `codigo_situacao_veiculo` int(11) NOT NULL,
  `marca` varchar(45) DEFAULT NULL,
  `modelo` varchar(45) DEFAULT NULL,
  `ano` int(11) DEFAULT NULL,
  `placa` varchar(45) DEFAULT NULL,
  `chassi` varchar(45) DEFAULT NULL,
  `cor` varchar(45) DEFAULT NULL,
  `observacao` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `codigo_tipo_veiculo_idx` (`codigo_tipo_veiculo`),
  KEY `codigo_situacao_veiculo_idx` (`codigo_situacao_veiculo`),
  CONSTRAINT `codigo_situacao_veiculo` FOREIGN KEY (`codigo_situacao_veiculo`) REFERENCES `situacao_veiculo` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `codigo_tipo_veiculo` FOREIGN KEY (`codigo_tipo_veiculo`) REFERENCES `tipo_veiculo` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculo`
--

LOCK TABLES `veiculo` WRITE;
/*!40000 ALTER TABLE `veiculo` DISABLE KEYS */;
INSERT INTO `veiculo` VALUES (1,1,1,'ast','asas',1999,'asd3456','sdsd444','rr','aaa'),(2,2,3,'Chevrolet','Carro',2000,'abs5562','jdksjd8888','Preto','aaa');
/*!40000 ALTER TABLE `veiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vistoria`
--

DROP TABLE IF EXISTS `vistoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vistoria` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `codigo_locacao` int(11) NOT NULL,
  `codigo_usuario` int(11) DEFAULT NULL,
  `km_loc` int(11) DEFAULT NULL,
  `km_dev` int(11) DEFAULT NULL,
  `nivel_comb_loc` varchar(45) DEFAULT NULL,
  `nivel_comb_dev` varchar(45) DEFAULT NULL,
  `laudo_loc` varchar(45) DEFAULT NULL,
  `laudo_dev` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `codigo_locacao_idx` (`codigo_locacao`),
  KEY `codigo_usuario_idx` (`codigo_usuario`),
  CONSTRAINT `codigo_usuario` FOREIGN KEY (`codigo_usuario`) REFERENCES `usuario` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `codigo_locacao` FOREIGN KEY (`codigo_locacao`) REFERENCES `locacao` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vistoria`
--

LOCK TABLES `vistoria` WRITE;
/*!40000 ALTER TABLE `vistoria` DISABLE KEYS */;
INSERT INTO `vistoria` VALUES (1,1,1,54,NULL,'ok',NULL,'cheio',NULL);
/*!40000 ALTER TABLE `vistoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `v_locpendpf`
--

/*!50001 DROP VIEW IF EXISTS `v_locpendpf`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`locauto`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_locpendpf` AS select `loc`.`codigo` AS `Id_loc`,`clipf`.`nome` AS `Nome`,date_format(`loc`.`data_locacao`,'%d/%m/%Y') AS `data_loc`,date_format(`loc`.`data_prev_devolucao`,'%d/%m/%Y') AS `data_prev`,concat_ws(' - ',`vei`.`marca`,`vei`.`modelo`,`vei`.`cor`,`vei`.`placa`) AS `Veiculo`,(`loc`.`valor_total` + `loc`.`valor_opc`) AS `Valor_Total` from ((`locacao` `loc` join `pessoa_fisica` `clipf` on((`loc`.`codigo_cliente` = `clipf`.`codigo_cliente`))) join `veiculo` `vei` on((`loc`.`codigo_veiculo` = `vei`.`codigo`))) where isnull(`loc`.`data_devolucao`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_locpendpj`
--

/*!50001 DROP VIEW IF EXISTS `v_locpendpj`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`locauto`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `v_locpendpj` AS select `loc`.`codigo` AS `Id_loc`,`clipj`.`nome_fantasia` AS `Nome`,date_format(`loc`.`data_locacao`,'%d/%m/%Y') AS `data_loc`,date_format(`loc`.`data_prev_devolucao`,'%d/%m/%Y') AS `data_prev`,concat_ws(' - ',`vei`.`marca`,`vei`.`modelo`,`vei`.`cor`,`vei`.`placa`) AS `Veiculo`,(`loc`.`valor_total` + `loc`.`valor_opc`) AS `Valor_Total` from ((`locacao` `loc` join `pessoa_juridica` `clipj` on((`loc`.`codigo_cliente` = `clipj`.`codigo_cliente`))) join `veiculo` `vei` on((`loc`.`codigo_veiculo` = `vei`.`codigo`))) where isnull(`loc`.`data_devolucao`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-22 23:20:59
