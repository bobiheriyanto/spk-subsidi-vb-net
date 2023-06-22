-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Sep 03, 2021 at 07:19 PM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `subsidi`
--

-- --------------------------------------------------------

--
-- Table structure for table `table_admin`
--

CREATE TABLE IF NOT EXISTS `table_admin` (
  `user_name` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL,
  `pengguna` varchar(25) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `table_admin`
--

INSERT INTO `table_admin` (`user_name`, `password`, `pengguna`) VALUES
('Admin', 'Admin', 'Admin'),
('Pengawas', 'Pengawas', 'Pengawas'),
('Pimpinan', 'Pimpinan', 'Pimpinan');

-- --------------------------------------------------------

--
-- Table structure for table `table_kriteria`
--

CREATE TABLE IF NOT EXISTS `table_kriteria` (
  `kode_kriteria` varchar(5) NOT NULL,
  `nm_kriteria` varchar(25) NOT NULL,
  `status` varchar(25) NOT NULL,
  `bobot` decimal(4,2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `table_kriteria`
--

INSERT INTO `table_kriteria` (`kode_kriteria`, `nm_kriteria`, `status`, `bobot`) VALUES
('006', 'Luas Bangunan', 'Benefit', '0.15'),
('005', 'Kepemilikan Rumah', 'Benefit', '0.15'),
('004', 'Aset Kendaraan', 'Benefit', '0.13'),
('003', 'Tanggungan', 'Benefit', '0.15'),
('002', 'Penghasilan', 'Benefit', '0.15'),
('001', 'Pekerjaan', 'Benefit', '0.14'),
('007', 'Sumber Air Minum', 'Benefit', '0.13');

-- --------------------------------------------------------

--
-- Table structure for table `table_nilai_penerima`
--

CREATE TABLE IF NOT EXISTS `table_nilai_penerima` (
  `id` varchar(25) NOT NULL,
  `nm` varchar(25) NOT NULL,
  `nilai1` decimal(4,2) NOT NULL,
  `nilai2` decimal(4,2) NOT NULL,
  `nilai3` decimal(4,2) NOT NULL,
  `nilai4` decimal(4,2) NOT NULL,
  `nilai5` decimal(4,2) NOT NULL,
  `nilai6` decimal(4,2) NOT NULL,
  `nilai7` decimal(4,2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `table_nilai_penerima`
--

INSERT INTO `table_nilai_penerima` (`id`, `nm`, `nilai1`, `nilai2`, `nilai3`, `nilai4`, `nilai5`, `nilai6`, `nilai7`) VALUES
('12046', 'Pahlepi Alexander', '0.25', '0.75', '0.50', '0.80', '0.75', '0.50', '0.50'),
('12028', 'Romi Ramadan', '0.50', '0.75', '0.75', '0.80', '1.00', '0.50', '1.00'),
('11245', 'Purwandi', '0.25', '0.75', '0.25', '0.80', '1.00', '0.75', '0.50'),
('11243', 'Jumidal Rahman', '0.50', '0.75', '0.50', '0.80', '1.00', '0.75', '1.00'),
('13001', 'Doni Andika', '0.50', '0.75', '1.00', '0.80', '1.00', '0.75', '1.00'),
('11302', 'Yolly Sofyan', '0.25', '0.75', '0.25', '0.80', '1.00', '0.75', '1.00'),
('12002', 'Nofri Yuki Putra', '0.50', '0.75', '0.75', '0.80', '1.00', '0.50', '1.00'),
('12003', 'Hardiyanto', '0.25', '0.75', '0.75', '0.80', '1.00', '0.75', '1.00'),
('11244', 'Ogi Distya', '0.50', '0.75', '0.25', '0.80', '1.00', '0.75', '1.00'),
('11254', 'Masrikin', '0.25', '0.75', '0.50', '0.80', '1.00', '0.75', '1.00'),
('11229', 'Benni Putra', '0.75', '0.50', '1.00', '0.80', '1.00', '0.75', '1.00'),
('11236', 'Fabius Februari', '0.50', '0.75', '0.75', '0.80', '1.00', '0.50', '1.00'),
('11259', 'Warianto', '0.25', '0.75', '0.75', '0.80', '1.00', '0.50', '1.00'),
('11262', 'Maskari', '0.50', '0.75', '0.50', '0.80', '1.00', '0.75', '1.00'),
('11297', 'Egi Setiawan', '0.75', '0.50', '0.25', '0.80', '1.00', '0.75', '1.00'),
('11299', 'Yulisman', '1.00', '0.25', '1.00', '1.00', '1.00', '0.75', '1.00'),
('11301', 'Ucok Jamitra', '0.75', '0.50', '0.75', '0.80', '1.00', '0.75', '1.00'),
('12045', 'Fahrul Rozi', '0.75', '0.50', '0.50', '0.80', '1.00', '0.50', '1.00'),
('12048', 'Anasrul', '0.50', '0.75', '0.75', '0.80', '1.00', '0.50', '1.00'),
('12055', 'Eko Mardoni', '0.25', '0.75', '0.50', '0.80', '1.00', '0.50', '1.00');

-- --------------------------------------------------------

--
-- Table structure for table `table_penerima`
--

CREATE TABLE IF NOT EXISTS `table_penerima` (
  `id` varchar(25) NOT NULL,
  `nm` varchar(25) NOT NULL,
  `tempat` varchar(25) NOT NULL,
  `tgl` date NOT NULL,
  `jk` varchar(25) NOT NULL,
  `almt` varchar(25) NOT NULL,
  `agm` varchar(25) NOT NULL,
  `pdd` varchar(35) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `table_penerima`
--

INSERT INTO `table_penerima` (`id`, `nm`, `tempat`, `tgl`, `jk`, `almt`, `agm`, `pdd`) VALUES
('11244', 'Ogi Distya', 'Kayu Tanam', '1990-06-15', 'LAKI - LAKI', 'Padang pariaman', 'ISLAM	', 'SMU'),
('11254', 'Masrikin', 'Brebes', '1984-05-07', 'LAKI - LAKI', 'Padang', 'ISLAM	', 'SMU'),
('12003', 'Hardiyanto', 'Inderapura', '1983-06-16', 'LAKI - LAKI', 'Pesisir selatan', 'ISLAM	', 'SMU'),
('12002', 'Nofri Yuki Putra', 'Selayo', '1985-06-26', 'LAKI - LAKI', 'Kubung kab. Solok', 'ISLAM	', 'SMP'),
('12028', 'Romi Ramadan', 'Koto Baru', '1988-07-04', 'LAKI - LAKI', 'Padang pariaman', 'ISLAM	', 'SMP'),
('12046', 'Pahlepi Alexander', 'Lampung', '1989-08-24', 'LAKI - LAKI', 'Solok', 'ISLAM	', 'SMP'),
('11302', 'Yolly Sofyan', 'Padang', '1980-09-14', 'LAKI - LAKI', 'Padang', 'ISLAM	', 'D3'),
('13001', 'Doni Andika', 'Jambi', '1994-07-30', 'LAKI - LAKI', 'Sirih sikapur', 'ISLAM	', 'SMU'),
('11245', 'Purwandi', 'Jambi', '1985-11-10', 'LAKI - LAKI', 'Padang', 'ISLAM	', 'SMP'),
('11243', 'Jumidal Rahman', 'Padang', '1991-11-15', 'LAKI - LAKI', 'Padang', 'ISLAM	', 'SMK'),
('11259', 'Warianto', 'Padang', '1958-08-11', 'LAKI - LAKI', 'Padang', 'ISLAM	', 'SD'),
('11262', 'Maskari', 'Cirebon', '1958-05-10', 'LAKI - LAKI', 'Padang', 'ISLAM	', 'SD'),
('12055', 'Eko Mardoni', 'Bangkinang', '1981-03-06', 'LAKI - LAKI', 'Ampang Kualo', 'ISLAM	', 'SMU'),
('12048', 'Anasrul', 'Selayo', '1982-04-26', 'LAKI - LAKI', 'Berok galanggang', 'ISLAM	', 'SMU'),
('11236', 'Fabius Februari', 'Nias', '1986-02-19', 'LAKI - LAKI', 'Padang', 'ISLAM	', 'SMU'),
('12045', 'Fahrul Rozi', 'Solok', '1988-08-27', 'LAKI - LAKI', 'Solok', 'ISLAM	', 'SMP'),
('11229', 'Benni Putra', 'Lampung', '1989-08-24', 'LAKI - LAKI', 'Padang', 'ISLAM	', 'SMU'),
('11299', 'Yulisman', 'Ampang Kuranji', '1972-06-26', 'LAKI - LAKI', 'Koto baru', 'ISLAM	', 'SMP'),
('11297', 'Egi Setiawan', 'Bandung', '1982-09-21', 'LAKI - LAKI', 'Sungai kuranji', 'ISLAM	', 'SMK'),
('11301', 'Ucok Jamitra', 'Sungai betung', '1988-12-27', 'LAKI - LAKI', 'Koto baru', 'ISLAM	', 'SMK');

-- --------------------------------------------------------

--
-- Table structure for table `table_proses_perhitungan`
--

CREATE TABLE IF NOT EXISTS `table_proses_perhitungan` (
  `id` varchar(25) NOT NULL,
  `nm` varchar(25) NOT NULL,
  `hasil` decimal(3,3) NOT NULL,
  `keterangan` varchar(25) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `table_proses_perhitungan`
--

INSERT INTO `table_proses_perhitungan` (`id`, `nm`, `hasil`, `keterangan`) VALUES
('11302', 'Yolly Sofyan', '0.682', 'Non Eligible'),
('12002', 'Nofri Yuki Putra', '0.754', 'Eligible'),
('12003', 'Hardiyanto', '0.757', 'Eligible'),
('11254', 'Masrikin', '0.719', 'Non Eligible'),
('11245', 'Purwandi', '0.617', 'Non Eligible'),
('11244', 'Ogi Distya', '0.717', 'Non Eligible'),
('11243', 'Jumidal Rahman', '0.754', 'Eligible'),
('12028', 'Romi Ramadan', '0.754', 'Eligible'),
('12046', 'Pahlepi Alexander', '0.579', 'Non Eligible'),
('13001', 'Doni Andika', '0.829', 'Eligible'),
('11229', 'Benni Putra', '0.827', 'Eligible'),
('11236', 'Fabius Februari', '0.754', 'Eligible'),
('11259', 'Warianto', '0.719', 'Non Eligible'),
('11262', 'Maskari', '0.754', 'Eligible'),
('11297', 'Egi Setiawan', '0.714', 'Non Eligible'),
('11299', 'Yulisman', '0.850', 'Eligible'),
('11301', 'Ucok Jamitra', '0.789', 'Eligible'),
('12045', 'Fahrul Rozi', '0.714', 'Non Eligible'),
('12048', 'Anasrul', '0.754', 'Eligible'),
('12055', 'Eko Mardoni', '0.682', 'Non Eligible');
