-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 27-Maio-2021 às 20:23
-- Versão do servidor: 5.7.26
-- versão do PHP: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `emprestimos`
--
CREATE DATABASE IF NOT EXISTS `emprestimos` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `emprestimos`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `emprestimo`
--

DROP TABLE IF EXISTS `emprestimo`;
CREATE TABLE IF NOT EXISTS `emprestimo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `retirada` datetime NOT NULL,
  `devolucao` datetime DEFAULT NULL,
  `observacao` longtext,
  `obsEntrega` longtext,
  `usuario` varchar(48) NOT NULL,
  `item_id` int(11) NOT NULL,
  `conferente` varchar(48) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `item_id` (`item_id`) USING BTREE,
  KEY `id` (`id`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `item`
--

DROP TABLE IF EXISTS `item`;
CREATE TABLE IF NOT EXISTS `item` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tipo_item_id` int(11) NOT NULL,
  `descricao` varchar(250) NOT NULL,
  `status` int(1) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id` (`id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `item`
--

INSERT INTO `item` (`id`, `tipo_item_id`, `descricao`, `status`) VALUES
(1, 9, 'Microfone Boya Lapela  C/Fio - 01', 0),
(2, 9, 'Microfone Boya Lapela  C/Fio - 02', 0),
(3, 9, 'Microfone Boya Lapela  C/Fio - 03', 0),
(4, 9, 'Microfone Boya Lapela  C/Fio - 04', 0),
(5, 9, 'Microfone Boya Lapela  C/Fio - 05', 0),
(6, 11, 'Mini Tripé Suporte para Celular - 01', 0),
(7, 11, 'Mini Tripé Suporte para Celular - 02', 0),
(8, 11, 'Mini Tripé Suporte para Celular - 03', 0),
(9, 11, 'Mini Tripé Suporte para Celular - 04', 0),
(10, 11, 'Mini Tripé Suporte para Celular - 05', 0),
(11, 12, 'Tripé Universal WT-3770 - 01', 0),
(12, 12, 'Tripé Universal WT-3770 - 02', 0),
(13, 12, 'Tripé Universal WT-3770 - 03', 0),
(14, 12, 'Tripé Universal WT-3770 - 04', 0),
(15, 12, 'Tripé Universal WT-3770 - 05', 0),
(16, 12, 'Suporte/Celular360º  - 01', 0),
(17, 12, 'Suporte/Celular360º  - 02', 0),
(18, 12, 'Suporte/Celular  - 01', 0),
(19, 12, 'Suporte/Celular  - 02', 0),
(20, 12, 'Suporte/Celular  - 03', 0),
(21, 12, 'Suporte/Celular  - 04', 0),
(22, 12, 'Suporte/Celular  - 05', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tipo_item`
--

DROP TABLE IF EXISTS `tipo_item`;
CREATE TABLE IF NOT EXISTS `tipo_item` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(64) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tipo_item`
--

INSERT INTO `tipo_item` (`id`, `descricao`) VALUES
(1, 'C/Fio'),
(2, 'S/Fio'),
(3, 'Mini'),
(4, 'Universal');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
