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
INSERT INTO `reikn_item` VALUES ('2', '100001', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('3', '100002', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('4', '100003', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('5', '100004', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('6', '100005', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('7', '100006', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('8', '100007', 'Vefhýsing tilboð', '110', '10', '32050.00', '8173.00');
INSERT INTO `reikn_item` VALUES ('9', '100007', 'Viðbótar gagnagrunnur', '113', '4', '7480.00', '1907.00');
INSERT INTO `reikn_item` VALUES ('10', '100008', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('11', '100009', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('12', '100010', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('13', '100010', 'DNS hýsing', '114', '1', '528.00', '135.00');
INSERT INTO `reikn_item` VALUES ('14', '100011', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('15', '100012', 'Ruslpóstsía fyrir notendur', '255', '4', '2304.00', '588.00');
INSERT INTO `reikn_item` VALUES ('16', '100012', 'DNS hýsing', '114', '4', '0.00', '0.00');
INSERT INTO `reikn_item` VALUES ('17', '100013', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('18', '100014', 'Vefhýsing tilboð', '110', '2', '6410.00', '1635.00');
INSERT INTO `reikn_item` VALUES ('19', '100014', 'DNS hýsing', '114', '2', '1056.00', '269.00');
INSERT INTO `reikn_item` VALUES ('20', '100014', 'Hýsing á netþjóni', '130', '1', '35800.00', '9129.00');
INSERT INTO `reikn_item` VALUES ('21', '100014', 'MetMynd vefhýsing', '121', '1', '8200.00', '2091.00');
INSERT INTO `reikn_item` VALUES ('22', '100015', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('23', '100016', 'MetMynd vefhýsing', '121', '1', '8200.00', '2091.00');
INSERT INTO `reikn_item` VALUES ('24', '100017', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('25', '100018', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('26', '100019', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('27', '100020', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('28', '100021', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('29', '100022', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('30', '100023', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('31', '100024', 'Vefhýsing tilboð', '110', '2', '6410.00', '1635.00');
INSERT INTO `reikn_item` VALUES ('32', '100024', 'Vinna tölvur', '100', '2', '17160.00', '4376.00');
INSERT INTO `reikn_item` VALUES ('33', '100025', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('34', '100025', 'Vefhýsing aukalén (aliase)', '112', '1', '1599.00', '408.00');
INSERT INTO `reikn_item` VALUES ('35', '100026', 'DNS hýsing', '114', '5', '528.00', '135.00');
INSERT INTO `reikn_item` VALUES ('36', '100026', 'Vefhýsing heildsala', '115', '10', '1760.00', '449.00');
INSERT INTO `reikn_item` VALUES ('37', '100026', 'Vinna tölvur', '100', '8', '8580.00', '2188.00');
INSERT INTO `reikn_item` VALUES ('38', '100026', 'MetMynd vefhýsing', '121', '2', '8200.00', '2091.00');
INSERT INTO `reikn_item` VALUES ('39', '100027', 'Vinna tölvur', '100', '15', '8580.00', '2188.00');
INSERT INTO `reikn_item` VALUES ('40', '100027', 'Akstur', '200', '3', '1700.00', '434.00');
INSERT INTO `reikn_item` VALUES ('41', '100028', 'Vinna tölvur', '100', '10', '8580.00', '2188.00');
INSERT INTO `reikn_item` VALUES ('42', '100028', 'Vefhýsing tilboð', '110', '2', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('43', '100029', 'Vinna tölvur', '100', '10', '8580.00', '2188.00');
INSERT INTO `reikn_item` VALUES ('44', '100029', 'Sérfræðiþjónusta', '101', '1', '10200.00', '2601.00');
INSERT INTO `reikn_item` VALUES ('45', '100030', 'Vinna tölvur', '100', '5', '8580.00', '2188.00');
INSERT INTO `reikn_item` VALUES ('46', '100031', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('47', '100032', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('48', '100033', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('49', '100034', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('50', '100035', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('51', '100036', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('52', '100037', 'Vefhýsing tilboð', '110', '10', '32050.00', '8173.00');
INSERT INTO `reikn_item` VALUES ('53', '100037', 'Viðbótar gagnagrunnur', '113', '4', '7480.00', '1907.00');
INSERT INTO `reikn_item` VALUES ('54', '100038', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('55', '100039', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('56', '100040', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('57', '100040', 'DNS hýsing', '114', '1', '528.00', '135.00');
INSERT INTO `reikn_item` VALUES ('58', '100041', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('59', '100042', 'Ruslpóstsía fyrir notendur', '255', '4', '2304.00', '588.00');
INSERT INTO `reikn_item` VALUES ('60', '100042', 'DNS hýsing', '114', '4', '0.00', '0.00');
INSERT INTO `reikn_item` VALUES ('61', '100043', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('62', '100044', 'Vefhýsing tilboð', '110', '2', '6410.00', '1635.00');
INSERT INTO `reikn_item` VALUES ('63', '100044', 'DNS hýsing', '114', '2', '1056.00', '269.00');
INSERT INTO `reikn_item` VALUES ('64', '100044', 'Hýsing á netþjóni', '130', '1', '35800.00', '9129.00');
INSERT INTO `reikn_item` VALUES ('65', '100044', 'MetMynd vefhýsing', '121', '1', '8200.00', '2091.00');
INSERT INTO `reikn_item` VALUES ('66', '100045', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('67', '100046', 'MetMynd vefhýsing', '121', '1', '8200.00', '2091.00');
INSERT INTO `reikn_item` VALUES ('68', '100047', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('69', '100048', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('70', '100049', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('71', '100049', 'Vefhýsing aukalén (aliase) stokkalækur.is', '112', '1', '580.00', '148.00');
INSERT INTO `reikn_item` VALUES ('72', '100050', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('73', '100051', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('74', '100052', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('75', '100053', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('76', '100054', 'Vefhýsing tilboð', '110', '2', '6410.00', '1635.00');
INSERT INTO `reikn_item` VALUES ('77', '100055', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('78', '100055', 'Vefhýsing aukalén (aliase)', '112', '1', '1599.00', '408.00');
INSERT INTO `reikn_item` VALUES ('79', '100056', 'Sérfræðiþjónusta', '101', '10', '10200.00', '2601.00');
INSERT INTO `reikn_item` VALUES ('80', '100057', 'Vefhýsing heildsala', '115', '15', '1760.00', '449.00');
INSERT INTO `reikn_item` VALUES ('81', '100058', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('82', '100059', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('83', '100060', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('84', '100061', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('85', '100062', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('86', '100063', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('87', '100064', 'Vefhýsing tilboð', '110', '10', '32050.00', '8173.00');
INSERT INTO `reikn_item` VALUES ('88', '100064', 'Viðbótar gagnagrunnur', '113', '4', '7480.00', '1907.00');
INSERT INTO `reikn_item` VALUES ('89', '100065', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('90', '100066', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('91', '100067', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('92', '100067', 'DNS hýsing', '114', '1', '528.00', '135.00');
INSERT INTO `reikn_item` VALUES ('93', '100068', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('94', '100069', 'Ruslpóstsía fyrir notendur', '255', '4', '2304.00', '588.00');
INSERT INTO `reikn_item` VALUES ('95', '100069', 'DNS hýsing', '114', '4', '0.00', '0.00');
INSERT INTO `reikn_item` VALUES ('96', '100070', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('97', '100071', 'Vefhýsing tilboð', '110', '2', '6410.00', '1635.00');
INSERT INTO `reikn_item` VALUES ('98', '100071', 'DNS hýsing', '114', '2', '1056.00', '269.00');
INSERT INTO `reikn_item` VALUES ('99', '100071', 'Hýsing á netþjóni', '130', '1', '35800.00', '9129.00');
INSERT INTO `reikn_item` VALUES ('100', '100071', 'MetMynd vefhýsing', '121', '1', '8200.00', '2091.00');
INSERT INTO `reikn_item` VALUES ('101', '100072', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('102', '100073', 'MetMynd vefhýsing', '121', '1', '8200.00', '2091.00');
INSERT INTO `reikn_item` VALUES ('103', '100074', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('104', '100075', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('105', '100076', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('106', '100076', 'Vefhýsing aukalén (aliase) stokkalækur.is', '112', '1', '580.00', '148.00');
INSERT INTO `reikn_item` VALUES ('107', '100077', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('108', '100078', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('109', '100079', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('110', '100080', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('111', '100081', 'Vefhýsing tilboð', '110', '2', '6410.00', '1635.00');
INSERT INTO `reikn_item` VALUES ('112', '100082', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `reikn_item` VALUES ('113', '100082', 'Vefhýsing aukalén (aliase)', '112', '1', '1599.00', '408.00');
INSERT INTO `reikn_item` VALUES ('114', '100083', 'Vinna tölvur', '100', '15', '8580.00', '2188.00');
INSERT INTO `reikn_item` VALUES ('115', '100084', 'Vinna v/breytinga á vef', '102', '35', '7200.00', '1836.00');

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
INSERT INTO `reikningar` VALUES ('100001', '2010-03-02', '6909953019', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100002', '2010-03-02', '5506043020', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100003', '2010-03-02', '4512953149', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100004', '2010-03-02', '4604760899', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100005', '2010-03-02', '5301696189', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100006', '2010-03-02', '6103050750', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100007', '2010-03-02', '5901697579', '', '0', '', '2010-03-02', '39530', '10080', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100008', '2010-03-02', '6510071000', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100009', '2010-03-02', '4309080810', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100010', '2010-03-02', '5908042150', '', '0', '', '2010-03-02', '3733', '952', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100011', '2010-03-02', '4202091930', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100012', '2010-03-02', '5910060290', '', '0', '', '2010-03-02', '2304', '588', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100013', '2010-03-02', '6911042060', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100014', '2010-03-02', '5401740409', '', '0', '', '2010-03-02', '51466', '13124', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100015', '2010-03-02', '5001024110', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100016', '2010-03-02', '5008891019', '', '0', '', '2010-03-02', '8200', '2091', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100017', '2010-03-02', '5901697572', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100018', '2010-03-02', '5503850749', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100019', '2010-03-02', '4206090940', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100020', '2010-03-02', '1308713809', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100021', '2010-03-02', '5908942819', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100022', '2010-03-02', '7006720939', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100023', '2010-03-02', '4401696869', '', '0', '', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100024', '2010-03-02', '6802962359', '', '0', '', '2010-03-02', '23570', '6010', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100025', '2010-03-02', '6406080130', '', '0', '', '2010-03-02', '4804', '1225', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100026', '2010-03-05', '5411032010', '', '0', '', '2010-03-05', '0', '0', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100027', '2010-03-05', '4301962359', '', '0', '', '2010-03-05', '911100', '232330', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100028', '2010-03-05', '6103050750', '', '0', '', '2010-03-05', '92210', '23514', 'Margeir Reynisson', null);
INSERT INTO `reikningar` VALUES ('100029', '2010-03-08', '0701612149', '', '0', '', '2010-03-08', '96000', '24480', 'Margeir Reynisson', 'Þetta er prufa á því að gera reikninga');
INSERT INTO `reikningar` VALUES ('100030', '2010-03-08', '0101675319', 'Hafnarfirði', '221', 'Fjóluvellir 12', '2010-03-08', '42900', '10940', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100031', '2010-03-08', '6909953019', 'Reykjavík', '101', 'Austurstræti 7', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100032', '2010-03-08', '5506043020', 'Hafnarfirði', '220', 'Skógarhlíð 5', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100033', '2010-03-08', '4512953149', 'Selfossi', '800', 'Álftarima 34', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100034', '2010-03-08', '4604760899', 'Hafnarfirði', '220', 'Flatahrauni 3', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100035', '2010-03-08', '5301696189', 'Reykjavík', '105', 'Skipholti 70', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100036', '2010-03-08', '6103050750', 'Hafnarfirði', '220', 'Helluhrauni 2', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100037', '2010-03-08', '5901697579', 'Hafnarfirði', '220', 'Strandgötu 6', '2010-03-08', '39530', '10080', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100038', '2010-03-08', '6510071000', 'Hafnarfirði', '220', 'Hólshraun 7', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100039', '2010-03-08', '4309080810', 'Kópavogi', '200', 'Lundarbrekku 6', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100040', '2010-03-08', '5908042150', 'Kópavogi', '203', 'Ögurhvarf 8', '2010-03-08', '3733', '952', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100041', '2010-03-08', '4202091930', 'Kópavogi', '200', 'Dalvegi 10-14', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100042', '2010-03-08', '5910060290', 'Reykjavík', '108', 'Ármúla 11', '2010-03-08', '2304', '588', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100043', '2010-03-08', '6911042060', 'Hafnarfirði', '221', 'Furuvellir 31', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100044', '2010-03-08', '5401740409', 'Reykjavík', '105', 'Skipholti 31', '2010-03-08', '51466', '13124', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100045', '2010-03-08', '5001024110', 'Hafnarfirði', '220', 'Reykjavíkurvegi 62', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100046', '2010-03-08', '5008891019', 'Egilsstöðum', '700', 'Dynskógar 4', '2010-03-08', '8200', '2091', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100047', '2010-03-08', '5901697572', 'Hafnarfirði', '220', 'Strandgötu 6', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100048', '2010-03-08', '5503850749', 'Hafnarfirði', '220', 'Skútahrauni 11', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100049', '2010-03-08', '4206090940', 'Hellu', '851', 'Stokkalæk', '2010-03-08', '3785', '965', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100050', '2010-03-08', '1308713809', 'Hafnarfirði', '221', 'Engjahlíð 5', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100051', '2010-03-08', '5908942819', 'Reykjavík', '108', 'Suðurlandsbraut 30', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100052', '2010-03-08', '7006720939', 'Hafnarfirði', '220', 'Hellisgötu 16', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100053', '2010-03-08', '4401696869', 'Álftanesi', '225', 'Bjarnastöðum ', '2010-03-08', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100054', '2010-03-08', '6802962359', 'Hafnarfirði', '220', 'Hólshraun 3', '2010-03-08', '6410', '1635', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100055', '2010-03-08', '6406080130', 'Kópavogi', '201', 'Lindarsmára 9', '2010-03-08', '4804', '1225', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100056', '2010-03-08', '6508042360', 'Kópavogi', '200', 'Hamraborg 7', '2010-03-08', '102000', '26010', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100057', '2010-03-08', '0701612149', 'Blönduósi', '540', 'Kárdalstungu', '2010-03-08', '26400', '6732', 'Margeir Reynisson', 'Þetta er prufa númer ég veit ekki hvað ');
INSERT INTO `reikningar` VALUES ('100058', '2010-03-08', '6909953019', 'Reykjavík', '101', 'Austurstræti 7', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100059', '2010-03-08', '5506043020', 'Hafnarfirði', '220', 'Skógarhlíð 5', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100060', '2010-03-08', '4512953149', 'Selfossi', '800', 'Álftarima 34', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100061', '2010-03-08', '4604760899', 'Hafnarfirði', '220', 'Flatahrauni 3', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100062', '2010-03-08', '5301696189', 'Reykjavík', '105', 'Skipholti 70', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100063', '2010-03-08', '6103050750', 'Hafnarfirði', '220', 'Helluhrauni 2', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100064', '2010-03-08', '5901697579', 'Hafnarfirði', '220', 'Strandgötu 6', '2010-03-31', '39530', '10080', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100065', '2010-03-08', '6510071000', 'Hafnarfirði', '220', 'Hólshraun 7', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100066', '2010-03-08', '4309080810', 'Kópavogi', '200', 'Lundarbrekku 6', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100067', '2010-03-08', '5908042150', 'Kópavogi', '203', 'Ögurhvarf 8', '2010-03-31', '3733', '952', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100068', '2010-03-08', '4202091930', 'Kópavogi', '200', 'Dalvegi 10-14', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100069', '2010-03-08', '5910060290', 'Reykjavík', '108', 'Ármúla 11', '2010-03-31', '2304', '588', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100070', '2010-03-08', '6911042060', 'Hafnarfirði', '221', 'Furuvellir 31', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100071', '2010-03-08', '5401740409', 'Reykjavík', '105', 'Skipholti 31', '2010-03-31', '51466', '13124', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100072', '2010-03-08', '5001024110', 'Hafnarfirði', '220', 'Reykjavíkurvegi 62', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100073', '2010-03-08', '5008891019', 'Egilsstöðum', '700', 'Dynskógar 4', '2010-03-31', '8200', '2091', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100074', '2010-03-08', '5901697572', 'Hafnarfirði', '220', 'Strandgötu 6', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100075', '2010-03-08', '5503850749', 'Hafnarfirði', '220', 'Skútahrauni 11', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100076', '2010-03-08', '4206090940', 'Hellu', '851', 'Stokkalæk', '2010-03-31', '3785', '965', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100077', '2010-03-08', '1308713809', 'Hafnarfirði', '221', 'Engjahlíð 5', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100078', '2010-03-08', '5908942819', 'Reykjavík', '108', 'Suðurlandsbraut 30', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100079', '2010-03-08', '7006720939', 'Hafnarfirði', '220', 'Hellisgötu 16', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100080', '2010-03-08', '4401696869', 'Álftanesi', '225', 'Bjarnastöðum ', '2010-03-31', '3205', '817', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100081', '2010-03-08', '6802962359', 'Hafnarfirði', '220', 'Hólshraun 3', '2010-03-31', '6410', '1635', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100082', '2010-03-08', '6406080130', 'Kópavogi', '201', 'Lindarsmára 9', '2010-03-31', '4804', '1225', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100083', '2010-03-08', '0101675319', 'Hafnarfirði', '221', 'Fjóluvellir 12', '2010-02-01', '128700', '32818', 'Margeir Reynisson', '');
INSERT INTO `reikningar` VALUES ('100084', '2010-03-08', '4202091930', 'Kópavogi', '200', 'Dalvegi 10-14', '2010-02-01', '252000', '64260', 'Margeir Reynisson', '');

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
INSERT INTO `sam_item` VALUES ('1', '20', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('2', '20', 'DNS hýsing', '114', '1', '528.00', '135.00');
INSERT INTO `sam_item` VALUES ('3', '39', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('4', '35', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('5', '30', 'MetMynd vefhýsing', '121', '1', '8200.00', '2091.00');
INSERT INTO `sam_item` VALUES ('6', '27', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('11', '25', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('14', '14', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('15', '9', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('16', '8', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('17', '6', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('18', '33', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('19', '18', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('21', '45', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('22', '45', 'Vefhýsing aukalén (aliase)', '112', '1', '1599.00', '408.00');
INSERT INTO `sam_item` VALUES ('23', '19', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('24', '12', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('25', '10', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('26', '40', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('27', '36', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('28', '21', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('31', '13', 'Vefhýsing tilboð', '110', '10', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('32', '13', 'Viðbótar gagnagrunnur', '113', '4', '1870.00', '477.00');
INSERT INTO `sam_item` VALUES ('33', '26', 'Vefhýsing tilboð', '110', '2', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('34', '26', 'DNS hýsing', '114', '2', '528.00', '135.00');
INSERT INTO `sam_item` VALUES ('35', '26', 'Hýsing á netþjóni', '130', '1', '35800.00', '9129.00');
INSERT INTO `sam_item` VALUES ('36', '26', 'MetMynd vefhýsing', '121', '1', '8200.00', '2091.00');
INSERT INTO `sam_item` VALUES ('38', '5', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('39', '24', 'Ruslpóstsía fyrir notendur', '255', '4', '576.00', '147.00');
INSERT INTO `sam_item` VALUES ('40', '24', 'DNS hýsing', '114', '4', '0.00', '0.00');
INSERT INTO `sam_item` VALUES ('53', '42', 'Vefhýsing tilboð', '110', '2', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('54', '34', 'Vefhýsing tilboð', '110', '1', '3205.00', '817.00');
INSERT INTO `sam_item` VALUES ('55', '34', 'Vefhýsing aukalén (aliase) stokkalækur.is', '112', '1', '580.00', '148.00');

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
INSERT INTO `samningar` VALUES ('5', '2010-03-02', '6909953019', '2010-03-02', '0', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('6', '2010-03-02', '5506043020', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('8', '2010-03-02', '4512953149', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('9', '2010-03-02', '4604760899', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('10', '2010-03-02', '5301696189', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('12', '2010-03-02', '6103050750', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('13', '2001-03-20', '5901697579', '2001-03-20', '39530', '10080', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('14', '2010-03-02', '5901697572', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('18', '2010-03-02', '6510071000', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('19', '2010-03-02', '4309080810', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('20', '2010-03-02', '5908042150', '2010-03-02', '3733', '952', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('21', '2010-03-02', '4202091930', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('24', '2010-02-02', '5910060290', '2010-03-02', '2304', '588', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('25', '2010-03-02', '6911042060', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('26', '2010-03-02', '5401740409', '2010-03-02', '51466', '13124', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('27', '2010-03-02', '5001024110', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('30', '2010-03-02', '5008891019', '2010-03-02', '8200', '2091', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('33', '2010-03-02', '5503850749', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('34', '2010-02-02', '4206090940', '2010-03-02', '3785', '965', 'Margeir Reynisson', '');
INSERT INTO `samningar` VALUES ('35', '2010-03-02', '1308713809', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('36', '2010-03-02', '5908942819', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('39', '2010-03-02', '7006720939', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('40', '2010-03-02', '4401696869', '2010-03-02', '3205', '817', 'Margeir Reynisson', null);
INSERT INTO `samningar` VALUES ('42', '2010-03-02', '6802962359', '2010-03-02', '6410', '1635', 'Margeir Reynisson', '');
INSERT INTO `samningar` VALUES ('45', '2010-03-02', '6406080130', '2010-03-02', '4804', '1225', 'Margeir Reynisson', null);

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
