-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.32-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para revendedora
CREATE DATABASE IF NOT EXISTS `revendedora` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `revendedora`;

-- Copiando estrutura para tabela revendedora.empresa
CREATE TABLE IF NOT EXISTS `empresa` (
  `idEmpresa` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  PRIMARY KEY (`idEmpresa`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela revendedora.marcas
CREATE TABLE IF NOT EXISTS `marcas` (
  `idMarca` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(25) NOT NULL,
  PRIMARY KEY (`idMarca`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para procedure revendedora.sp_alteraVeiculo
DELIMITER //
CREATE PROCEDURE `sp_alteraVeiculo`(`id` INT, `placa` VARCHAR(7), `modelo` VARCHAR(50), `cor` VARCHAR(15), `ano` INT, `valor` DECIMAL, `marca` INT)
BEGIN

	update veiculos set placa = placa, modelo = modelo, cor = cor, anoFabricacao = ano,
    valor = valor, marca_fk = marca where idVeiculo = id;

END//
DELIMITER ;

-- Copiando estrutura para procedure revendedora.sp_buscaMarca
DELIMITER //
CREATE PROCEDURE `sp_buscaMarca`()
BEGIN

	select idMarca, nome as Marcas from marcas order by nome asc;

END//
DELIMITER ;

-- Copiando estrutura para procedure revendedora.sp_buscaVeiculo
DELIMITER //
CREATE PROCEDURE `sp_buscaVeiculo`()
BEGIN

	select idVeiculo, placa as Placa, marcas.nome as Marca, modelo as Modelo, cor as Cor, anoFabricacao as Ano, valor as Valor
    from veiculos 
    inner join marcas on veiculos.marca_fk = idMarca where veiculos.status = 0;

END//
DELIMITER ;

-- Copiando estrutura para procedure revendedora.sp_buscaVendas
DELIMITER //
CREATE PROCEDURE `sp_buscaVendas`()
BEGIN

SELECT 
    v.idVendas, 
    v.idVeiculo_fk, 
    v.dataVenda AS Data, 
    v.nomeComprador AS Comprador, 
    v.valor AS Valor, 
    m.nome AS Marca, 
    ve.modelo AS Modelo, 
    ve.cor AS Cor, 
    ve.anoFabricacao AS Ano
FROM 
    vendas v
JOIN 
    veiculos ve ON v.idVeiculo_fk = ve.idVeiculo
JOIN 
    marcas m ON ve.marca_fk = m.idMarca;

END//
DELIMITER ;

-- Copiando estrutura para procedure revendedora.sp_cadastroCheck
DELIMITER //
CREATE PROCEDURE `sp_cadastroCheck`(`user` VARCHAR(100))
BEGIN

			select * from empresa where email = user;

END//
DELIMITER ;

-- Copiando estrutura para procedure revendedora.sp_deletaMarca
DELIMITER //
CREATE PROCEDURE `sp_deletaMarca`(id int)
BEGIN

	delete from marcas where idMarca = id;

END//
DELIMITER ;

-- Copiando estrutura para procedure revendedora.sp_deletaVeiculo
DELIMITER //
CREATE PROCEDURE `sp_deletaVeiculo`(`id` INT)
BEGIN

	delete from veiculos where idVeiculo = id;

END//
DELIMITER ;

-- Copiando estrutura para procedure revendedora.sp_deleta_veiculo
DELIMITER //
CREATE PROCEDURE `sp_deleta_veiculo`(`id` INT)
BEGIN

	delete from veiculos where idVeiculo = id;

END//
DELIMITER ;

-- Copiando estrutura para procedure revendedora.sp_insereEmpresa
DELIMITER //
CREATE PROCEDURE `sp_insereEmpresa`(`nome` VARCHAR(50), `email` VARCHAR(50), `senha` VARCHAR(100))
BEGIN

	insert into empresa(nome, email, senha) values (nome, email, senha);

END//
DELIMITER ;

-- Copiando estrutura para procedure revendedora.sp_insereMarca
DELIMITER //
CREATE PROCEDURE `sp_insereMarca`(`nome` VARCHAR(25))
BEGIN

	insert into marcas (nome) values (nome);

END//
DELIMITER ;

-- Copiando estrutura para procedure revendedora.sp_insereVeiculo
DELIMITER //
CREATE PROCEDURE `sp_insereVeiculo`(`placa` VARCHAR(7), `marca` INT, `modelo` VARCHAR(50), `cor` VARCHAR(15), `ano` INT, `valor` DECIMAL(10,2))
BEGIN

	insert into veiculos(placa, marca_fk, modelo, cor, anoFabricacao, valor, status) values (placa, marca, modelo, cor, ano, valor, 0);

END//
DELIMITER ;

-- Copiando estrutura para procedure revendedora.sp_login
DELIMITER //
CREATE PROCEDURE `sp_login`(`user` VARCHAR(100), `password` VARCHAR(100))
BEGIN

	select * from empresa where email = user and senha = password;

END//
DELIMITER ;

-- Copiando estrutura para procedure revendedora.sp_vendeVeiculo
DELIMITER //
CREATE PROCEDURE `sp_vendeVeiculo`(nome varchar(100), data date, valor decimal(10,2), id int)
BEGIN

	insert into vendas (nomeComprador, dataVenda, valor, idVeiculo_fk) values (nome, data, valor, id);
    
    update veiculos set status = 1 where idVeiculo = id;

END//
DELIMITER ;

-- Copiando estrutura para tabela revendedora.veiculos
CREATE TABLE IF NOT EXISTS `veiculos` (
  `idVeiculo` int(11) NOT NULL AUTO_INCREMENT,
  `placa` varchar(8) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `cor` varchar(15) NOT NULL,
  `anoFabricacao` int(11) NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `marca_fk` int(11) NOT NULL,
  `status` bit(1) NOT NULL,
  PRIMARY KEY (`idVeiculo`),
  UNIQUE KEY `placa` (`placa`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela revendedora.vendas
CREATE TABLE IF NOT EXISTS `vendas` (
  `idVendas` int(11) NOT NULL AUTO_INCREMENT,
  `dataVenda` date DEFAULT NULL,
  `nomeComprador` varchar(100) DEFAULT NULL,
  `idVeiculo_fk` int(11) NOT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`idVendas`),
  KEY `idVeiculo_fk` (`idVeiculo_fk`),
  CONSTRAINT `vendas_ibfk_1` FOREIGN KEY (`idVeiculo_fk`) REFERENCES `veiculos` (`idVeiculo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Exportação de dados foi desmarcado.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
