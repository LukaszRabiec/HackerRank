-- First you must create db called HackerRank

USE HackerRank
GO 

CREATE TABLE City
	(Id int PRIMARY KEY NOT NULL,
	[Name] varchar(17) NOT NULL,
	CountryCode varchar(3) NOT NULL,
	District varchar(20) NOT NULL,
	[Population] int NOT NULL)
GO

INSERT City (Id, [Name], CountryCode, District, [Population])
    VALUES (6, 'Rotterdam', 'NLD', 'Zuid-Holland', 593321),
	   (3878, 'Scottsdale', 'USA', 'Arizona', 202705 ),
	   (3965, 'Corona', 'USA', 'California', 124966 ),
	   (3973, 'Concord', 'USA', 'California', 121780),
	   (3977, 'Cedar Rapids', 'USA', 'Iowa', 120758),
	   (3982, 'Coral Springs', 'USA', 'Florida', 117549),
	   (4054, 'Fairfield', 'USA', 'California', 92256),
	   (4058, 'Boulder', 'USA', 'Colorado', 91238),
	   (4061, 'Fall River', 'USA', 'Massachusetts', 90555)
GO