-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 25, 2021 at 06:08 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_cumbil`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id_admin` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `username` varchar(18) NOT NULL,
  `password` char(18) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id_admin`, `nama`, `username`, `password`) VALUES
(1231, 'bagus made arta', 'mademegel01', 'megelsajan01'),
(1232, 'risa ryananda p', 'risabakekok31', 'risakekok13'),
(1234, 'admin', 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `kode` int(11) NOT NULL,
  `nama` varchar(60) NOT NULL,
  `notlp` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`kode`, `nama`, `notlp`) VALUES
(3134, 'mdandre', '0859435753'),
(3135, 'made bagus', '1232414'),
(3136, 'risa wanah', '05863725'),
(3137, 'surjeh', '087498586'),
(3138, 'alivevil', '09456262'),
(3140, 'risa wanaha', '05863725');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `no_struk` int(10) NOT NULL,
  `no_plat` varchar(10) NOT NULL,
  `tanggal` varchar(30) NOT NULL,
  `nama_member` varchar(50) NOT NULL,
  `tipe` varchar(15) NOT NULL,
  `tambahan` text NOT NULL,
  `harga_total` varchar(20) NOT NULL,
  `pembayaran` int(20) NOT NULL,
  `kembalian` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`no_struk`, `no_plat`, `tanggal`, `nama_member`, `tipe`, `tambahan`, `harga_total`, `pembayaran`, `kembalian`) VALUES
(1, 'DK 4463 MN', 'Friday, June 25, 2021', 'Tidak Member', 'Half Service', 'Wax, Inner and Seat', 'Rp. 190,000', 200000, 'Rp. 10,000'),
(2, 'MD 4564 ER', 'Friday, June 25, 2021', 'made bagus', 'Half Service', 'Wax, Inner and Seat', 'Rp. 171,000', 200000, 'Rp. 29,000'),
(3, 'DK 2423 MK', 'Sunday, June 27, 2021', 'Tidak Member', 'Half Service', 'Wax', 'Rp. 130,000', 600000, 'Rp. 470,000'),
(4, 'DF 4365 FK', 'Sunday, June 27, 2021', 'surjeh', 'Full Service', 'Engine', 'Rp. 162,000', 400000, 'Rp. 238,000'),
(5, 'FG 5687 DF', 'Sunday, June 27, 2021', 'risa wanah', 'Full Service', 'Wax, Engine, Inner and Seat', 'Rp. 279,000', 500000, 'Rp. 221,000'),
(6, 'DK 5643 FR', 'Sunday, June 27, 2021', 'Tidak Member', 'Half Service', 'Wax, Engine, Inner and Seat', 'Rp. 290,000', 300000, 'Rp. 10,000'),
(7, 'DF 4567 DD', 'Sunday, June 27, 2021', 'surjeh', 'Full Service', 'Wax, Engine, Inner and Seat', 'Rp. 279,000', 600000, 'Rp. 321,000'),
(8, 'DF 6666 ER', 'Sunday, June 27, 2021', 'alivevil', 'Half Service', 'Wax, Engine, Inner and Seat', 'Rp. 261,000', 500000, 'Rp. 239,000'),
(9, 'DF 6878 FG', 'Sunday, June 27, 2021', 'Tidak Member', 'Half Service', 'Wax, Engine, Inner and Seat', 'Rp. 290,000', 290000, 'Rp. '),
(10, 'DK 5476 MK', 'Sunday, June 27, 2021', 'Tidak Member', 'Full Service', 'Wax', 'Rp. 150,000', 200000, 'Rp. 50,000'),
(12, 'DK 5647 KM', 'Friday, July 2, 2021', 'Tidak Member', 'Full Service', 'Wax', 'Rp. 150,000', 200000, 'Rp. 50,000'),
(15, 'DK 5678 HG', 'Friday, July 2, 2021', 'Tidak Member', 'Half Service', 'Wax, Engine', 'Rp. 230,000', 300000, 'Rp. 70,000'),
(18, 'DK7845TR', 'Sunday, July 25, 2021', 'made bagus', 'Full Service', 'Wax, Engine', 'Rp. 225,000', 300000, 'Rp. 75,000'),
(34, 'DK6789LP', 'Sunday, July 25, 2021', 'risa wanah', 'Full Service', 'Wax, Engine', 'Rp. 225,000', 300000, 'Rp. 75,000'),
(123, '123', 'Friday, July 2, 2021', 'Tidak Member', 'Full Service', '', 'Rp. 80,000', 200000, 'Rp. 120,000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`kode`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`no_struk`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id_admin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1237;

--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `kode` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3143;

--
-- AUTO_INCREMENT for table `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `no_struk` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=124;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
