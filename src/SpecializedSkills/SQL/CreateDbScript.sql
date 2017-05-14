-- First you must create db called HackerRank

-- Basic Select Challegnes
-- https://www.hackerrank.com/domains/sql/select

USE HackerRank
GO 

CREATE TABLE City
	(Id int PRIMARY KEY NOT NULL,
	[Name] varchar(17) NOT NULL,
	CountryCode varchar(3) NOT NULL,
	District varchar(20) NOT NULL,
	[Population] int NOT NULL)
GO

BULK INSERT City
    FROM 'YOUR-PATH-TO-FILE -> \CitiesData.csv'
    WITH(
	   FIELDTERMINATOR = ';',
	   ROWTERMINATOR = '\n');
GO

CREATE TABLE Station
	(Id int PRIMARY KEY NOT NULL,
	City varchar(21) NOT NULL,
	[State] varchar(2) NOT NULL,
	Lat_N int NOT NULL,
	Long_W int NOT NULL)
GO

BULK INSERT Station
    FROM 'YOUR-PATH-TO-FILE -> \StationsData.csv'
    WITH(
	   FIELDTERMINATOR = ';',
	   ROWTERMINATOR = '\n');
GO