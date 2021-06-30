-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 30, 2021 at 01:38 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `restaurant`
--

-- --------------------------------------------------------

--
-- Table structure for table `chef`
--

CREATE TABLE `chef` (
  `idchef` int(11) NOT NULL,
  `namechef` varchar(255) NOT NULL,
  `position` varchar(255) NOT NULL,
  `phoneNum` int(30) NOT NULL,
  `gender` varchar(255) NOT NULL,
  `dateInCharge` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `chef`
--

INSERT INTO `chef` (`idchef`, `namechef`, `position`, `phoneNum`, `gender`, `dateInCharge`) VALUES
(1, 'KUKANESWARI', 'MSBA', 1111148355, 'Female', '23.03.20016'),
(2, 'PHAKORN', 'CHEF', 174188399, 'MALE', ' 22 8 2019'),
(3, 'PHAKORN', '', 0, '', ''),
(4, 'KARN', 'CHEF', 105166329, 'MALE', '22 5 2017'),
(5, '', '', 0, '', '');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `idcustomer` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `age` int(30) NOT NULL,
  `address` varchar(255) NOT NULL,
  `phoneNum` int(30) NOT NULL,
  `gender` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`idcustomer`, `name`, `age`, `address`, `phoneNum`, `gender`) VALUES
(1, 'KUKANESWARI', 20, '83 TAMAN PERTAMA', 1111148355, 'Female'),
(2, 'Zamir', 20, '56 taman mogani', 12, 'male');

-- --------------------------------------------------------

--
-- Table structure for table `food`
--

CREATE TABLE `food` (
  `idfood` int(11) NOT NULL,
  `itemCode` varchar(255) NOT NULL,
  `nameFood` varchar(255) NOT NULL,
  `quantity` varchar(255) NOT NULL,
  `type` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `food`
--

INSERT INTO `food` (`idfood`, `itemCode`, `nameFood`, `quantity`, `type`) VALUES
(1, '567', 'Nasi goreng', '5', 'rice'),
(2, '543', 'Nasi Goreng', '2', 'rice');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `idstaff` int(11) NOT NULL,
  `nameStaff` varchar(255) NOT NULL,
  `position` varchar(255) NOT NULL,
  `phoneNum` int(30) NOT NULL,
  `gender` varchar(255) NOT NULL,
  `dateInCharge` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`idstaff`, `nameStaff`, `position`, `phoneNum`, `gender`, `dateInCharge`) VALUES
(1, 'KUKANESWARI', 'UYEDJH', 1111148355, 'Female', '23.03.2020'),
(2, 'PHAKORN', 'STAFF', 174188399, 'MALE', '6 9 2014');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `chef`
--
ALTER TABLE `chef`
  ADD PRIMARY KEY (`idchef`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`idcustomer`);

--
-- Indexes for table `food`
--
ALTER TABLE `food`
  ADD PRIMARY KEY (`idfood`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`idstaff`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `chef`
--
ALTER TABLE `chef`
  MODIFY `idchef` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `idcustomer` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `food`
--
ALTER TABLE `food`
  MODIFY `idfood` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `idstaff` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
