-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th5 13, 2020 lúc 07:22 AM
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
  `CardName` varchar(50) NOT NULL,
  `CategoryId` int(11) NOT NULL,
  `ImageName` text DEFAULT NULL,
  `IsActive` tinyint(4) NOT NULL,
  `DateCreated` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `cards`
--

INSERT INTO `cards` (`CardId`, `CardName`, `CategoryId`, `ImageName`, `IsActive`, `DateCreated`) VALUES
(1, 'Birthday-01', 1, 'b-image1.png', 1, '2020-05-12 17:01:49'),
(2, 'Birthday-02', 1, 'b-image2.png', 1, '2020-05-12 17:01:49'),
(3, 'Birthday-03', 1, 'b-image3.png', 1, '2020-05-12 17:01:49'),
(4, 'Birthday-04', 1, 'b-image4.png', 1, '2020-05-12 17:01:49'),
(5, 'Birthday-05', 1, 'b-image5.png', 1, '2020-05-12 17:01:49'),
(6, 'Birthday-06', 1, 'b-image6.png', 1, '2020-05-12 17:01:49'),
(7, 'Birthday-07', 1, 'b-image7.png', 1, '2020-05-12 17:01:49'),
(8, 'Birthday-08', 1, 'b-image8.jpg', 1, '2020-05-12 17:01:49'),
(9, 'Birthday-09', 1, 'b-image9.png', 1, '2020-05-12 17:01:49'),
(10, 'Birthday-10', 1, 'b-image10.png', 1, '2020-05-12 17:01:49'),
(11, 'Birthday-11', 1, 'b-image11.png', 1, '2020-05-12 17:01:49'),
(12, 'Birthday-12', 1, 'b-image12.png', 1, '2020-05-12 17:01:49'),
(13, 'Birthday-13', 1, 'b-image13.png', 1, '2020-05-12 17:01:49'),
(14, 'Birthday-14', 1, 'b-image14.png', 1, '2020-05-12 17:01:49'),
(15, 'Birthday-15', 1, 'b-image15.png', 1, '2020-05-12 17:01:49'),
(16, 'Birthday-16', 1, 'b-image16.png', 1, '2020-05-12 17:01:49'),
(17, 'Birthday-17', 1, 'b-image17.png', 1, '2020-05-12 17:01:49'),
(18, 'Birthday-18', 1, 'b-image18.png', 0, '2020-05-12 17:01:49'),
(19, 'NewYear-02', 2, 'n-image2.jpg', 1, '2020-05-12 17:01:49'),
(20, 'NewYear-03', 2, 'n-image3.png', 1, '2020-05-12 17:01:49'),
(21, 'NewYear-04', 2, 'n-image4.jpg', 1, '2020-05-12 17:01:49'),
(22, 'NewYear-05', 2, 'n-image5.jpg', 1, '2020-05-12 17:01:49'),
(23, 'NewYear-06', 2, 'n-image6.jpg', 1, '2020-05-12 17:01:49'),
(24, 'NewYear-07', 2, 'n-image7.png', 1, '2020-05-12 17:01:49'),
(25, 'NewYear-08', 2, 'n-image8.png', 1, '2020-05-12 17:01:49'),
(26, 'NewYear-09', 2, 'n-image9.png', 1, '2020-05-12 17:01:49'),
(27, 'NewYear-10', 2, 'n-image10.png', 1, '2020-05-12 17:01:49'),
(28, 'NewYear-11', 2, 'n-image11.jpg', 1, '2020-05-12 17:01:49'),
(29, 'NewYear-12', 2, 'n-image12.jpg', 1, '2020-05-12 17:01:49'),
(30, 'NewYear-13', 2, 'n-image13.jpg', 1, '2020-05-12 17:01:49'),
(31, 'NewYear-14', 2, 'n-image14.jpg', 1, '2020-05-12 17:01:49'),
(32, 'NewYear-15', 2, 'n-image15.jpg', 1, '2020-05-12 17:01:49'),
(33, 'NewYear-16', 2, 'n-image16.jpg', 1, '2020-05-12 17:01:49'),
(34, 'NewYear-17', 2, 'n-image17.jpg', 1, '2020-05-12 17:01:49'),
(35, 'NewYear-18', 2, 'n-image18.jpg', 1, '2020-05-12 17:01:49'),
(36, 'Festival-01', 3, 'f-image1.png', 1, '2020-05-12 17:01:49'),
(37, 'Festival-02', 3, 'f-image2.jpg', 1, '2020-05-12 17:01:49'),
(38, 'Festival-03', 3, 'f-image3.jpg', 1, '2020-05-12 17:01:49'),
(39, 'Festival-04', 3, 'f-image4.jpg', 1, '2020-05-12 17:01:49'),
(40, 'Festival-05', 3, 'f-image5.jpg', 1, '2020-05-12 17:01:49'),
(41, 'Festival-06', 3, 'f-image6.jpg', 1, '2020-05-12 17:01:49'),
(42, 'Festival-07', 3, 'f-image7.jpg', 1, '2020-05-12 17:01:49'),
(43, 'Festival-08', 3, 'f-image8.png', 1, '2020-05-12 17:01:49'),
(44, 'Festival-09', 3, 'f-image9.png', 1, '2020-05-12 17:01:49'),
(45, 'Festival-10', 3, 'f-image10.png', 1, '2020-05-12 17:01:49'),
(46, 'Festival-11', 3, 'f-image11.png', 1, '2020-05-12 17:01:49'),
(47, 'Festival-12', 3, 'f-image12.png', 1, '2020-05-12 17:01:49'),
(48, 'Festival-13', 3, 'f-image13.jpg', 1, '2020-05-12 17:01:49'),
(49, 'Festival-14', 3, 'f-image14.jpg', 1, '2020-05-12 17:01:49'),
(50, 'Festival-15', 3, 'f-image15.png', 1, '2020-05-12 17:01:49'),
(51, 'Festival-16', 3, 'f-image16.jpg', 1, '2020-05-12 17:01:49'),
(52, 'Festival-17', 3, 'f-image17.png', 1, '2020-05-12 17:01:49'),
(53, 'Festival-18', 3, 'f-image18.jpg', 1, '2020-05-12 17:01:49'),
(54, 'NewYear-01', 2, 'n-image1.png', 1, '2020-05-12 17:01:49');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `categories`
--

CREATE TABLE `categories` (
  `CategoryId` int(11) NOT NULL,
  `CategoryName` varchar(50) NOT NULL,
  `IsActive` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `categories`
--

INSERT INTO `categories` (`CategoryId`, `CategoryName`, `IsActive`) VALUES
(1, 'Birthday', 1),
(2, 'Newyear', 1),
(3, 'Festival', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `feedbacks`
--

CREATE TABLE `feedbacks` (
  `FeedbackId` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Subject` varchar(50) NOT NULL,
  `Content` varchar(1000) NOT NULL,
  `IsChecked` tinyint(4) NOT NULL,
  `DateCreated` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `feedbacks`
--

INSERT INTO `feedbacks` (`FeedbackId`, `Username`, `Subject`, `Content`, `IsChecked`, `DateCreated`) VALUES
(1, 'user', 'user', 'Hello Handsome Guys', 0, '2020-05-12 17:01:49');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `paymentinfos`
--

CREATE TABLE `paymentinfos` (
  `PayId` int(11) NOT NULL,
  `UserName` varchar(50) NOT NULL,
  `BankName` varchar(50) NOT NULL,
  `BankAccount` bigint(20) NOT NULL,
  `DateExpire` datetime NOT NULL,
  `DateCreated` datetime DEFAULT NULL,
  `IsActive` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `paymentinfos`
--

INSERT INTO `paymentinfos` (`PayId`, `UserName`, `BankName`, `BankAccount`, `DateExpire`, `DateCreated`, `IsActive`) VALUES
(1, 'user', 'ACB', 9405123465478545, '2022-01-12 00:00:00', NULL, 0);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `subscribelists`
--

CREATE TABLE `subscribelists` (
  `SubscribeId` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `SubscribeEmail` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
  `CardId` int(11) NOT NULL,
  `TransImage` varchar(50) DEFAULT NULL,
  `Status` tinyint(4) NOT NULL,
  `TimeSend` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `transactions`
--

INSERT INTO `transactions` (`TransId`, `Username`, `Receiver`, `Subject`, `Content`, `CardId`, `TransImage`, `Status`, `TimeSend`) VALUES
(1, 'user', 'receiver@gmail.com', 'Happy Birthday my friend', 'Hello your 30! Wish you see many many lucky with this old, happiness and healthy', 0, 'b-image1.png', 0, '2020-05-12 17:01:49');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `users`
--

CREATE TABLE `users` (
  `UserName` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `FullName` varchar(50) NOT NULL,
  `Gender` tinyint(4) NOT NULL,
  `Phone` text NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Role` tinyint(4) NOT NULL,
  `IsActive` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `users`
--

INSERT INTO `users` (`UserName`, `Password`, `FullName`, `Gender`, `Phone`, `Email`, `Role`, `IsActive`) VALUES
('admin', 'admin1234', 'Admin', 1, '0762327226', 'admin@egreeting.com', 0, 1),
('user', '123123123', 'Test User', 1, '0762371254', 'test@gmail.com', 1, 1);

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
('20200512100150_InitialMigration', '3.1.3');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `cards`
--
ALTER TABLE `cards`
  ADD PRIMARY KEY (`CardId`);

--
-- Chỉ mục cho bảng `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`CategoryId`);

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
-- Chỉ mục cho bảng `subscribelists`
--
ALTER TABLE `subscribelists`
  ADD PRIMARY KEY (`SubscribeId`);

--
-- Chỉ mục cho bảng `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`TransId`);

--
-- Chỉ mục cho bảng `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserName`);

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
  MODIFY `CardId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT cho bảng `categories`
--
ALTER TABLE `categories`
  MODIFY `CategoryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

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
-- AUTO_INCREMENT cho bảng `subscribelists`
--
ALTER TABLE `subscribelists`
  MODIFY `SubscribeId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `transactions`
--
ALTER TABLE `transactions`
  MODIFY `TransId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
