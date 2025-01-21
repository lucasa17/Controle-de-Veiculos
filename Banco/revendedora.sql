-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 16-Jan-2025 às 23:38
-- Versão do servidor: 5.7.36
-- versão do PHP: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `revendedora`
--

DELIMITER $$
--
-- Procedimentos
--
DROP PROCEDURE IF EXISTS `sp_alteraVeiculo`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_alteraVeiculo` (`id` INT, `placa` VARCHAR(7), `modelo` VARCHAR(50), `cor` VARCHAR(15), `ano` INT, `valor` DECIMAL, `marca` INT)  BEGIN

	update veiculos set placa = placa, modelo = modelo, cor = cor, anoFabricacao = ano,
    valor = valor, marca_fk = marca where idVeiculo = id;

END$$

DROP PROCEDURE IF EXISTS `sp_buscaMarca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscaMarca` ()  BEGIN

	select * from marcas order by nome asc;

END$$

DROP PROCEDURE IF EXISTS `sp_buscaVeiculo`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscaVeiculo` ()  BEGIN

	select idVeiculo, placa as Placa, marcas.nome as Marca, modelo as Modelo, cor as Cor, anoFabricacao as Ano, valor as Valor
    from veiculos 
    inner join marcas on veiculos.marca_fk = idMarca;

END$$

DROP PROCEDURE IF EXISTS `sp_deletaVeiculo`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deletaVeiculo` (`id` INT)  BEGIN

	delete from veiculos where idVeiculo = id;

END$$

DROP PROCEDURE IF EXISTS `sp_deleta_veiculo`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deleta_veiculo` (`id` INT)  BEGIN

	delete from veiculos where idVeiculo = id;

END$$

DROP PROCEDURE IF EXISTS `sp_insereEmpresa`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insereEmpresa` (`nome` VARCHAR(50), `email` VARCHAR(50), `senha` VARCHAR(100))  BEGIN

	insert into empresa(nome, email, senha) values (nome, email, senha);

END$$

DROP PROCEDURE IF EXISTS `sp_insereMarca`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insereMarca` (`nome` VARCHAR(25))  BEGIN

	insert into marcas (nome) values (nome);

END$$

DROP PROCEDURE IF EXISTS `sp_insereVeiculo`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insereVeiculo` (`placa` VARCHAR(7), `marca` INT, `modelo` VARCHAR(50), `cor` VARCHAR(15), `ano` INT, `valor` DECIMAL(10,2))  BEGIN

	insert into veiculos(placa, marca_fk, modelo, cor, anoFabricacao, valor) values (placa, marca, modelo, cor, ano, valor);

END$$

DROP PROCEDURE IF EXISTS `sp_login`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_login` (`email` VARCHAR(100), `senha` VARCHAR(100))  BEGIN

	select * from empresa where email = email and senha = senha;

END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `empresa`
--

DROP TABLE IF EXISTS `empresa`;
CREATE TABLE IF NOT EXISTS `empresa` (
  `idEmpresa` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  PRIMARY KEY (`idEmpresa`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `empresa`
--

INSERT INTO `empresa` (`idEmpresa`, `nome`, `email`, `senha`) VALUES
(3, 'Empresa do Lucas', 'adm@gmail.com', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3'),
(4, 'bc', 'asd', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3');

-- --------------------------------------------------------

--
-- Estrutura da tabela `marcas`
--

DROP TABLE IF EXISTS `marcas`;
CREATE TABLE IF NOT EXISTS `marcas` (
  `idMarca` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(25) NOT NULL,
  PRIMARY KEY (`idMarca`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `marcas`
--

INSERT INTO `marcas` (`idMarca`, `nome`) VALUES
(1, 'Honda'),
(2, 'Ford'),
(3, 'Chevrolet'),
(4, 'Fiat'),
(5, 'Renault'),
(6, 'BMW');

-- --------------------------------------------------------

--
-- Estrutura da tabela `veiculos`
--

DROP TABLE IF EXISTS `veiculos`;
CREATE TABLE IF NOT EXISTS `veiculos` (
  `idVeiculo` int(11) NOT NULL AUTO_INCREMENT,
  `placa` varchar(7) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `cor` varchar(15) NOT NULL,
  `anoFabricacao` int(11) NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `marca_fk` int(11) NOT NULL,
  PRIMARY KEY (`idVeiculo`),
  UNIQUE KEY `placa` (`placa`),
  KEY `marca_fk` (`marca_fk`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `veiculos`
--

INSERT INTO `veiculos` (`idVeiculo`, `placa`, `modelo`, `cor`, `anoFabricacao`, `valor`, `marca_fk`) VALUES
(6, 'hrs1234', 'Ka', 'Prata', 2016, '30000.00', 2),
(12, 'asd4527', 'Onix Lt', 'Branco', 2017, '42000.00', 3),
(9, 'rtf1234', 'Onix', 'Branco', 2017, '52000.00', 3);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
