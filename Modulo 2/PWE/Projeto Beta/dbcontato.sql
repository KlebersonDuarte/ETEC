-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 04/05/2026 às 23:59
-- Versão do servidor: 8.4.7
-- Versão do PHP: 8.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `dbcontato`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_cadastro_adm`
--

DROP TABLE IF EXISTS `tb_cadastro_adm`;
CREATE TABLE IF NOT EXISTS `tb_cadastro_adm` (
  `ID_ADM` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `NOME_ADM` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `EMAIL_ADM` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `SENHA_ADM` varchar(8) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`ID_ADM`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_faleconosco`
--

DROP TABLE IF EXISTS `tb_faleconosco`;
CREATE TABLE IF NOT EXISTS `tb_faleconosco` (
  `ID_CONTATO` int NOT NULL AUTO_INCREMENT,
  `NOME_CONTATO` varchar(60) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `FONE_CONTATO` char(17) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `EMAIL_CONTATO` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `ASSUNTO_CONTATO` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `MSG_CONTATO` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `RESP_CONTATO` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
  PRIMARY KEY (`ID_CONTATO`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Despejando dados para a tabela `tb_faleconosco`
--

INSERT INTO `tb_faleconosco` (`ID_CONTATO`, `NOME_CONTATO`, `FONE_CONTATO`, `EMAIL_CONTATO`, `ASSUNTO_CONTATO`, `MSG_CONTATO`, `RESP_CONTATO`) VALUES
(1, 'kleberson duarte santos', '11960670772', 'klebersonduartesantos39@gmail.com', 'Elogios', 'as', NULL),
(2, 'kleberson duarte santos', '11960670772', 'klebersonduartesantos39@gmail.com', 'Elogios', 'as', NULL);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
