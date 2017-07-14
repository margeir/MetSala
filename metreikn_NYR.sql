/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50144
Source Host           : localhost:3306
Source Database       : metreikn

Target Server Type    : MYSQL
Target Server Version : 50144
File Encoding         : 65001

Date: 2010-03-09 11:53:06
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `reikn_item`
-- ----------------------------
DROP TABLE IF EXISTS `reikn_item`;
CREATE TABLE `reikn_item` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_reikn` int(11) NOT NULL,
  `lysing` varchar(45) NOT NULL,
  `item` varchar(15) NOT NULL,
  `qty` int(11) NOT NULL,
  `verd` float(10,2) NOT NULL,
  `vsk` float(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=116 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of reikn_item
-- ----------------------------
INSERT INTO `reikn_item` VALUES ('1', '100000', 'Vinna tölvur', '100', '4', '8580.00', '2188.00');


-- ----------------------------
-- Table structure for `reikningar`
-- ----------------------------
DROP TABLE IF EXISTS `reikningar`;
CREATE TABLE `reikningar` (
  `id` int(11) NOT NULL,
  `stofnd` date NOT NULL,
  `vidskm_nr` varchar(15) NOT NULL,
  `stadur` varchar(45) NOT NULL,
  `pnr` int(11) NOT NULL,
  `heimili` varchar(30) NOT NULL,
  `reiknd` date NOT NULL,
  `samtals` double(10,0) NOT NULL,
  `vsk` double(10,0) NOT NULL,
  `solumadur` varchar(50) NOT NULL,
  `texti` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of reikningar
-- ----------------------------
INSERT INTO `reikningar` VALUES ('100000', '2010-03-02', '4107022820', '', '0', '', '2010-02-26', '34320', '8752', 'Margeir Reynisson', null);


-- ----------------------------
-- Table structure for `sam_item`
-- ----------------------------
DROP TABLE IF EXISTS `sam_item`;
CREATE TABLE `sam_item` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_reikn` int(11) NOT NULL,
  `lysing` varchar(45) NOT NULL,
  `item` varchar(15) NOT NULL DEFAULT '',
  `qty` int(11) NOT NULL,
  `verd` float(10,2) NOT NULL,
  `vsk` float(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of sam_item
-- ----------------------------
-- Margeir INSERT INTO `sam_item` VALUES ('1', '20', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');


-- ----------------------------
-- Table structure for `samningar`
-- ----------------------------
DROP TABLE IF EXISTS `samningar`;
CREATE TABLE `samningar` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `stofnd` date NOT NULL,
  `vidskm_nr` varchar(14) NOT NULL,
  `reiknd` date NOT NULL,
  `samtals` double(10,0) NOT NULL,
  `vsk` double(10,0) NOT NULL,
  `solumadur` varchar(50) NOT NULL,
  `texti` text,
  PRIMARY KEY (`id`),
  UNIQUE KEY `VSKM` (`vidskm_nr`)
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of samningar
-- ----------------------------
-- ekki þörf á að hafa samninga INSERT INTO `samningar` VALUES ('5', '2010-03-02', '6909953019', '2010-03-02', '0', '817', 'Margeir Reynisson', null);


-- ----------------------------
-- Table structure for `solumenn`
-- ----------------------------
DROP TABLE IF EXISTS `solumenn`;
CREATE TABLE `solumenn` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nafn` varchar(70) NOT NULL,
  `notendan` varchar(15) NOT NULL,
  `kt` varchar(10) NOT NULL,
  `simi` varchar(7) NOT NULL,
  `netfang` varchar(50) NOT NULL,
  `lykilord` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of solumenn
-- ----------------------------
INSERT INTO `solumenn` VALUES ('1', 'Sale', 'sala', '0000000000', '0000000', 'info@met.is', 'sala');
INSERT INTO `solumenn` VALUES ('2', 'Elín Baldursdóttir', 'elin', '2610653789', '6631773', 'elin@met.is', '2101');
INSERT INTO `solumenn` VALUES ('3', 'Margeir Reynisson', 'margeir', '0101675319', '6631771', 'margeir@met.is', '2101');

-- ----------------------------
-- Table structure for `vidskm`
-- ----------------------------
DROP TABLE IF EXISTS `vidskm`;
CREATE TABLE `vidskm` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nr` varchar(14) NOT NULL,
  `nafn` varchar(40) NOT NULL,
  `heimili` varchar(30) NOT NULL,
  `pnr` int(11) NOT NULL,
  `stadur` varchar(45) NOT NULL,
  `kt` varchar(12) NOT NULL,
  `simi` varchar(8) NOT NULL,
  `netfang` varchar(50) NOT NULL,
  `deild` varchar(50) NOT NULL,
  `stofn` date NOT NULL,
  `virkur` char(1) NOT NULL DEFAULT 'V',
  `msamn` char(1) NOT NULL DEFAULT 'N',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of vidskm
-- ----------------------------
INSERT INTO `vidskm` VALUES ('1', '4204932589', 'MetNet ehf.', 'Skútahraun 2', '220', 'Hafnarfirði', '4204932589', '5171026', 'info@metnet.is', '0', '2010-02-23', 'V', 'N');
INSERT INTO `vidskm` VALUES ('2', '0101675319', 'Margeir Reynisson', 'Fjóluvellir 12', '221', 'Hafnarfirði', '0101675319', '5650026', 'margeir@met.is', '0', '2010-02-23', 'V', 'N');
INSERT INTO `vidskm` VALUES ('3', '0', 'STAÐGREIÐSLA', ' ', '0', ' ', '0', ' ', ' ', ' ', '2010-03-02', 'V', 'N');

-- ----------------------------
-- Table structure for `vorur`
-- ----------------------------
DROP TABLE IF EXISTS `vorur`;
CREATE TABLE `vorur` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `vitem` varchar(15) NOT NULL,
  `vnafn` varchar(40) NOT NULL,
  `verd` double(10,2) NOT NULL,
  `vsk` double(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of vorur
-- ----------------------------
INSERT INTO `vorur` VALUES ('1', '2', 'Álag helgidagar', '0.00', '2.55');
INSERT INTO `vorur` VALUES ('2', '100', 'Vinna tölvur', '8580.00', '2.55');
INSERT INTO `vorur` VALUES ('3', '101', 'Sérfræðiþjónusta', '10200.00', '2.55');
INSERT INTO `vorur` VALUES ('4', '102', 'Vinna v/breytinga á vef', '7200.00', '2.55');
INSERT INTO `vorur` VALUES ('5', '110', 'Vefhýsing tilboð', '3205.00', '2.55');
INSERT INTO `vorur` VALUES ('6', '111', 'Vefhýsing án DB', '1599.00', '0.00');
INSERT INTO `vorur` VALUES ('7', '112', 'Vefhýsing aukalén (aliase)', '1599.00', '0.00');
INSERT INTO `vorur` VALUES ('8', '113', 'Viðbótar gagnagrunnur', '1870.00', '0.00');
INSERT INTO `vorur` VALUES ('9', '114', 'DNS hýsing', '528.00', '0.00');
INSERT INTO `vorur` VALUES ('10', '115', 'Vefhýsing heildsala', '1760.00', '0.00');
INSERT INTO `vorur` VALUES ('11', '121', 'MetMynd vefhýsing', '8200.00', '0.00');
INSERT INTO `vorur` VALUES ('12', '130', 'Hýsing á netþjóni', '35800.00', '0.00');
INSERT INTO `vorur` VALUES ('13', '200', 'Akstur', '1700.00', '0.00');
INSERT INTO `vorur` VALUES ('14', '250', 'Vörur', '0.00', '0.00');
INSERT INTO `vorur` VALUES ('15', '251', 'CAT5 snúra með endum ', '783.00', '0.00');
INSERT INTO `vorur` VALUES ('16', '252', 'Endurnýjun lén ', '6587.00', '0.00');
INSERT INTO `vorur` VALUES ('17', '253', 'Nýtt lén', '10434.00', '0.00');
INSERT INTO `vorur` VALUES ('18', '254', 'Uppsetning V/Nýtt lén', '5221.00', '0.00');
INSERT INTO `vorur` VALUES ('19', '255', 'Ruslpóstsía fyrir notendur', '481.00', '0.00');
INSERT INTO `vorur` VALUES ('20', '30067', 'RISING Antívírus 1N2A', '7841.00', '0.00');
INSERT INTO `vorur` VALUES ('21', 'K100', 'Kennsla tölvur', '9700.00', '0.00');
INSERT INTO `vorur` VALUES ('22', 'SAMN1001', 'SAMNINGUR', '0.00', '0.00');

-- ----------------------------
-- Procedure structure for `add_emp`
-- ----------------------------
DROP PROCEDURE IF EXISTS `add_emp`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_emp`(IN fname VARCHAR(20), IN lname VARCHAR(20), IN bday DATETIME, OUT empno INT)
BEGIN INSERT INTO emp(first_name, last_name, birthdate)
        VALUES(fname, lname, DATE(bday)); 
SET empno = LAST_INSERT_ID(); END;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `hreyfingar`
-- ----------------------------
DROP PROCEDURE IF EXISTS `hreyfingar`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `hreyfingar`(IN  nr  int)
SELECT id,reiknd,samtals,vsk,nafn FROM reikningar LEFT JOIN vidskm ON vidskm.nr = reikningar.vidskm_nr WHERE vidskm_nr = nr;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `hreyfingar_a`
-- ----------------------------
DROP PROCEDURE IF EXISTS `hreyfingar_a`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `hreyfingar_a`()
SELECT reikningar.id,reiknd,samtals,vsk,nafn FROM reikningar LEFT JOIN vidskm ON vidskm.nr = reikningar.vidskm_nr;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `hreyfingar_dags`
-- ----------------------------
DROP PROCEDURE IF EXISTS `hreyfingar_dags`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `hreyfingar_dags`(IN `dags1` date,IN `dags2` date)
SELECT reikningar.id,reiknd,samtals,vsk,nafn FROM reikningar LEFT JOIN vidskm ON vidskm.nr = reikningar.vidskm_nr WHERE reiknd >=  dags1 AND reiknd <=  dags2;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `medsamning`
-- ----------------------------
DROP PROCEDURE IF EXISTS `medsamning`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `medsamning`()
SELECT nr,nafn  FROM vidskm LEFT JOIN samningar ON vidskm.nr = samningar.vidskm_nr;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `nota`
-- ----------------------------
DROP PROCEDURE IF EXISTS `nota`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `nota`()
select * from nota;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `nota2`
-- ----------------------------
DROP PROCEDURE IF EXISTS `nota2`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `nota2`(IN spr INT)
    READS SQL DATA
SELECT item, qty FROM item WHERE id_nota = spr;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `notvor`
-- ----------------------------
DROP PROCEDURE IF EXISTS `notvor`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `notvor`(IN spr INT)
SELECT * FROM sam_item LEFT JOIN vorur ON vorur.vitem = sam_item.item WHERE id_reikn = spr;;
DELIMITER ;
