IF NOT EXISTS(SELECT * FROM sys.databases WHERE NAME = 'DevData')
BEGIN
	CREATE DATABASE [DevData]
END
GO
	USE [DevData]
GO
IF NOT EXISTS(SELECT * FROM sysobjects WHERE name = 'Table_A' AND xtype='U')
BEGIN
CREATE TABLE Table_A (Col_A1 int, Col_A2 varchar(10), Col_A3 date);
END

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name = 'Table_B' AND xtype='U')
BEGIN
CREATE TABLE Table_B (Col_B1 int, Col_B2 nchar(10), Col_B3 int);
END

IF NOT EXISTS(SELECT * FROM sysobjects WHERE name = 'Table_C' AND xtype='U')
BEGIN
CREATE TABLE Table_C (Col_C1 varchar (10), Col_C2 timestamp, Col_C3 
<<<<<<< HEAD
int, Col_C4 char (10) );END
=======
int, Col_C4 char (10) );
END

>>>>>>> c90521a1ffe0ceb072e0e854f73ee95cff8dd2ad
