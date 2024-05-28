CREATE DATABASE hubitatDB
USE hubitatDB

DROP TABLE [Pets]

CREATE TABLE [Users] (
	userID varchar(7) PRIMARY KEY NOT NULL,
	userName varchar(50) NOT NULL,
	userPass varbinary(255) NOT NULL,
	userType varchar(10) NOT NULL, --Example: Customer or Employee
	firstName varchar(50),
	lastName varchar(50), 
	email varchar(50) NOT NULL,
	phoneNum varchar(15),	
	dateCreated DATETIME
)

 
CREATE TABLE [Pets] (
	petID varchar(7) PRIMARY KEY NOT NULL,
	petName varchar(100),
	petSpecies varchar(20) NOT NULL,
	petBreed varchar(20) NOT NULL,
	petAge int NOT NULL,	
	petGender varchar(10) NOT NULL,
	petStatus varchar(10) NOT NULL, --Example: Available, Sold, 	
	petPrice decimal(10,2) NOT NULL,
	petImage image
)

CREATE TABLE [Transactions] (
	transactionID varchar(7) PRIMARY KEY NOT NULL,
	userID varchar(7) NOT NULL,
	petID varchar(7) NOT NULL,
	totalPayment decimal(10,2) NOT NULL,
	amountCustPay decimal(10,2) NOT NULL,
	payChange decimal(10,2) NOT NULL,
	transDate DATETIME 
)

SELECT * FROM [Transactions]
DELETE FROM [Transactions] WHERE transactionID = 'T-001'

---<<<<<<<<<<<   VIEW METHODS   >>>>>>>>>>>>---

CREATE VIEW vw_TransactionReports AS
SELECT
    t.transactionID as 'Transaction ID',
    u.userID as 'User ID',
    u.userName as 'User Name',
    u.email as 'Email',
    p.petID as 'Pet ID',
    p.petName as 'Pet Name',
    p.petSpecies as 'Pet Species',
    p.petBreed as 'Pet Breed',
    t.totalPayment as 'Total Payment',
    t.amountCustPay as 'Amount Pay',
    t.payChange as 'Change Amount',
    t.transDate as 'Transaction Date'
FROM
    Transactions t
JOIN
    Users u ON t.userID = u.userID
JOIN
    Pets p ON t.petID = p.petID;

CREATE VIEW vw_Users AS
SELECT us.userID AS 'User ID', us.userName as 'Username', us.userType as 'Role/Type',
us.firstName as 'First Name', us.lastName as 'Last Name', 
us.email as 'Email', us.phoneNum as 'Phone Number', dateCreated as 'Account Date Created'
FROM [Users] us

CREATE VIEW vw_Customers AS
SELECT us.userID AS 'User ID', us.userName as 'Username', us.userType as 'Role/Type',
us.firstName as 'First Name', us.lastName as 'Last Name', 
us.email as 'Email', us.phoneNum as 'Phone Number', dateCreated as 'Account Date Created'
FROM [Users] us
WHERE us.userType = 'CUSTOMER'

CREATE VIEW vw_Employees AS
SELECT us.userID AS 'User ID', us.userName as 'Username', us.userType as 'Role/Type',
us.firstName as 'First Name', us.lastName as 'Last Name', 
us.email as 'Email', us.phoneNum as 'Phone Number', dateCreated as 'Account Date Created'
FROM [Users] us
WHERE us.userType = 'EMPLOYEE'

CREATE VIEW vw_AllPets AS
SELECT petImage as 'Pet Image', petID as 'Pet ID', petName as 'Pet Name',
petSpecies as 'Species', petBreed as 'Breed', petAge as 'Pet Age', petGender as 'Gender',
petStatus as 'Pet Status', petPrice as 'Pet Price'
FROM [Pets]

CREATE VIEW vw_PetAvailable AS 
SELECT petImage as 'Pet Image', petID as 'Pet ID', petName as 'Pet Name',
petSpecies as 'Species', petBreed as 'Breed', petAge as 'Pet Age', petGender as 'Gender',
petStatus as 'Pet Status', petPrice as 'Pet Price'
FROM [Pets]
WHERE petStatus = 'AVAILABLE'

CREATE VIEW vw_PetSold AS 
SELECT petImage as 'Pet Image', petID as 'Pet ID', petName as 'Pet Name',
petSpecies as 'Species', petBreed as 'Breed', petAge as 'Pet Age', petGender as 'Gender',
petStatus as 'Pet Status', petPrice as 'Pet Price'
FROM [Pets]
WHERE petStatus = 'SOLD'

CREATE VIEW vw_BuyPet AS
SELECT petID as 'Pet ID', petSpecies as 'Pet Species', petBreed as 'Pet Breed'
FROM [Pets]
WHERE petStatus = 'AVAILABLE'
DROP VIEW vw_BuyPet

---<<<<<<<<<<<   STORED PROCEDURES   >>>>>>>>>>>>---
CREATE PROCEDURE sp_UserUpdate
	@userID varchar(7), @userName varchar(50), @userType varchar(10),
	@firstName varchar(100), @lastName varchar(100), @email varchar(50),
	@phoneNum varchar(15), @dateCreated DATETIME
AS
UPDATE [Users] SET	
userID = @userID, userName = @userName, userType = @userType, 
firstName = @firstName, lastName = @lastName, email = @email, 
phoneNum = @phoneNum, dateCreated = @dateCreated
WHERE userID = @userID

CREATE PROCEDURE sp_PetUpdate
	@petID varchar(7), @petName varchar(100), @petSpecies varchar(20),
	@petBreed varchar(20), @petAge int, @petGender varchar(10),
	@petStatus varchar(10), @petPrice decimal(10,2), @petImage image
AS UPDATE [Pets] SET
petID = @petID, petName = @petName, petSpecies = @petSpecies,
petBreed = @petBreed, petAge = @petAge, petGender = @petGender,
petStatus = @petStatus, @petPrice = @petPrice, @petImage = @petImage
WHERE petID = @petID
