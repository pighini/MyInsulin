-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mar 05 Juin 2018 à 16:33
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.5.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `myinsulin`
--
CREATE DATABASE IF NOT EXISTS `myinsulin` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `myinsulin`;

-- --------------------------------------------------------

--
-- Structure de la table `insulintables`
--

CREATE TABLE IF NOT EXISTS `insulintables` (
  `idInsulinTable` int(11) NOT NULL AUTO_INCREMENT,
  `minGlucose` int(11) NOT NULL,
  `maxGlucose` int(11) NOT NULL,
  `timeSpec` datetime NOT NULL,
  `Recommandation` float NOT NULL,
  `idUser` int(11) NOT NULL,
  PRIMARY KEY (`idInsulinTable`),
  KEY `idUser` (`idUser`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `measures`
--

CREATE TABLE IF NOT EXISTS `measures` (
  `idMeasure` int(11) NOT NULL AUTO_INCREMENT,
  `glucose` double NOT NULL,
  `insulinRecommandation` double NOT NULL,
  `commentary` varchar(200) DEFAULT NULL,
  `dateofMeasure` datetime NOT NULL,
  `typeofMeasure` varchar(10) NOT NULL,
  `idUser` int(11) NOT NULL,
  PRIMARY KEY (`idMeasure`),
  KEY `idUser` (`idUser`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=73 ;

--
-- Contenu de la table `measures`
--

INSERT INTO `measures` (`idMeasure`, `glucose`, `insulinRecommandation`, `commentary`, `dateofMeasure`, `typeofMeasure`, `idUser`) VALUES
(69, 12, 1, 'fdpppp', '2018-05-14 00:00:00', 'matin', 1),
(70, 12, 0, '', '2018-05-15 00:00:00', 'matin', 1),
(71, 12, 0, 'asdf', '2018-05-17 00:00:00', 'matin', 1),
(72, 12, 0, 'asd', '2018-05-18 00:00:00', 'matin', 1);

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

CREATE TABLE IF NOT EXISTS `type` (
  `idType` int(11) NOT NULL AUTO_INCREMENT,
  `type` int(11) NOT NULL,
  PRIMARY KEY (`idType`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `idUser` int(11) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(30) NOT NULL,
  `lastName` varchar(30) NOT NULL,
  `email` varchar(40) NOT NULL,
  `password` char(40) NOT NULL,
  PRIMARY KEY (`idUser`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=5 ;

--
-- Contenu de la table `users`
--

INSERT INTO `users` (`idUser`, `firstName`, `lastName`, `email`, `password`) VALUES
(1, 'a', 'a', 'a', '86F7E437FAA5A7FCE15D1DDCB9EAEAEA377667B8'),
(2, '0', '0', '0', '0'),
(3, 't', 't', 't', '8EFD86FB78A56A5145ED7739DCB00C78581C5375'),
(4, '', '', '', 'DA39A3EE5E6B4B0D3255BFEF95601890AFD80709');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `insulintables`
--
ALTER TABLE `insulintables`
  ADD CONSTRAINT `insulintables_ibfk_1` FOREIGN KEY (`idUser`) REFERENCES `users` (`idUser`);

--
-- Contraintes pour la table `measures`
--
ALTER TABLE `measures`
  ADD CONSTRAINT `measures_ibfk_1` FOREIGN KEY (`idUser`) REFERENCES `users` (`idUser`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
