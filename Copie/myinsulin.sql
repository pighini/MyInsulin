-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mer 06 Juin 2018 à 16:45
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
  `idMeasure` int(11) NOT NULL,
  KEY `idUser` (`idType`),
  KEY `idType` (`idType`),
  KEY `idMeasure` (`idMeasure`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `hastypes`
--

INSERT INTO `hastypes` (`idType`, `idMeasure`) VALUES
(1, 69),
(3, 70),
(5, 71);

-- --------------------------------------------------------

--
-- Structure de la table `insulintables`
--

CREATE TABLE IF NOT EXISTS `insulintables` (
  `idInsulinTable` int(11) NOT NULL AUTO_INCREMENT,
  `minGlucose` double NOT NULL,
  `maxGlucose` double NOT NULL,
  `timeSpec` datetime NOT NULL,
  `Recommandation` double NOT NULL,
  `idUser` int(11) NOT NULL,
  PRIMARY KEY (`idInsulinTable`),
  KEY `idUser` (`idUser`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `insulintables`
--

INSERT INTO `insulintables` (`idInsulinTable`, `minGlucose`, `maxGlucose`, `timeSpec`, `Recommandation`, `idUser`) VALUES
(1, 4, 8, '2018-06-06 00:00:00', 6, 1),
(2, 8, 12, '2018-06-06 00:00:00', 8, 1),
(3, 12, 16, '2018-06-06 00:00:00', 10, 1);

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
  PRIMARY KEY (`idMeasure`),
  KEY `idUser` (`idUser`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=75 ;

--
-- Contenu de la table `measures`
--

INSERT INTO `measures` (`idMeasure`, `glucose`, `insulinRecommandation`, `commentary`, `dateofMeasure`, `idUser`) VALUES
(69, 12, 1, 'fdpppp', '2018-05-14 00:00:00', 1),
(70, 12, 0, '', '2018-05-15 00:00:00', 1),
(71, 12, 0, 'asdf', '2018-05-17 00:00:00', 1),
(72, 8, 8, 'asddddddfdppp', '2018-05-18 00:00:00', 1),
(73, 7, 6, 'asdddddd', '2018-05-30 00:00:00', 1),
(74, 10, 8, 'asd', '2018-06-06 00:00:00', 1);

-- --------------------------------------------------------

--
-- Structure de la table `types`
--

CREATE TABLE IF NOT EXISTS `types` (
  `idType` int(11) NOT NULL AUTO_INCREMENT,
  `type` varchar(20) NOT NULL,
  PRIMARY KEY (`idType`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=7 ;

--
-- Contenu de la table `types`
--

INSERT INTO `types` (`idType`, `type`) VALUES
(1, 'Matin'),
(2, 'Matin1'),
(3, 'Midi'),
(4, 'Midi1'),
(5, 'Soir'),
(6, 'Soir1');

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8mb4 AUTO_INCREMENT=6 ;

--
-- Contenu de la table `users`
--

INSERT INTO `users` (`idUser`, `firstName`, `lastName`, `email`, `password`) VALUES
(1, 'a', 'a', 'a', '86F7E437FAA5A7FCE15D1DDCB9EAEAEA377667B8'),
(2, '0', '0', '0', '0'),
(3, 't', 't', 't', '8EFD86FB78A56A5145ED7739DCB00C78581C5375'),
(4, '', '', '', 'DA39A3EE5E6B4B0D3255BFEF95601890AFD80709'),
(5, 't', 't', 'f', '8EFD86FB78A56A5145ED7739DCB00C78581C5375');

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `hastypes`
--
ALTER TABLE `hastypes`
  ADD CONSTRAINT `hastypes_ibfk_2` FOREIGN KEY (`idType`) REFERENCES `types` (`idType`),
  ADD CONSTRAINT `hastypes_ibfk_3` FOREIGN KEY (`idMeasure`) REFERENCES `measures` (`idMeasure`);

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
