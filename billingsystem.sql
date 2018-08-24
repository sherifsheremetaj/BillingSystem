-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 18, 2017 at 11:15 PM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `billingsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `depo`
--

CREATE TABLE `depo` (
  `ID` int(255) NOT NULL,
  `Barkodi` varchar(255) NOT NULL,
  `Emertimi` varchar(255) NOT NULL,
  `Kategoria` varchar(255) NOT NULL,
  `Data` varchar(255) NOT NULL,
  `Skadimi` varchar(255) NOT NULL,
  `Sasia` varchar(255) NOT NULL,
  `Cmimi` varchar(255) NOT NULL,
  `TVSH` varchar(255) NOT NULL,
  `Zbritje` varchar(255) NOT NULL,
  `Furnitori` varchar(255) NOT NULL,
  `Totali` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `depo`
--

INSERT INTO `depo` (`ID`, `Barkodi`, `Emertimi`, `Kategoria`, `Data`, `Skadimi`, `Sasia`, `Cmimi`, `TVSH`, `Zbritje`, `Furnitori`, `Totali`) VALUES
(1, '1', 'kola', 'Ushqimore', '5/18/2017', '0000-00-00', '0', '0.20', '0%', '0', 'sherif', 0.4),
(2, '2', 'fanta', 'Ushqimore', '5/18/2017', '5/19/2017', '12', '1', '0%', '0', 'sherif', 12);

-- --------------------------------------------------------

--
-- Table structure for table `firma`
--

CREATE TABLE `firma` (
  `ID` int(255) NOT NULL,
  `Emri` varchar(255) NOT NULL,
  `NrBiznesit` varchar(255) NOT NULL,
  `NrFiskal` varchar(255) NOT NULL,
  `NrTatimit` varchar(255) NOT NULL,
  `Adresa` varchar(255) NOT NULL,
  `Vendi` varchar(255) NOT NULL,
  `Telefoni` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `firma`
--

INSERT INTO `firma` (`ID`, `Emri`, `NrBiznesit`, `NrFiskal`, `NrTatimit`, `Adresa`, `Vendi`, `Telefoni`, `Email`) VALUES
(1, 'sherif', '1', '1', '1', 'sdad', '1dad', '366', 'dsdasd'),
(2, 'FIRMA', '2', '1', '1', 'sdad', '1dad', '366', 'dsdasd'),
(3, 'black', '223', '1', '1', 'sdad', '1dad', '366', 'dsdasd');

-- --------------------------------------------------------

--
-- Table structure for table `furnitoret`
--

CREATE TABLE `furnitoret` (
  `ID` int(255) NOT NULL,
  `Emri` varchar(255) NOT NULL,
  `NrBiznesit` varchar(255) NOT NULL,
  `NrFiskal` varchar(255) NOT NULL,
  `NrTatimit` varchar(255) NOT NULL,
  `Adresa` varchar(255) NOT NULL,
  `NrTelefonit` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `furnitoret`
--

INSERT INTO `furnitoret` (`ID`, `Emri`, `NrBiznesit`, `NrFiskal`, `NrTatimit`, `Adresa`, `NrTelefonit`) VALUES
(1, 'sherif', '10', '1', '1', 'kline', '049418819');

-- --------------------------------------------------------

--
-- Table structure for table `kategori`
--

CREATE TABLE `kategori` (
  `ID` int(255) NOT NULL,
  `Emri` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kategori`
--

INSERT INTO `kategori` (`ID`, `Emri`) VALUES
(1, 'Lojra'),
(2, 'Teknologji'),
(5, 'Teknikë'),
(6, 'Ushqimore'),
(7, 'Tekstil'),
(8, 'Vegla Pune'),
(9, 'Tjera'),
(10, 'Higjenike'),
(11, 'Shkollore'),
(12, 'Entertainment');

-- --------------------------------------------------------

--
-- Table structure for table `klientet`
--

CREATE TABLE `klientet` (
  `ID` int(255) NOT NULL,
  `Emri` varchar(255) NOT NULL,
  `NrBiznesit` varchar(255) NOT NULL,
  `NrFiskal` varchar(255) NOT NULL,
  `NrTatimit` varchar(255) NOT NULL,
  `Adresa` varchar(255) NOT NULL,
  `Vendi` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `klientet`
--

INSERT INTO `klientet` (`ID`, `Emri`, `NrBiznesit`, `NrFiskal`, `NrTatimit`, `Adresa`, `Vendi`) VALUES
(1, 'sherif', '1', '1', '1', 'dasd', 'asdas'),
(2, 'helo', '2', '2', '2', 'sdasd', 'sadasd');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `ID` int(255) NOT NULL,
  `Username` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`ID`, `Username`, `Password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `shitjet`
--

CREATE TABLE `shitjet` (
  `IDSH` int(255) NOT NULL,
  `ID` int(255) NOT NULL,
  `Barkodi` varchar(255) NOT NULL,
  `Emertimi` varchar(255) NOT NULL,
  `Kategoria` varchar(255) NOT NULL,
  `Sasia` double NOT NULL,
  `Cmimi` double NOT NULL,
  `TVSH` double NOT NULL,
  `Zbritje` double NOT NULL,
  `Data` varchar(255) NOT NULL,
  `Shitesi` varchar(255) NOT NULL,
  `Bleresi` varchar(255) NOT NULL,
  `Pagesa` varchar(255) NOT NULL,
  `Xhirollogaria` varchar(255) NOT NULL,
  `Dorezoi` varchar(255) NOT NULL,
  `PPC` varchar(255) NOT NULL,
  `PPKK` varchar(255) NOT NULL,
  `Totali` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `shitjet`
--

INSERT INTO `shitjet` (`IDSH`, `ID`, `Barkodi`, `Emertimi`, `Kategoria`, `Sasia`, `Cmimi`, `TVSH`, `Zbritje`, `Data`, `Shitesi`, `Bleresi`, `Pagesa`, `Xhirollogaria`, `Dorezoi`, `PPC`, `PPKK`, `Totali`) VALUES
(1, 2, '234', 'fletore', 'Tjera', 400, 0.2, 65.6, 0, '5/14/2017', 'black', 'sherif', 'Cash', '-', 'admin', 'admin', '-', 65.6),
(2, 1, '1', 'laptop', 'Teknologji', 3, 200, 492, 0, '5/14/2017', 'FIRMA', 'sherif', 'Xhirollogari', 'Procredit Bank-0000-0000-0000-0000\r\n', 'admin', '-', 'admin', 492),
(3, 2, '234', 'fletore', 'Tjera', 2000, 0.2, 328, 20, '5/15/2017', 'black', 'helo', 'Cash', '-', 'admin', 'admin', '-', 262.4),
(4, 1, '1', 'kola', 'Ushqimore', 2, 0.2, 0.328, 0.5, '5/20/2017', 'FIRMA', 'sherif', 'Xhirollogari', 'Procredit Bank-0000-0000-0000-0000\r\n', 'admin', '-', 'admin', 0.32636);

-- --------------------------------------------------------

--
-- Table structure for table `slogin`
--

CREATE TABLE `slogin` (
  `IDS` int(255) NOT NULL,
  `Username` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `slogin`
--

INSERT INTO `slogin` (`IDS`, `Username`, `Password`) VALUES
(1, 'staff', 'staff');

-- --------------------------------------------------------

--
-- Table structure for table `xhirollogari`
--

CREATE TABLE `xhirollogari` (
  `ID` int(255) NOT NULL,
  `Xhirollogaria` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `xhirollogari`
--

INSERT INTO `xhirollogari` (`ID`, `Xhirollogaria`) VALUES
(1, 'Raiffeisen Bank-0000-0000-0000-0000'),
(2, 'Procredit Bank-0000-0000-0000-0000\r\n'),
(3, 'TEB Bank-0000-0000-0000-0000\r\n');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `depo`
--
ALTER TABLE `depo`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `firma`
--
ALTER TABLE `firma`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `furnitoret`
--
ALTER TABLE `furnitoret`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `kategori`
--
ALTER TABLE `kategori`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `klientet`
--
ALTER TABLE `klientet`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `shitjet`
--
ALTER TABLE `shitjet`
  ADD PRIMARY KEY (`IDSH`);

--
-- Indexes for table `slogin`
--
ALTER TABLE `slogin`
  ADD PRIMARY KEY (`IDS`);

--
-- Indexes for table `xhirollogari`
--
ALTER TABLE `xhirollogari`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `depo`
--
ALTER TABLE `depo`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `firma`
--
ALTER TABLE `firma`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `furnitoret`
--
ALTER TABLE `furnitoret`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `kategori`
--
ALTER TABLE `kategori`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `klientet`
--
ALTER TABLE `klientet`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `shitjet`
--
ALTER TABLE `shitjet`
  MODIFY `IDSH` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `slogin`
--
ALTER TABLE `slogin`
  MODIFY `IDS` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `xhirollogari`
--
ALTER TABLE `xhirollogari`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `slogin`
--
ALTER TABLE `slogin`
  ADD CONSTRAINT `slogin_ibfk_1` FOREIGN KEY (`IDS`) REFERENCES `login` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
