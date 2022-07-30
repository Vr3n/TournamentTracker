-- Create Table People
CREATE TABLE Person
(
	id INT PRIMARY KEY IDENTITY (1, 1),
	FirstName NVARCHAR(250) NOT NULL,
	LastName NVARCHAR(250) NOT NULL,
	EmailAddress NVARCHAR(250) NOT NULL,
	CellPhoneNumber NVARCHAR(250) NOT NULL,
	created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
	updated_at DATETIME2
);
GO

-- Trigger to update `updated_at` field.
CREATE TRIGGER E_U_PERSON
ON Person
FOR UPDATE
AS 
UPDATE T
SET updated_at = SYSDATETIME()
FROM Person AS T
	JOIN inserted AS i
		ON T.id = i.id;
GO

-- Create Table Prize
CREATE TABLE Prize
(
	id INT PRIMARY KEY IDENTITY (1, 1),
	PlaceNumber int NOT NULL,
	PlaceName NVARCHAR(250) NOT NULL,
	PrizeAmount MONEY NULL,
	PrizePercentage DECIMAL(5,4) NULL,
	created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
	updated_at DATETIME2
);
GO

-- Trigger to update `updated_at` field.
CREATE TRIGGER E_U_PRIZE
ON Prize
FOR UPDATE
AS 
UPDATE T
SET updated_at = SYSDATETIME()
FROM Prize AS T
	JOIN inserted AS i
		ON T.id = i.id;
GO