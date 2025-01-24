-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema revendedora
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema revendedora
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `revendedora` DEFAULT CHARACTER SET utf8mb4 ;
USE `revendedora` ;

-- -----------------------------------------------------
-- Table `revendedora`.`empresa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `revendedora`.`empresa` (
  `idEmpresa` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  `senha` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`idEmpresa`))
ENGINE = MyISAM
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `revendedora`.`marcas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `revendedora`.`marcas` (
  `idMarca` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(25) NOT NULL,
  PRIMARY KEY (`idMarca`))
ENGINE = MyISAM
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `revendedora`.`veiculos`
-- -----------------------------------------------------
-- Create veiculos table
CREATE TABLE IF NOT EXISTS `revendedora`.`veiculos` (
  `idVeiculo` INT(11) NOT NULL AUTO_INCREMENT,
  `placa` VARCHAR(7) NOT NULL,
  `modelo` VARCHAR(50) NOT NULL,
  `cor` VARCHAR(15) NOT NULL,
  `anoFabricacao` INT(11) NOT NULL,
  `valor` DECIMAL(10,2) NOT NULL,
  `marca_fk` INT(11) NOT NULL,
  `status` BIT(1) NOT NULL,
  PRIMARY KEY (`idVeiculo`),
  UNIQUE INDEX `placa` (`placa` ASC),
  INDEX `marca_fk` (`marca_fk` ASC)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

-- Create vendas table
CREATE TABLE IF NOT EXISTS `revendedora`.`vendas` (
  `idVendas` INT(11) NOT NULL AUTO_INCREMENT,
  `dataVenda` DATE NULL DEFAULT NULL,
  `nomeComprador` VARCHAR(100) NULL DEFAULT NULL,
  `cpfComprador` VARCHAR(14) NULL DEFAULT NULL,
  `idVeiculo_fk` INT(11) NOT NULL,
  PRIMARY KEY (`idVendas`),
  UNIQUE INDEX `cpfComprador` (`cpfComprador` ASC),
  FOREIGN KEY (`idVeiculo_fk`) REFERENCES `revendedora`.`veiculos`(`idVeiculo`)
    ON UPDATE CASCADE
    ON DELETE CASCADE
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4
-- -----------------------------------------------------
-- procedure sp_alteraVeiculo
-- -----------------------------------------------------

DELIMITER $$
USE `revendedora`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_alteraVeiculo`(`id` INT, `placa` VARCHAR(7), `modelo` VARCHAR(50), `cor` VARCHAR(15), `ano` INT, `valor` DECIMAL, `marca` INT)
BEGIN

	update veiculos set placa = placa, modelo = modelo, cor = cor, anoFabricacao = ano,
    valor = valor, marca_fk = marca where idVeiculo = id;

END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_buscaMarca
-- -----------------------------------------------------

DELIMITER $$
USE `revendedora`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscaMarca`()
BEGIN

	select * from marcas order by nome asc;

END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_buscaVeiculo
-- -----------------------------------------------------

DELIMITER $$
USE `revendedora`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_buscaVeiculo`()
BEGIN

	select idVeiculo, placa as Placa, marcas.nome as Marca, modelo as Modelo, cor as Cor, anoFabricacao as Ano, valor as Valor
    from veiculos 
    inner join marcas on veiculos.marca_fk = idMarca;

END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_deletaVeiculo
-- -----------------------------------------------------

DELIMITER $$
USE `revendedora`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deletaVeiculo`(`id` INT)
BEGIN

	delete from veiculos where idVeiculo = id;

END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_deleta_veiculo
-- -----------------------------------------------------

DELIMITER $$
USE `revendedora`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deleta_veiculo`(`id` INT)
BEGIN

	delete from veiculos where idVeiculo = id;

END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insereEmpresa
-- -----------------------------------------------------

DELIMITER $$
USE `revendedora`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insereEmpresa`(`nome` VARCHAR(50), `email` VARCHAR(50), `senha` VARCHAR(100))
BEGIN

	insert into empresa(nome, email, senha) values (nome, email, senha);

END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insereMarca
-- -----------------------------------------------------

DELIMITER $$
USE `revendedora`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insereMarca`(`nome` VARCHAR(25))
BEGIN

	insert into marcas (nome) values (nome);

END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insereVeiculo
-- -----------------------------------------------------

DELIMITER $$
USE `revendedora`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insereVeiculo`(`placa` VARCHAR(7), `marca` INT, `modelo` VARCHAR(50), `cor` VARCHAR(15), `ano` INT, `valor` DECIMAL(10,2))
BEGIN

	insert into veiculos(placa, marca_fk, modelo, cor, anoFabricacao, valor) values (placa, marca, modelo, cor, ano, valor);

END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_login
-- -----------------------------------------------------

DELIMITER $$
USE `revendedora`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_login`(`email` VARCHAR(100), `senha` VARCHAR(100))
BEGIN

	select * from empresa where email = email and senha = senha;

END$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
