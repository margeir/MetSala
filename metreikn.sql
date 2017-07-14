/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50144
Source Host           : localhost:3306
Source Database       : metreikn

Target Server Type    : MYSQL
Target Server Version : 50144
File Encoding         : 65001

Date: 2010-03-08 14:52:50
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
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=latin1;

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
INSERT INTO `solumenn` VALUES ('1', 'Margeir Reynisson', 'margeir', '0101675319', '6631771', 'margeir@met.is', '2101');
INSERT INTO `solumenn` VALUES ('2', 'Elín Baldursdóttir', 'elin', '2610653789', '6631773', 'elin@met.is', '2101');

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
INSERT INTO `vidskm` VALUES ('3', '6212043780', '911 Tækniþjónusta ehf', 'Drekavöllum 6', '221', 'Hafnarfirði', '6212043780', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('4', '5711043180', 'Acta lögmannsstofa ehf.', 'Reykjavíkurvegi 62', '220', 'Hafnarfirði', '5711043180', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('5', '6909953019', 'Austurstræti Eignarhald ehf', 'Austurstræti 7', '101', 'Reykjavík', '6909953019', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('6', '5506043020', 'Beis ehf.', 'Skógarhlíð 5', '220', 'Hafnarfirði', '5506043020', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('7', '6508042360', 'Eidel ehf.', 'Hamraborg 7', '200', 'Kópavogi', '6508042360', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('8', '4512953149', 'Félag byggingafulltrúa', 'Álftarima 34', '800', 'Selfossi', '4512953149', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('9', '4604760899', 'Félag eldri borgara í Hafnarfi', 'Flatahrauni 3', '220', 'Hafnarfirði', '4604760899', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('10', '5301696189', 'Félag pípulagningameistara', 'Skipholti 70', '105', 'Reykjavík', '5301696189', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('11', '4301962359', 'Filmverk ehf', 'Austurvegi 4', '800', 'Selfossi', '4301962359', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('12', '6103050750', 'Graníthúsið ehf.', 'Helluhrauni 2', '220', 'Hafnarfirði', '6103050750', '5445100', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('13', '5901697579', 'Hafnarfjarðarbær', 'Strandgötu 6', '220', 'Hafnarfirði', '5901697579', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('14', '5901697572', 'Námsflokkar Hafnarfjarðar', 'Strandgötu 6', '220', 'Hafnarfirði', '5901697579', '0', '@', 'Námsflokkar Hafnarfjarðar', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('15', '6103071240', 'Heimavarnir ehf.', 'Skútahraun 2', '220', 'Hafnarfirði', '6103071240', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('16', '0701612149', 'Hjálmar Ólafsson', 'Kárdalstungu', '540', 'Blönduósi', '0701612149', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('17', '1208592699', 'Hólmfríður E. Guðmundsdóttir', 'Mjósundi 10', '220', 'Hafnarfirði', '1208592699', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('18', '6510071000', 'iRobot ehf.', 'Hólshraun 7', '220', 'Hafnarfirði', '6510071000', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('19', '4309080810', 'Íspartar ehf.', 'Lundarbrekku 6', '200', 'Kópavogi', '4309080810', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('20', '5908042150', 'Joe boxer Ísland ehf.', 'Ögurhvarf 8', '203', 'Kópavogi', '5908042150', '5655600', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('21', '4202091930', 'Kostur lágvöruverðsverslun ehf', 'Dalvegi 10-14', '200', 'Kópavogi', '4202091930', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('22', '7001693759', 'Kópavogsbær', 'Fannborg 2', '200', 'Kópavogi', '7001693759', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('23', '4701080880', 'Landnám Ingimundar Gamla', 'Hvammi 2', '541', 'Blönduósi', '4701080880', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('24', '5910060290', 'Leiðtogaþjálfun ehf.', 'Ármúla 11', '108', 'Reykjavík', '5910060290', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('25', '6911042060', 'Lesblinda ehf.', 'Furuvellir 31', '221', 'Hafnarfirði', '6911042060', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('26', '5401740409', 'Ljósmyndavörur ehf.', 'Skipholti 31', '105', 'Reykjavík', '5401740409', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('27', '5001024110', 'Lögfræðimiðstöðin ehf.', 'Reykjavíkurvegi 62', '220', 'Hafnarfirði', '5001024110', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('28', '6106070710', 'Merkurpoint ehf', 'Grensásvegi 22', '108', 'Reykjavík', '6106070710', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('29', '4609042850', 'Merlin ehf.', 'Hamraborg 7', '200', 'Kópavogi', '4609042850', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('30', '5008891019', 'Myndsmiðjan ehf.', 'Dynskógar 4', '700', 'Egilsstöðum', '5008891019', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('31', '5806070470', 'Netbílar ehf.', 'Hlíðasmára 2', '201', 'Kópavogi', '5806070470', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('32', '5411032010', 'Og Svo ehf.', 'Brautarholt 4a', '105', 'Reykjavík', '5411032010', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('33', '5503850749', 'Samtak ehf.', 'Skútahrauni 11', '220', 'Hafnarfirði', '5503850749', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('34', '4206090940', 'Selið á Stokkalæk ehf.', 'Stokkalæk', '851', 'Hellu', '4206090940', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('35', '1308713809', 'Sigríður Svanborgardóttir', 'Engjahlíð 5', '221', 'Hafnarfirði', '1308713809', '5447800', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('36', '5908942819', 'Sigurnes hf.', 'Suðurlandsbraut 30', '108', 'Reykjavík', '5908942819', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('37', '4701101980', 'Skattur og Bókhald slf.', 'Súðavogi 7', '104', 'Reykjavík', '4701101980', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('38', '4603024470', 'Stafræn sýn ehf.', 'Flétturima 1', '112', 'Reykjavík', '4603024470', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('39', '7006720939', 'Starfsmannafélag Hafnarfjarðar', 'Hellisgötu 16', '220', 'Hafnarfirði', '7006720939', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('40', '4401696869', 'Sveitarfélagið Álftanes', 'Bjarnastöðum ', '225', 'Álftanesi', '4401696869', '0', '@', 'Álftaneslaug', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('41', '0512683349', 'Valdemar Johnsen', 'Reynilundi 11', '210', 'Garðabæ', '0512683349', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('42', '6802962359', 'Veislulist ehf.', 'Hólshraun 3', '220', 'Hafnarfirði', '6802962359', '0', '@', '0', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('43', '1404675379', 'Vignir Rafn Gíslason', 'Seiðakvísl 34', '110', 'Reykjavík', '1404675379', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('44', '6605032930', 'Virgó ehf.', 'Ögurhvarf 8', '201', 'Kópavogi', '6605032930', '0', '@', '0', '2010-03-01', 'V', 'N');
INSERT INTO `vidskm` VALUES ('45', '6406080130', 'Öryggisvaktin ehf.', 'Lindarsmára 9', '201', 'Kópavogi', '6406080130', '0', '@', 'Þráinn Ingimundarson', '2010-03-01', 'V', 'Y');
INSERT INTO `vidskm` VALUES ('46', '4107022820', 'Heimili ehf-fasteignasala', 'Skipholti 29a', '105', 'Reykjavík', '410702-2820', '5306500', 'finnbogi@heimili.is', 'Finnbogi Hilmarsson', '2010-03-02', 'V', 'N');
INSERT INTO `vidskm` VALUES ('47', '0', 'STAÐGREIÐSLA', ' ', '0', ' ', '0', ' ', ' ', ' ', '2010-03-02', 'V', 'N');

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
