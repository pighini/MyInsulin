-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Lun 11 Juin 2018 à 16:44
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

-- --------------------------------------------------------

--
-- Structure de la table `hastypes`
--

CREATE TABLE IF NOT EXISTS `hastypes` (
  `idType` int(11) NOT NULL,
  `idUser` int(11) NOT NULL,
  KEY `idUser` (`idType`),
  KEY `idType` (`idType`),
  KEY `idMeasure` (`idUser`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `hastypes`
--

INSERT INTO `hastypes` (`idType`, `idUser`) VALUES
(1, 1),
(2, 1),
(3, 1),
(12, 1),
(13, 1);

-- --------------------------------------------------------

--
-- Structure de la table `insulintables`
--

CREATE TABLE IF NOT EXISTS `insulintables` (
  `idInsulinTable` int(11) NOT NULL AUTO_INCREMENT,
  `minGlucose` double NOT NULL,
  `maxGlucose` double NOT NULL,
  `timeSpec` datetime NOT NULL,
  `recommandation` double NOT NULL,
  `idUser` int(11) NOT NULL,
  PRIMARY KEY (`idInsulinTable`),
  KEY `idUser` (`idUser`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=12 ;

--
-- Contenu de la table `insulintables`
--

INSERT INTO `insulintables` (`idInsulinTable`, `minGlucose`, `maxGlucose`, `timeSpec`, `recommandation`, `idUser`) VALUES
(10, 4, 6, '2018-06-08 00:00:00', 2, 1),
(11, 6, 8, '2018-06-11 00:00:00', 4, 1);

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
  `idUser` int(11) NOT NULL,
  `idType` int(11) NOT NULL,
  PRIMARY KEY (`idMeasure`),
  KEY `idUser` (`idUser`),
  KEY `idType` (`idType`),
  KEY `idType_2` (`idType`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=27 ;

--
-- Contenu de la table `measures`
--

INSERT INTO `measures` (`idMeasure`, `glucose`, `insulinRecommandation`, `commentary`, `dateofMeasure`, `idUser`, `idType`) VALUES
(1, 10, 6, 'gxch', '2018-06-07 00:00:00', 1, 1),
(4, 11, 8, '<dgsdf', '2018-05-14 00:00:00', 1, 1),
(5, 8, 8, '<dgsdf', '2018-05-14 00:00:00', 1, 2),
(8, 10, 8, '<dgsdfe', '2018-05-19 00:00:00', 1, 1),
(9, 14, 10, '<dgsdfe', '2018-05-19 00:00:00', 1, 3),
(10, 7, 6, '<dgsdfe', '2018-05-22 00:00:00', 1, 1),
(11, 4, 6, '<dgsdfe', '2018-05-23 00:00:00', 1, 1),
(12, 7, 6, '<dgsdfe', '2018-05-23 00:00:00', 1, 2),
(13, 12, 10, 'asfg', '2018-06-07 00:00:00', 1, 3),
(15, 12, 10, 'asfg', '2018-06-05 00:00:00', 1, 1),
(16, 1, 10, '', '2018-06-03 00:00:00', 1, 1),
(18, 12, 0, 'sadf', '2018-05-31 00:00:00', 1, 2),
(20, 4, 7, 'sadf', '2018-06-20 00:00:00', 1, 2),
(21, 12, 0, '', '2018-06-04 00:00:00', 1, 1),
(22, 5, 7, '', '2018-06-01 00:00:00', 1, 3),
(23, 9, 9, '', '2018-06-06 00:00:00', 1, 1),
(24, 6, 7, '', '2018-05-30 00:00:00', 1, 3),
(25, 7, 7, 'asd', '2018-06-08 00:00:00', 1, 1),
(26, 4, 2, 'dysafafasdfsd', '2018-06-11 00:00:00', 1, 12);

-- --------------------------------------------------------

--
-- Structure de la table `types`
--

CREATE TABLE IF NOT EXISTS `types` (
  `idType` int(11) NOT NULL AUTO_INCREMENT,
  `type` varchar(20) NOT NULL,
  PRIMARY KEY (`idType`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=14 ;

--
-- Contenu de la table `types`
--

INSERT INTO `types` (`idType`, `type`) VALUES
(1, 'Matin'),
(2, 'Midi'),
(3, 'Soir'),
(8, 'ok'),
(11, 'swagg'),
(12, 'Matin 2'),
(13, '');

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
  `isDoctor` tinyint(1) NOT NULL DEFAULT '0',
  `idMedecin` int(11) DEFAULT NULL,
  PRIMARY KEY (`idUser`),
  KEY `idMedecin` (`idMedecin`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=10 ;

--
-- Contenu de la table `users`
--

INSERT INTO `users` (`idUser`, `firstName`, `lastName`, `email`, `password`, `isDoctor`, `idMedecin`) VALUES
(1, 'a', 'a', 'a', '86F7E437FAA5A7FCE15D1DDCB9EAEAEA377667B8', 0, 6),
(6, 'a', 'b', 'c', '86F7E437FAA5A7FCE15D1DDCB9EAEAEA377667B8', 1, 9),
(7, 'r', 'r', 'r', '86F7E437FAA5A7FCE15D1DDCB9EAEAEA377667B8', 0, 1),
(8, '', 't', 't', '8EFD86FB78A56A5145ED7739DCB00C78581C5375', 1, NULL),
(9, 'f', 'f', 'f', '4A0A19218E082A343A1B17E5333409AF9D98F0F5', 1, 1);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `hastypes`
--
ALTER TABLE `hastypes`
  ADD CONSTRAINT `hastypes_ibfk_3` FOREIGN KEY (`idUser`) REFERENCES `users` (`idUser`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `hastypes_ibfk_4` FOREIGN KEY (`idType`) REFERENCES `types` (`idType`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `insulintables`
--
ALTER TABLE `insulintables`
  ADD CONSTRAINT `insulintables_ibfk_1` FOREIGN KEY (`idUser`) REFERENCES `users` (`idUser`);

--
-- Contraintes pour la table `measures`
--
ALTER TABLE `measures`
  ADD CONSTRAINT `measures_ibfk_2` FOREIGN KEY (`idType`) REFERENCES `types` (`idType`),
  ADD CONSTRAINT `measures_ibfk_1` FOREIGN KEY (`idUser`) REFERENCES `users` (`idUser`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
