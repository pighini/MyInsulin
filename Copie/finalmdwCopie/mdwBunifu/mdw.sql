-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mer 09 Mai 2018 à 11:35
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.5.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `mdw`
--
CREATE DATABASE IF NOT EXISTS `mdw` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `mdw`;

-- --------------------------------------------------------

--
-- Structure de la table `mesures`
--

CREATE TABLE IF NOT EXISTS `mesures` (
  `idMesure` int(11) NOT NULL AUTO_INCREMENT,
  `poids` int(11) NOT NULL,
  `taille` int(11) NOT NULL,
  `type` varchar(10) NOT NULL,
  `dateMesure` datetime NOT NULL,
  `idUser` int(11) NOT NULL,
  PRIMARY KEY (`idMesure`),
  KEY `idUser` (`idUser`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=59 ;

--
-- Contenu de la table `mesures`
--

INSERT INTO `mesures` (`idMesure`, `poids`, `taille`, `type`, `dateMesure`, `idUser`) VALUES
(3, 84, 175, 'midi', '2018-05-05 00:00:00', 4),
(4, 90, 186, 'midi', '2018-05-04 00:00:00', 4),
(7, 85, 186, 'midi', '2018-05-01 00:00:00', 4),
(8, 76, 183, 'midi', '2018-04-30 00:00:00', 4),
(9, 88, 178, 'midi', '2018-05-03 00:00:00', 4),
(11, 78, 181, 'midi', '2018-01-23 17:42:54', 4),
(12, 76, 173, 'midi', '2017-12-12 04:07:53', 4),
(13, 77, 185, 'midi', '2018-02-25 10:23:54', 4),
(14, 82, 187, 'midi', '2017-11-24 05:14:56', 4),
(15, 71, 186, 'midi', '2018-04-22 14:36:45', 4),
(16, 86, 188, 'midi', '2018-03-19 00:05:57', 4),
(17, 86, 170, 'midi', '2018-04-29 02:45:34', 4),
(18, 75, 189, 'midi', '2018-03-01 12:07:24', 4),
(19, 70, 172, 'midi', '2018-01-26 21:36:36', 4),
(20, 79, 171, 'midi', '2017-11-28 07:58:26', 4),
(21, 82, 182, 'midi', '2018-02-02 18:52:36', 4),
(22, 84, 171, 'midi', '2018-01-26 19:48:22', 4),
(23, 84, 173, 'midi', '2018-03-08 21:28:59', 4),
(24, 80, 175, 'midi', '2018-02-02 07:57:11', 4),
(25, 88, 175, 'midi', '2017-12-05 16:19:01', 4),
(26, 77, 185, 'midi', '2017-11-11 15:42:33', 4),
(27, 81, 186, 'midi', '2018-03-07 10:33:35', 4),
(28, 70, 186, 'midi', '2018-01-07 20:55:25', 4),
(29, 70, 187, 'midi', '2018-02-17 22:36:02', 4),
(30, 70, 189, 'midi', '2018-03-30 00:16:39', 4),
(31, 75, 189, 'midi', '2017-11-16 17:27:04', 4),
(32, 79, 172, 'midi', '2018-04-21 14:58:42', 4),
(33, 74, 174, 'midi', '2018-03-18 00:27:55', 4),
(34, 83, 174, 'midi', '2018-01-18 09:49:44', 4),
(35, 79, 176, 'midi', '2017-12-15 19:18:56', 4),
(36, 88, 175, 'midi', '2017-10-17 04:40:46', 4),
(37, 88, 177, 'midi', '2017-11-27 07:20:23', 4),
(38, 88, 179, 'midi', '2018-01-06 09:00:00', 4),
(39, 72, 178, 'midi', '2018-03-22 02:11:25', 4),
(41, 72, 182, 'midi', '2017-11-15 06:32:39', 4),
(42, 72, 184, 'midi', '2017-12-26 08:12:16', 4),
(43, 76, 183, 'midi', '2018-03-11 01:23:41', 4),
(44, 85, 185, 'midi', '2018-02-21 13:25:08', 4),
(45, 81, 187, 'midi', '2018-01-17 22:54:20', 4),
(46, 81, 189, 'midi', '2018-02-27 01:34:57', 4),
(47, 89, 170, 'midi', '2018-02-09 12:36:24', 4),
(48, 89, 171, 'midi', '2018-03-22 15:17:01', 4),
(49, 74, 171, 'midi', '2017-11-08 07:28:26', 4),
(50, 74, 173, 'midi', '2017-12-18 10:08:03', 4),
(51, 86, 172, 'midi', '2018-04-16 00:00:00', 4),
(52, 82, 172, 'midi', '2018-04-11 00:00:00', 4),
(53, 82, 172, 'midi', '2018-04-08 00:00:00', 4),
(54, 88, 172, 'midi', '2018-04-07 00:00:00', 4),
(57, 58, 165, 'soir', '2018-05-02 00:00:00', 4),
(58, 85, 162, 'midi', '2018-05-06 00:00:00', 4);

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `idUser` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` char(40) NOT NULL,
  PRIMARY KEY (`idUser`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Contenu de la table `users`
--

INSERT INTO `users` (`idUser`, `username`, `password`) VALUES
(1, 'f', '4A0A19218E082A343A1B17E5333409AF9D98F0F5'),
(2, 'g', '54FD1711209FB1C0781092374132C66E79E2241B'),
(3, 's', 'A0F1490A20D0211C997B44BC357E1972DEAB8AE3'),
(4, 'a', '86F7E437FAA5A7FCE15D1DDCB9EAEAEA377667B8'),
(5, 'h', '27D5482EEBD075DE44389774FCE28C69F45C8A75'),
(6, 'Crisz', 'F6889FC97E14B42DEC11A8C183EA791C5465B658');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `mesures`
--
ALTER TABLE `mesures`
  ADD CONSTRAINT `mesures_ibfk_1` FOREIGN KEY (`idUser`) REFERENCES `users` (`idUser`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
