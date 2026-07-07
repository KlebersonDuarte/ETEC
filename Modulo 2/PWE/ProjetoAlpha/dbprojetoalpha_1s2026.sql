-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 16/06/2026 às 18:31
-- Versão do servidor: 8.3.0
-- Versão do PHP: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `dbprojetoalpha_1s2026`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_pedido`
--

DROP TABLE IF EXISTS `tb_pedido`;
CREATE TABLE IF NOT EXISTS `tb_pedido` (
  `ID_PEDIDO` int NOT NULL AUTO_INCREMENT,
  `ID_USUARIO` int NOT NULL,
  `NOME_PEDIDO` varchar(60) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `BANCO_PEDIDO` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `CONTA_PEDIDO` char(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `TAXA_PEDIDO` decimal(3,1) NOT NULL,
  `MESES_PEDIDO` int NOT NULL,
  `CAPITAL_PEDIDO` decimal(7,2) NOT NULL,
  `RENDIMENTO_PEDIDO` decimal(7,2) NOT NULL,
  `TOTAL_PEDIDO` decimal(7,2) NOT NULL,
  PRIMARY KEY (`ID_PEDIDO`),
  KEY `ID_USUARIO` (`ID_USUARIO`)
) ENGINE=MyISAM AUTO_INCREMENT=50 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Despejando dados para a tabela `tb_pedido`
--

INSERT INTO `tb_pedido` (`ID_PEDIDO`, `ID_USUARIO`, `NOME_PEDIDO`, `BANCO_PEDIDO`, `CONTA_PEDIDO`, `TAXA_PEDIDO`, `MESES_PEDIDO`, `CAPITAL_PEDIDO`, `RENDIMENTO_PEDIDO`, `TOTAL_PEDIDO`) VALUES
(4, 3, 'Kleber', 'Banco Itaú', '2311', 2.8, 6, 1.00, 1.18, 1.18),
(7, 3, 'Kleberson', 'Banco do Brasil', '2310', 0.8, 12, 1000.00, 1093.81, 1093.81),
(8, 5, 'Ronaldo', 'Banco caixa Econômica Federal', '2311', 0.8, 4, 1000.00, 1030.34, 1030.34),
(9, 7, 'Kleber', 'Banco Itaú', '2311', 1.8, 6, 1000.00, 1109.70, 1109.70),
(10, 7, 'Kleber', 'Banco Itaú', '2311', 1.8, 6, 1000.00, 1109.70, 1109.70),
(11, 8, 'Kleber', 'Banco Itaú', '2311', 1.8, 6, 1000.00, 1109.70, 1109.70),
(12, 9, 'Kleber', 'Banco Itaú', '2311', 1.8, 6, 1000.00, 1109.70, 1109.70),
(13, 9, 'Pablo', 'Banco caixa Econômica Federal', '1231', 1.8, 36, 2221.00, 4147.51, 4147.51),
(14, 9, 'Pablo', 'Banco caixa Econômica Federal', '1231', 2.5, 1, 2123.00, 2176.08, 2176.08),
(15, 10, 'Pablo', 'Banco caixa Econômica Federal', '1231', 1.8, 4, 213.00, 228.31, 228.31),
(16, 10, 'Pablo', 'Banco caixa Econômica Federal', '1231', 1.8, 4, 213.00, 228.31, 228.31),
(17, 10, 'Pablo', 'Banco caixa Econômica Federal', '1231', 1.8, 4, 213.00, 228.31, 228.31),
(18, 13, 'Ronaldo', 'Banco do Brasil', '1234', 1.5, 5, 2123.00, 2287.07, 2287.07),
(19, 14, 'Ronaldo', 'Banco do Brasil', '1234', 1.5, 5, 2123.00, 2287.07, 2287.07),
(20, 15, 'Gusavo', 'Banco caixa Econômica Federal', '2131', 2.0, 5, 2123.00, 2343.96, 2343.96),
(21, 16, 'Teixeira', 'Banco caixa Econômica Federal', '2131', 2.0, 5, 2123.00, 2343.96, 2343.96),
(22, 17, 'Gusavo', 'Banco caixa Econômica Federal', '2131', 2.0, 5, 2123.00, 2343.96, 2343.96),
(23, 18, 'Gusavo', 'Banco caixa Econômica Federal', '2131', 2.0, 5, 2123.00, 2343.96, 2343.96),
(24, 19, 'Pedro', 'Banco caixa Econômica Federal', '2132', 1.5, 5, 2123.00, 2287.07, 2287.07),
(25, 20, 'Pedro', 'Banco caixa Econômica Federal', '2132', 1.5, 5, 2123.00, 2287.07, 2287.07),
(26, 22, 'Pedro', 'Banco caixa Econômica Federal', '2132', 1.5, 5, 2123.00, 2287.07, 2287.07),
(27, 23, 'Ronaldo', 'Banco Itaú', '9990', 1.5, 2, 12312.00, 12684.13, 12684.13),
(28, 24, 'Ricardo Ricardo Ricardo', 'Banco Santander', '2123', 1.0, 4, 213.00, 221.65, 221.65),
(29, 24, 'Ricardo Ricardo Ricardo', 'Banco Itaú', '1231', 1.5, 6, 12.00, 13.12, 13.12),
(30, 24, 'Ricardo Ricardo Ricardo', 'Banco Itaú', '1231', 1.5, 6, 12.00, 13.12, 13.12),
(31, 24, 'Ricardo Ricardo Ricardo', 'Banco Itaú', '1231', 1.5, 6, 12.00, 13.12, 13.12),
(32, 24, 'Ricardo Ricardo Ricardo', 'Banco Itaú', '1231', 1.5, 6, 12.00, 13.12, 13.12),
(33, 24, 'Ricardo Ricardo Ricardo', 'Banco Itaú', '1231', 1.5, 6, 12.00, 13.12, 13.12),
(34, 14, 'Ronaldo', 'Banco Itaú', '1231', 1.5, 4, 123.00, 130.55, 130.55),
(35, 14, 'Ronaldo', 'Banco Itaú', '1231', 1.5, 4, 123.00, 130.55, 130.55),
(36, 14, 'Ronaldo', 'Banco Itaú', '1231', 1.5, 4, 123.00, 130.55, 130.55),
(37, 14, 'Ronaldo', 'Banco Itaú', '1231', 1.5, 4, 123.00, 130.55, 130.55),
(38, 14, 'Ronaldo', 'Banco Itaú', '1231', 1.5, 4, 123.00, 130.55, 130.55),
(39, 14, 'Ronaldo', 'Banco Itaú', '1231', 1.5, 4, 123.00, 130.55, 130.55),
(40, 14, 'Ronaldo', 'Banco Itaú', '1231', 1.5, 4, 123.00, 130.55, 130.55),
(41, 24, 'Ricardo Ricardo Ric', 'Banco caixa Econômica Federal', '1234', 2.5, 6, 5454.00, 6324.97, 6324.97),
(42, 24, 'Ricardo Ricardo Ric', 'Banco caixa Econômica Federal', '1234', 2.5, 6, 5454.00, 6324.97, 6324.97),
(43, 24, 'Ricardo Ricardo Ric', 'Banco caixa Econômica Federal', '1234', 2.5, 6, 5454.00, 6324.97, 6324.97),
(44, 18, 'Berto', 'Banco do Brasil', '213', 2.0, 3, 123.00, 130.53, 130.53),
(45, 18, 'Berto', 'Banco do Brasil', '213', 2.0, 3, 123.00, 130.53, 130.53),
(46, 9, 'Klebera', 'Banco caixa Econômica Federal', '1333', 4.5, 36, 3331.00, 16246.55, 16246.55),
(47, 9, 'Klebera', 'Banco caixa Econômica Federal', '1333', 4.5, 36, 3331.00, 16246.55, 16246.55),
(48, 9, 'Kleber', 'Banco do Brasil', '1231', 3.8, 12, 999.00, 1553.90, 1553.90),
(49, 22, 'Pedros', 'Banco Santander', '0001', 1.0, 6, 1000.00, 1061.52, 1061.52);

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_usuario`
--

DROP TABLE IF EXISTS `tb_usuario`;
CREATE TABLE IF NOT EXISTS `tb_usuario` (
  `ID_USUARIO` int UNSIGNED NOT NULL AUTO_INCREMENT,
  `EMAIL_USUARIO` varchar(60) NOT NULL,
  `SENHA_USUARIO` varchar(30) NOT NULL,
  `CPF_USUARIO` char(14) NOT NULL,
  PRIMARY KEY (`ID_USUARIO`),
  UNIQUE KEY `EMAIL_USUARIO` (`EMAIL_USUARIO`),
  UNIQUE KEY `CPF_USUARIO` (`CPF_USUARIO`)
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Despejando dados para a tabela `tb_usuario`
--

INSERT INTO `tb_usuario` (`ID_USUARIO`, `EMAIL_USUARIO`, `SENHA_USUARIO`, `CPF_USUARIO`) VALUES
(9, 'klebero@gmail.com', '1234', '984.458.012-67'),
(10, 'pablo@gmail.com', '123', '1231231231'),
(14, 'po@gmail.com', '321', '6869213231'),
(18, 'g@gmail.com', '321', '3213131451'),
(22, 'silvaS@gmail.com', '321', '21312314132'),
(23, 'eraRonaldo@gmail.com', '901', '901906967'),
(24, 'ricar@gmail.com', '321', '6767121131');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
