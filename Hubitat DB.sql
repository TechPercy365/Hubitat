CREATE DATABASE db_Hubitat
USE db_Hubitat
USE activity1

DROP DATABASE db_Hubitat
DROP TABLE [Landlords]
DROP TABLE [Users]

CREATE TABLE [Users] (
	userID varchar(7) PRIMARY KEY NOT NULL,
	userName varchar(50) NOT NULL,
	userPass varbinary(255) NOT NULL,
	userType varchar(10) NOT NULL
)

CREATE TABLE [Tenants] (
	tenantID varChar(7) PRIMARY KEY,
	firstName varchar(100),
	lastName varchar(100), 
	email varchar(50),
	phoneNum varchar(15),
	userID varchar(7),	
	FOREIGN KEY (userID) REFERENCES [Users](userID)	
)

CREATE TABLE [Landlords] (
	landlordID varchar(7) PRIMARY KEY,
	firstName varchar(100),
	lastName varchar(100),	 
	email varchar(50),
	phoneNum varchar(15),
	userID varchar(7),	
	FOREIGN KEY (userID) REFERENCES [Users](userID),
)

CREATE TABLE [Apartments] (
	apmtID varchar(7) PRIMARY KEY NOT NULL,
	apmtDescription varchar(500),
	apmtPrice decimal(5,2) NOT NULL,	
	apmtType varchar(25) NOT NULL, -- Good for * persons
	apmtStatus varchar(10) NOT NULL, -- Vacant, Occupied, Maintenance
	apmtImg varchar(500),
	landlordID varchar(7) NOT NULL,
	FOREIGN KEY (landlordID) REFERENCES [Landlords](landlordID)
)

CREATE TABLE [Rent] (
	rentID varchar(7) PRIMARY KEY NOT NULL,
	tenantID varchar(7),
	FOREIGN KEY (tenantId) REFERENCES [Tenants](tenantID),
	apmtID varchar(7),
	FOREIGN KEY (apmtID) REFERENCES [Apartments](apmtID),
	CheckInDate DATE,
	CheckOutDate DATE,
	TotalAmount decimal(10,2)
)

CREATE TABLE [Payment] (
	paymentID varchar(7) PRIMARY KEY NOT NULL,
	rentID varchar(7) NOT NULL,	
	FOREIGN KEY (rentID) REFERENCES [Rent](rentID),		
	payMethod varchar(15),
	payAmount decimal(7,2) NOT NULL,
	payTotalPay decimal(7,2) NOT NULL,
	payChange decimal(7,2) NOT NULL,
	payDate DATE NOT NULL --Date the tenant paid for their monthly rent
)



---<<<<<<<<<<<   VIEW METHODS   >>>>>>>>>>>>---

------------ FOR LANDLORDS -------------
CREATE VIEW vw_AllUsers AS
SELECT us.userID AS 'User ID', us.userName as 'Username', us.userType as 'Role/Type',
COALESCE(ten.tenantID, ln.landlordID) as 'Role ID', COALESCE(ten.firstName, ln.firstName) as 'First Name',
COALESCE(ten.lastName, ln.lastName) as 'Last Name', COALESCE(ten.email, ln.email) as 'Email',
COALESCE(ten.phoneNum, ln.phoneNum) as 'Phone Number'
FROM [Users] us
LEFT JOIN [Tenants] ten ON us.userID = ten.tenantID
LEFT JOIN [Landlords] ln ON us.userID = ln.landlordID

CREATE VIEW vw_Tenants AS
SELECT ten.tenantID as 'Tenant ID', ten.firstName as 'First Name', ten.lastName as 'Last Name', 
us.userName as 'Username', us.userType as 'Role', ten.phoneNum as 'Phone Number', ten.email as 'Email',
us.userDateCreatedAt as 'Date Account Created', us.userID as 'User ID'
FROM [Tenants] ten
JOIN [Users] us ON us.userID = ten.tenantID

CREATE VIEW vw_Landlords AS
SELECT lan.landlordID as 'Landlord ID', lan.firstName as 'First Name', lan.lastName as 'Last Name', 
us.userName as 'Username', lan.phoneNum as 'Phone Number', lan.email as 'Email',
us.userDateCreatedAt as 'Date Account Created', us.userID as 'User ID'
FROM [Landlords] lan
JOIN [Users] us ON us.userID = lan.landlordID

-- CREATE VIEW vw_rentApartment *apmt ID and apmtStatus only*

--CREATE VIEW vw_PaymentHistory

--CREATE VIEW vw_UserDueRent


------------ FOR TENANTS ---------------
--CREATE VIEW vw_UserPaymentHistory

--CREATE VIEW vw_Users

--CREATE VIEW vw_Apartments




--DROP DATABASE db_Hubitat


-- STORED PROCEDURE METHODS

CREATE PROCEDURE sp_RegisterTenant
	@userID varchar(7), @userName varchar(50), @userPass varbinary(255),  @userType varchar(10),
	@tenantID varchar(7), @firstName varchar(100), @lastName varchar(100), 
	@email varchar(50), @phoneNum varchar(15)
AS BEGIN	
INSERT INTO [Users] (userID, userName, userPass, userType) 
VALUES (@userID, @userName, @userPass,  @userType)
INSERT INTO [Tenants] (tenantID, firstName, lastName, email, phoneNum, userID)
VALUES (@tenantID, @firstName, @lastName, @email, @phoneNum, @userID)
END

CREATE PROCEDURE sp_RegisterLandlord
	@userID varchar(7), @userName varchar(50), @userPass varbinary(255),  @userType varchar(10),
	@landlordID varchar(7), @firstName varchar(100), @lastName varchar(100), 
	@email varchar(50), @phoneNum varchar(15)
AS BEGIN	
INSERT INTO [Users] (userID, userName, userPass, userType) 
VALUES (@userID, @userName, @userPass,  @userType)
INSERT INTO [Tenants] (tenantID, firstName, lastName, email, phoneNum, userID)
VALUES (@landlordID, @firstName, @lastName, @email, @phoneNum, @userID)
END

CREATE PROCEDURE sp_EditUsersInfo
