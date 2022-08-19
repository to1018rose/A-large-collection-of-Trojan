-- phpMyAdmin SQL Dump
-- version 4.1.8
-- http://www.phpmyadmin.net
--
-- Hoszt: localhost
-- Létrehozás ideje: 2014. Sze 17. 14:39
-- Szerver verzió: 5.5.37-cll
-- PHP verzió: 5.4.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Adatbázis: `gsquuz_kazybot`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kazybot`
--

CREATE TABLE IF NOT EXISTS `kazybot` (
  `HWID` varchar(255) NOT NULL,
  `IP` varchar(255) NOT NULL,
  `ID` varchar(255) NOT NULL,
  `USER` varchar(255) NOT NULL,
  `OS` varchar(255) NOT NULL,
  `PROCESSOR` varchar(255) NOT NULL,
  `MEMORY` varchar(255) NOT NULL,
  `RIGHTS` varchar(255) NOT NULL,
  `VERSION` varchar(255) NOT NULL,
  `LAST` datetime NOT NULL,
  PRIMARY KEY (`HWID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
