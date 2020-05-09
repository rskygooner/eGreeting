-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th5 09, 2020 lúc 09:29 AM
-- Phiên bản máy phục vụ: 10.4.10-MariaDB
-- Phiên bản PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `egreeting`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `cards`
--

CREATE TABLE `cards` (
  `CardId` int(11) NOT NULL,
  `NameCard` varchar(50) NOT NULL,
  `Category` text NOT NULL,
  `ImageName` text DEFAULT NULL,
  `DateCreated` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `cards`
--

INSERT INTO `cards` (`CardId`, `NameCard`, `Category`, `ImageName`, `DateCreated`) VALUES
(1, 'Birthday-01', 'Birthday', 'b-image1.png', '2020-05-07 16:44:39'),
(2, 'Birthday-02', 'Birthday', 'b-image2.png', '2020-05-07 16:44:39'),
(3, 'Birthday-03', 'Birthday', 'b-image3.png', '2020-05-07 16:44:39'),
(4, 'Birthday-04', 'Birthday', 'b-image4.png', '2020-05-07 16:44:39'),
(5, 'Birthday-05', 'Birthday', 'b-image5.png', '2020-05-07 16:44:39'),
(6, 'Birthday-06', 'Birthday', 'b-image6.png', '2020-05-07 16:44:39'),
(7, 'Birthday-07', 'Birthday', 'b-image7.png', '2020-05-07 16:44:39'),
(8, 'Birthday-08', 'Birthday', 'b-image8.jpg', '2020-05-07 16:44:39'),
(9, 'Birthday-09', 'Birthday', 'b-image9.png', '2020-05-07 16:44:39'),
(10, 'Birthday-10', 'Birthday', 'b-image10.png', '2020-05-07 16:44:39'),
(11, 'Birthday-11', 'Birthday', 'b-image11.png', '2020-05-07 16:44:39'),
(12, 'Birthday-12', 'Birthday', 'b-image12.png', '2020-05-07 16:44:39'),
(13, 'Birthday-13', 'Birthday', 'b-image13.png', '2020-05-07 16:44:39'),
(14, 'Birthday-14', 'Birthday', 'b-image14.png', '2020-05-07 16:44:39'),
(15, 'Birthday-15', 'Birthday', 'b-image15.png', '2020-05-07 16:44:39'),
(16, 'Birthday-16', 'Birthday', 'b-image16.png', '2020-05-07 16:44:39'),
(17, 'Birthday-17', 'Birthday', 'b-image17.png', '2020-05-07 16:44:39'),
(18, 'Birthday-18', 'Birthday', 'b-image18.png', '2020-05-07 16:44:39'),
(19, 'NewYear-02', 'NewYear', 'n-image2.jpg', '2020-05-07 16:44:39'),
(20, 'NewYear-03', 'NewYear', 'n-image3.png', '2020-05-07 16:44:39'),
(21, 'NewYear-04', 'NewYear', 'n-image4.jpg', '2020-05-07 16:44:39'),
(22, 'NewYear-05', 'NewYear', 'n-image5.jpg', '2020-05-07 16:44:39'),
(23, 'NewYear-06', 'NewYear', 'n-image6.jpg', '2020-05-07 16:44:39'),
(24, 'NewYear-07', 'NewYear', 'n-image7.png', '2020-05-07 16:44:39'),
(25, 'NewYear-08', 'NewYear', 'n-image8.png', '2020-05-07 16:44:39'),
(26, 'NewYear-09', 'NewYear', 'n-image9.png', '2020-05-07 16:44:39'),
(27, 'NewYear-10', 'NewYear', 'n-image10.png', '2020-05-07 16:44:39'),
(28, 'NewYear-11', 'NewYear', 'n-image11.jpg', '2020-05-07 16:44:39'),
(29, 'NewYear-12', 'NewYear', 'n-image12.jpg', '2020-05-07 16:44:39'),
(30, 'NewYear-13', 'NewYear', 'n-image13.jpg', '2020-05-07 16:44:39'),
(31, 'NewYear-14', 'NewYear', 'n-image14.jpg', '2020-05-07 16:44:39'),
(32, 'NewYear-15', 'NewYear', 'n-image15.jpg', '2020-05-07 16:44:39'),
(33, 'NewYear-16', 'NewYear', 'n-image16.jpg', '2020-05-07 16:44:39'),
(34, 'NewYear-17', 'NewYear', 'n-image17.jpg', '2020-05-07 16:44:39'),
(35, 'NewYear-18', 'NewYear', 'n-image18.jpg', '2020-05-07 16:44:39'),
(36, 'Festival-01', 'Festival', 'f-image1.png', '2020-05-07 16:44:39'),
(37, 'Festival-02', 'Festival', 'f-image2.jpg', '2020-05-07 16:44:39'),
(38, 'Festival-03', 'Festival', 'f-image3.jpg', '2020-05-07 16:44:39'),
(39, 'Festival-04', 'Festival', 'f-image4.jpg', '2020-05-07 16:44:39'),
(40, 'Festival-05', 'Festival', 'f-image5.jpg', '2020-05-07 16:44:39'),
(41, 'Festival-06', 'Festival', 'f-image6.jpg', '2020-05-07 16:44:39'),
(42, 'Festival-07', 'Festival', 'f-image7.jpg', '2020-05-07 16:44:39'),
(43, 'Festival-08', 'Festival', 'f-image8.png', '2020-05-07 16:44:39'),
(44, 'Festival-09', 'Festival', 'f-image9.png', '2020-05-07 16:44:39'),
(45, 'Festival-10', 'Festival', 'f-image10.png', '2020-05-07 16:44:39'),
(46, 'Festival-11', 'Festival', 'f-image11.png', '2020-05-07 16:44:39'),
(47, 'Festival-12', 'Festival', 'f-image12.png', '2020-05-07 16:44:39'),
(48, 'Festival-13', 'Festival', 'f-image13.jpg', '2020-05-07 16:44:39'),
(49, 'Festival-14', 'Festival', 'f-image14.jpg', '2020-05-07 16:44:39'),
(50, 'Festival-15', 'Festival', 'f-image15.png', '2020-05-07 16:44:39'),
(51, 'Festival-16', 'Festival', 'f-image16.jpg', '2020-05-07 16:44:39'),
(52, 'Festival-17', 'Festival', 'f-image17.png', '2020-05-07 16:44:39'),
(53, 'Festival-18', 'Festival', 'f-image18.jpg', '2020-05-07 16:44:39'),
(54, 'NewYear-01', 'NewYear', 'n-image1.png', '2020-05-07 16:44:39');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `emaillists`
--

CREATE TABLE `emaillists` (
  `EmailId` int(11) NOT NULL,
  `Username` text NOT NULL,
  `ListEmail` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `feedbacks`
--

CREATE TABLE `feedbacks` (
  `FeedbackId` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Subject` varchar(50) NOT NULL,
  `Content` varchar(1000) NOT NULL,
  `DataCreated` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `feedbacks`
--

INSERT INTO `feedbacks` (`FeedbackId`, `Username`, `Subject`, `Content`, `DataCreated`) VALUES
(1, 'test', 'test', 'Hello Handsome Guys', '2020-05-07 16:44:39');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `paymentinfos`
--

CREATE TABLE `paymentinfos` (
  `PayId` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `UserName` varchar(50) NOT NULL,
  `BankName` varchar(50) NOT NULL,
  `BankAccount` bigint(20) NOT NULL,
  `DateExpire` datetime NOT NULL,
  `DateCreated` datetime DEFAULT NULL,
  `IsActive` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `paymentinfos`
--

INSERT INTO `paymentinfos` (`PayId`, `UserId`, `UserName`, `BankName`, `BankAccount`, `DateExpire`, `DateCreated`, `IsActive`) VALUES
(1, 2, 'test', 'ACB', 9405123465478545, '2022-01-12 00:00:00', NULL, b'0');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `transactions`
--

CREATE TABLE `transactions` (
  `TransId` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Receiver` varchar(50) NOT NULL,
  `Subject` varchar(100) NOT NULL,
  `Content` varchar(1000) NOT NULL,
  `NameCard` varchar(50) NOT NULL,
  `ImageNameTrans` varchar(50) DEFAULT NULL,
  `TimeSend` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `transactions`
--

INSERT INTO `transactions` (`TransId`, `Username`, `Receiver`, `Subject`, `Content`, `NameCard`, `ImageNameTrans`, `TimeSend`) VALUES
(1, 'test', 'receiver@gmail.com', 'Happy Birthday my friend', 'Hello your 30! Wish you see many many lucky with this old, happiness and healthy', 'Birthday-01', 'b-image1.png', '2020-05-07 16:44:39');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `users`
--

CREATE TABLE `users` (
  `UserId` int(11) NOT NULL,
  `UserName` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `RePassword` varchar(50) NOT NULL,
  `Role` bit(1) NOT NULL,
  `IsSubcribeSend` bit(1) NOT NULL,
  `IsSubcribeReceive` bit(1) NOT NULL,
  `FullName` varchar(50) NOT NULL,
  `Gender` bit(1) NOT NULL,
  `Phone` text NOT NULL,
  `Email` varchar(50) NOT NULL,
  `IsVIP` bit(1) NOT NULL,
  `IsDeactive` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `users`
--

INSERT INTO `users` (`UserId`, `UserName`, `Password`, `RePassword`, `Role`, `IsSubcribeSend`, `IsSubcribeReceive`, `FullName`, `Gender`, `Phone`, `Email`, `IsVIP`, `IsDeactive`) VALUES
(1, 'admin', 'admin1234', 'admin1234', b'1', b'0', b'0', 'Admin', b'1', '0762327226', 'admin@egreeting.com', b'1', b'0'),
(2, 'test', '123123123', '123123123', b'0', b'0', b'0', 'test', b'1', '0762371254', 'test@gmail.com', b'0', b'0');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20200507094440_InitialMigration', '3.1.3');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `cards`
--
ALTER TABLE `cards`
  ADD PRIMARY KEY (`CardId`);

--
-- Chỉ mục cho bảng `emaillists`
--
ALTER TABLE `emaillists`
  ADD PRIMARY KEY (`EmailId`);

--
-- Chỉ mục cho bảng `feedbacks`
--
ALTER TABLE `feedbacks`
  ADD PRIMARY KEY (`FeedbackId`);

--
-- Chỉ mục cho bảng `paymentinfos`
--
ALTER TABLE `paymentinfos`
  ADD PRIMARY KEY (`PayId`);

--
-- Chỉ mục cho bảng `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`TransId`);

--
-- Chỉ mục cho bảng `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserId`);

--
-- Chỉ mục cho bảng `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `cards`
--
ALTER TABLE `cards`
  MODIFY `CardId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT cho bảng `emaillists`
--
ALTER TABLE `emaillists`
  MODIFY `EmailId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `feedbacks`
--
ALTER TABLE `feedbacks`
  MODIFY `FeedbackId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT cho bảng `paymentinfos`
--
ALTER TABLE `paymentinfos`
  MODIFY `PayId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT cho bảng `transactions`
--
ALTER TABLE `transactions`
  MODIFY `TransId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT cho bảng `users`
--
ALTER TABLE `users`
  MODIFY `UserId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
