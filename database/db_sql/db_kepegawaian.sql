-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 20, 2021 at 03:38 PM
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
-- Database: `db_kepegawaian`
--

-- --------------------------------------------------------

--
-- Table structure for table `absensi`
--

CREATE TABLE `absensi` (
  `id_absen` int(11) NOT NULL,
  `NIK` int(10) NOT NULL,
  `keterangan` varchar(20) NOT NULL,
  `tanggal` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `absensi`
--

INSERT INTO `absensi` (`id_absen`, `NIK`, `keterangan`, `tanggal`) VALUES
(3, 19201, 'Hadir', '08:25:33 17/07/2021 '),
(4, 19203, 'Hadir', '03:20:09 20/07/2021 '),
(5, 19204, 'Hadir', '03:20:22 20/07/2021 '),
(7, 19203, 'Hadir', '03:27:09 20/07/2021 '),
(8, 19204, 'Hadir', '03:27:19 20/07/2021 ');

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id_admin` int(10) NOT NULL,
  `username` varchar(40) NOT NULL,
  `password` varchar(40) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `created_at` varchar(50) NOT NULL,
  `update_at` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id_admin`, `username`, `password`, `nama`, `created_at`, `update_at`) VALUES
(1231, 'admin', 'admin', 'admin', '', ''),
(1236, 'bagusmadeartan90', 'made0001', 'Bagus Made Arta Nugrahaa', '02:59:13 20/07/2021 ', ''),
(1237, 'suardika012', 'suar002', 'made suardika', '02:59:50 20/07/2021 ', '03:00:25 20/07/2021 ');

-- --------------------------------------------------------

--
-- Table structure for table `izin`
--

CREATE TABLE `izin` (
  `id_izin` int(10) NOT NULL,
  `NIK` int(10) NOT NULL,
  `keterangan` text NOT NULL,
  `izin_tanggal` date NOT NULL,
  `sampai_tanggal` date NOT NULL,
  `created_at` varchar(50) NOT NULL,
  `update_at` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `izin`
--

INSERT INTO `izin` (`id_izin`, `NIK`, `keterangan`, `izin_tanggal`, `sampai_tanggal`, `created_at`, `update_at`) VALUES
(4, 19201, 'sakit tipes', '2021-07-18', '2021-07-21', '02:55:03 18/07/2021 ', '03:20:57 20/07/2021 '),
(6, 19203, 'izin menghadiri undangan pernikahan teman', '2021-07-21', '2021-07-22', '03:21:35 20/07/2021 ', ''),
(7, 19204, 'izin faksinasi tahap ke 2', '2021-07-27', '2021-07-22', '03:22:24 20/07/2021 ', ''),
(9, 19203, 'izin liburan ke manado', '2021-07-25', '2021-08-07', '03:28:26 20/07/2021 ', '');

-- --------------------------------------------------------

--
-- Table structure for table `jabatan`
--

CREATE TABLE `jabatan` (
  `id_jabatan` int(10) NOT NULL,
  `jabatan` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `jabatan`
--

INSERT INTO `jabatan` (`id_jabatan`, `jabatan`) VALUES
(331, 'Pemasaran'),
(332, 'Gudang'),
(333, 'Kurir');

-- --------------------------------------------------------

--
-- Table structure for table `karyawan`
--

CREATE TABLE `karyawan` (
  `NIK` int(10) NOT NULL,
  `nama_karyawan` varchar(60) NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `agama` varchar(10) NOT NULL,
  `jenis_kelamin` varchar(15) NOT NULL,
  `alamat` text NOT NULL,
  `telepon` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `kd_jabatan` int(10) NOT NULL,
  `created_at` varchar(50) NOT NULL,
  `update_at` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `karyawan`
--

INSERT INTO `karyawan` (`NIK`, `nama_karyawan`, `tanggal_lahir`, `agama`, `jenis_kelamin`, `alamat`, `telepon`, `email`, `kd_jabatan`, `created_at`, `update_at`) VALUES
(19201, 'bagus made arta nugraha', '2021-07-07', 'Hindu', 'LakiLaki', 'jalan wibisana utara gang apel manis', '081335683921', 'bagusmadearta01@gmail.com', 331, '07:34:31 16/07/2021 ', '01:36:53 20/07/2021 '),
(19203, 'dio brando', '2001-06-29', 'Kristen', 'LakiLaki', 'Jalan orarola za warudo no 45', '02456739375', 'konodioda@gmail.com', 332, '03:01:48 20/07/2021 ', ''),
(19204, 'risma salsabilah ', '2000-07-06', 'Islam', 'Perempuan', 'jalan solahinam gang pojok no 3', '089356784923', 'salsabilah_risma@gmail.com', 331, '03:04:45 20/07/2021 ', '');

-- --------------------------------------------------------

--
-- Table structure for table `pendidikan`
--

CREATE TABLE `pendidikan` (
  `id_pendidikan` int(10) NOT NULL,
  `NIK` int(10) NOT NULL,
  `pendidikan` varchar(30) NOT NULL,
  `jurusan` varchar(30) NOT NULL,
  `created_at` varchar(50) NOT NULL,
  `update_at` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pendidikan`
--

INSERT INTO `pendidikan` (`id_pendidikan`, `NIK`, `pendidikan`, `jurusan`, `created_at`, `update_at`) VALUES
(2, 19203, 'sarjana perhotelan', 'perhotelan', '03:09:50 20/07/2021 ', ''),
(3, 19204, 'sarjana pariwisata', 'administrasi ', '03:10:28 20/07/2021 ', ''),
(4, 19201, 'diploma 3 TI ', 'manajemen informatika', '03:15:47 20/07/2021 ', '03:16:18 20/07/2021 ');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `absensi`
--
ALTER TABLE `absensi`
  ADD PRIMARY KEY (`id_absen`),
  ADD KEY `fo_NIK` (`NIK`);

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indexes for table `izin`
--
ALTER TABLE `izin`
  ADD PRIMARY KEY (`id_izin`),
  ADD KEY `f_NIK` (`NIK`);

--
-- Indexes for table `jabatan`
--
ALTER TABLE `jabatan`
  ADD PRIMARY KEY (`id_jabatan`);

--
-- Indexes for table `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`NIK`),
  ADD KEY `fkd_jabatan` (`kd_jabatan`);

--
-- Indexes for table `pendidikan`
--
ALTER TABLE `pendidikan`
  ADD PRIMARY KEY (`id_pendidikan`),
  ADD KEY `for_NIK` (`NIK`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `absensi`
--
ALTER TABLE `absensi`
  MODIFY `id_absen` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id_admin` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1239;

--
-- AUTO_INCREMENT for table `izin`
--
ALTER TABLE `izin`
  MODIFY `id_izin` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `jabatan`
--
ALTER TABLE `jabatan`
  MODIFY `id_jabatan` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=334;

--
-- AUTO_INCREMENT for table `karyawan`
--
ALTER TABLE `karyawan`
  MODIFY `NIK` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19206;

--
-- AUTO_INCREMENT for table `pendidikan`
--
ALTER TABLE `pendidikan`
  MODIFY `id_pendidikan` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `absensi`
--
ALTER TABLE `absensi`
  ADD CONSTRAINT `fo_NIK` FOREIGN KEY (`NIK`) REFERENCES `karyawan` (`NIK`);

--
-- Constraints for table `izin`
--
ALTER TABLE `izin`
  ADD CONSTRAINT `f_NIK` FOREIGN KEY (`NIK`) REFERENCES `karyawan` (`NIK`);

--
-- Constraints for table `karyawan`
--
ALTER TABLE `karyawan`
  ADD CONSTRAINT `fkd_jabatan` FOREIGN KEY (`kd_jabatan`) REFERENCES `jabatan` (`id_jabatan`);

--
-- Constraints for table `pendidikan`
--
ALTER TABLE `pendidikan`
  ADD CONSTRAINT `for_NIK` FOREIGN KEY (`NIK`) REFERENCES `karyawan` (`NIK`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
