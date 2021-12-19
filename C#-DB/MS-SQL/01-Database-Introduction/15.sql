
CREATE TABLE Employees
(
Id INT PRIMARY KEY,
FirstName VARCHAR(90) NOT NULL,
LastName VARCHAR(90) NOT NULL,
Title VARCHAR(50) NOT NULL,
Notes VARCHAR(MAX),
)

INSERT INTO Employees(Id, FirstName, LastName, Title, Notes) 
VALUES (1, 'Z', 'Z', 'CEO', NULL),
       (2, 'F', 'F', 'CFO', NULL),
       (3, 'V', 'C', 'CE', NULL)



-- #######################################
-- #######################################



CREATE TABLE Customers
(
	AccountNumber INT PRIMARY KEY,
	FirstName VARCHAR(90) NOT NULL,
	LastName VARCHAR(90) NOT NULL,
	PhoneNumber CHAR(10) NOT NULL,
	EmergencyName VARCHAR(90) NOT NULL,
	EmergencyNumber CHAR(10) NOT NULL,
	Notes VARCHAR(MAX),
)

INSERT INTO Customers(AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes) 
VALUES (11, 'Z', 'Z', '123', 'z', '1234567890', NULL),
       (22, 'F', 'F', '456', 'z', '1234567890', NULL),
       (33, 'V', 'C', '456', 'z', '1234567890', NULL)



-- #######################################
-- #######################################



CREATE TABLE RoomStatus
(
	RoomStatus BIT NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO RoomStatus(RoomStatus, Notes) 
VALUES (0, NULL),
       (1, NULL),
       (0, NULL)


-- #######################################
-- #######################################	


CREATE TABLE RoomTypes
(
	RoomType VARCHAR(20) NOT NULL,
	Notes VARCHAR(MAX)
)
INSERT INTO RoomTypes(RoomType, Notes) 
VALUES ('Single', NULL),
       ('Single', NULL),
       ('Single', NULL)


--#########################################
--#########################################



	
CREATE TABLE BedTypes
(
	BedType VARCHAR(20) NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO BedTypes(BedType, Notes) 
VALUES ('Single', NULL),
       ('Single', NULL),
       ('Single', NULL)


--#########################################
--#########################################


CREATE TABLE Rooms
(
	RoomNumber INT PRIMARY KEY,
	RoomType VARCHAR(20) NOT NULL,
	BedType VARCHAR(20) NOT NULL,
	Rate INT,
	RoomStatus BIT,
	Notes VARCHAR(MAX)
)

INSERT INTO Rooms(RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes) 
VALUES (111, 'Z', 'Z', 123, 1, NULL),
       (222, 'F', 'F', 456, 1, NULL),
       (333, 'V', 'C', 456, 1, NULL)



--#########################################
--#########################################


	--Payments (Id, EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes)
CREATE TABLE Payments
(
	Id INT PRIMARY KEY,
	EmployeeId INT NOT NULL,
	PaymentDate DATETIME NOT NULL,
	AccountNumber INT NOT NULL,
	FirstDateOccupied DATETIME NOT NULL,
	LastDateOccupied DATETIME NOT NULL,
	TotalDays INT NOT NULL,
	AmountCharged DECIMAL(14,2),
	TaxRate INT,
	TaxAmount INT,
	PaymentTotal DECIMAL(14,2),
	Notes VARCHAR(MAX)
)

INSERT INTO Payments(Id, EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes) 
VALUES (1, 123, GETDATE(), 123, '5/5/2012', '5/5/2011', 11, 1.34, NULL, NULL, 0.22, NULL),
       (2, 124, GETDATE(), 456, '5/5/2012', '5/5/2011', 11, 1.34, NULL, NULL, 0.22, NULL),
       (3, 125, GETDATE(), 456, '5/5/2012', '5/5/2011', 11, 1.34, NULL ,NULL, 0.22, NULL)



--#########################################
--#########################################


	--Occupancies (Id, EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)

CREATE TABLE Occupancies
(
	Id INT PRIMARY KEY,
	EmployeeId INT NOT NULL,
	DateOccupied DATETIME NOT NULL,
	AccountNumber INT NOT NULL,
	RoomNumber INT NOT NULL,
	RateApplied INT,
	PhoneCharge DECIMAL(14,2),
	Notes VARCHAR(MAX)
)


INSERT INTO Occupancies(Id, EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes) 
VALUES (1, 123, GETDATE(), 123, 11, NULL, 0.22, NULL),
       (2, 124, GETDATE(), 124, 12, NULL, 0.22, NULL),
       (3, 125, GETDATE(), 124, 13, NULL, 0.22, NULL)

