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
  `login_web` varchar(45) NOT NULL,
  `senha_web` varchar(45) NOT NULL,
  `cnh` varchar(45) NOT NULL,
  `validade_cnh` date NOT NULL,
  `logradouro` varchar(45) NOT NULL,
  `numero` int(11) NOT NULL,
  `complemento` varchar(45) DEFAULT NULL,
  `bairro` varchar(45) NOT NULL,
  `cep` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) NOT NULL,
  `estado` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
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
  `data_locacao` datetime NOT NULL,
  `data_prev_devolucao` datetime NOT NULL,
  `data_devolucao` datetime DEFAULT NULL,
  `forma_pagamento` varchar(45) DEFAULT NULL,
  `valor_total` double DEFAULT NULL,
  `pago` varchar(1) DEFAULT NULL,
  `valor_caucao` double DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `codigo_cliente_3_idx` (`codigo_cliente`),
  KEY `codigo_veiculo_idx` (`codigo_veiculo`),
  CONSTRAINT `codigo_cliente_3` FOREIGN KEY (`codigo_cliente`) REFERENCES `cliente` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `codigo_veiculo` FOREIGN KEY (`codigo_veiculo`) REFERENCES `veiculo` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locacao`
--

LOCK TABLES `locacao` WRITE;
/*!40000 ALTER TABLE `locacao` DISABLE KEYS */;
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
  `descricao` varchar(45) NOT NULL,
  `valor` double NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opcional`
--

LOCK TABLES `opcional` WRITE;
/*!40000 ALTER TABLE `opcional` DISABLE KEYS */;
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
  `nome` varchar(45) NOT NULL,
  `cpf` varchar(45) NOT NULL,
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
  `nome_condutor` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo_cliente`),
  CONSTRAINT `codigo_cliente_2` FOREIGN KEY (`codigo_cliente`) REFERENCES `cliente` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoa_juridica`
--

LOCK TABLES `pessoa_juridica` WRITE;
/*!40000 ALTER TABLE `pessoa_juridica` DISABLE KEYS */;
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
  `descricao` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `situacao_veiculo`
--

LOCK TABLES `situacao_veiculo` WRITE;
/*!40000 ALTER TABLE `situacao_veiculo` DISABLE KEYS */;
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
  `descricao` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_telefone`
--

LOCK TABLES `tipo_telefone` WRITE;
/*!40000 ALTER TABLE `tipo_telefone` DISABLE KEYS */;
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
  `descricao` varchar(1) NOT NULL,
  `ar_condicionado` varchar(1) DEFAULT NULL,
  `vidro_eletrico` varchar(1) DEFAULT NULL,
  `trava_eletrica` varchar(1) DEFAULT NULL,
  `portas` varchar(1) DEFAULT NULL,
  `abs` varchar(1) DEFAULT NULL,
  `air_bag` varchar(1) DEFAULT NULL,
  `valor_diaria` double NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_veiculo`
--

LOCK TABLES `tipo_veiculo` WRITE;
/*!40000 ALTER TABLE `tipo_veiculo` DISABLE KEYS */;
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
  `nome` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `usuario` varchar(45) NOT NULL,
  `senha` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

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
  `marca` varchar(45) NOT NULL,
  `modelo` varchar(45) NOT NULL,
  `ano` int(11) NOT NULL,
  `placa` varchar(45) NOT NULL,
  `chassi` varchar(45) NOT NULL,
  `cor` varchar(45) NOT NULL,
  `observacao` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `codigo_tipo_veiculo_idx` (`codigo_tipo_veiculo`),
  KEY `codigo_situacao_veiculo_idx` (`codigo_situacao_veiculo`),
  CONSTRAINT `codigo_tipo_veiculo` FOREIGN KEY (`codigo_tipo_veiculo`) REFERENCES `tipo_veiculo` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `codigo_situacao_veiculo` FOREIGN KEY (`codigo_situacao_veiculo`) REFERENCES `situacao_veiculo` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculo`
--

LOCK TABLES `veiculo` WRITE;
/*!40000 ALTER TABLE `veiculo` DISABLE KEYS */;
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
  `codigo_usuario` int(11) NOT NULL,
  `km_loc` int(11) DEFAULT NULL,
  `km_dev` int(11) DEFAULT NULL,
  `nivel_comb_loc` varchar(45) DEFAULT NULL,
  `nivel_comb_dev` varchar(45) DEFAULT NULL,
  `laudo_loc` varchar(45) DEFAULT NULL,
  `laudo_dev` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `codigo_locacao_idx` (`codigo_locacao`),
  KEY `codigo_usuario_idx` (`codigo_usuario`),
  CONSTRAINT `codigo_locacao` FOREIGN KEY (`codigo_locacao`) REFERENCES `locacao` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `codigo_usuario` FOREIGN KEY (`codigo_usuario`) REFERENCES `usuario` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vistoria`
--

LOCK TABLES `vistoria` WRITE;
/*!40000 ALTER TABLE `vistoria` DISABLE KEYS */;
/*!40000 ALTER TABLE `vistoria` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-21 12:19:08
