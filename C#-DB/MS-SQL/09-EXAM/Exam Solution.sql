
CREATE DATABASE [Service]
----------------------------------------------------------------------------------------------------------------------1

CREATE TABLE Users
(
Id INT PRIMARY KEY IDENTITY,
Username VARCHAR(30) UNIQUE NOT NULL,
[Password] VARCHAR(50) NOT NULL,
[Name] VARCHAR(50),
Birthdate DATETIME,
Age INT CHECK(Age >= 14 AND Age <= 110),   
Email VARCHAR(50) NOT NULL
)

CREATE TABLE Departments
(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(50) NOT NULL,
)

CREATE TABLE Employees
(
Id INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(25),
LastName VARCHAR(25),
Birthdate DATETIME,
Age INT CHECK(Age >= 18 AND Age <=110),
DepartmentId INT FOREIGN KEY REFERENCES Departments(Id) NOT NULL
)

CREATE TABLE Categories
(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(50) NOT NULL,
DepartmentId INT FOREIGN KEY REFERENCES Departments(Id) NOT NULL,
)

CREATE TABLE [Status]
(
Id INT PRIMARY KEY IDENTITY,
[Label] VARCHAR(30) NOT NULL
)

CREATE TABLE Reports
(
Id INT PRIMARY KEY IDENTITY,
CategoryId INT FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
StatusId INT FOREIGN KEY REFERENCES [Status](Id) NOT NULL,
OpenDate DATETIME NOT NULL,
CloseDate DATETIME,
[Description] VARCHAR(200) NOT NULL,
UserId INT FOREIGN KEY REFERENCES Users(Id) NOT NULL,
EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) 
)

------------------------------------------------------------------------------------------------------------------------- 2
INSERT INTO Employees(FirstName, LastName, Birthdate, DepartmentId)
VALUES ('Marlo',   'OMalley'	,'1958-9-21' ,  1  ),
       ('Niki',	   'Stanaghan'	,'1969-11-26',	4 ),
       ('Ayrton',  'Senna'	    ,'1960-03-21',	9 ),
       ('Ronnie',  'Peterson'	,'1944-02-14',	9 ),
       ('Giovanna','Amati'	    ,'1959-07-20',	5 )


INSERT INTO Reports(CategoryId,	StatusId, OpenDate,	CloseDate, [Description], UserId, EmployeeId)
VALUES (1	,1	,'2017-04-13', '',	         'Stuck Road on Str.133',	      6,	2),
       (6	,3	,'2015-09-05', '2015-12-06', 'Charity trail running',	      3,	5),
       (14	,2	,'2015-09-07', '',           'Falling bricks on Str.58',	  5,	2),
       (4	,3	,'2017-07-03', '2017-07-06', 'Cut off streetlight on Str.11', 1,	1)

-----------------------------------------------------------------------------------------------------------------3
UPDATE Reports
SET CloseDate = GETDATE()
WHERE CloseDate IS NULL

-----------------------------------------------------------------------------------------------------------------4
DELETE FROM Reports
WHERE StatusId = 4



-----------------------------------------------------------------------------------------------------------------5

SELECT r.[Description], FORMAT(r.OpenDate, 'dd-MM-yyyy')
FROM Reports AS r
LEFT JOIN Employees AS e ON e.Id = r.EmployeeId
WHERE e.Id IS NULL
ORDER BY r.OpenDate , r.[Description]



-----------------------------------------------------------------------------------------------------------------6
SELECT r.[Description], c.[Name] AS CategoryName
FROM Reports AS r
LEFT JOIN Categories AS c ON c.Id = R.CategoryId
ORDER BY r.[Description], c.[Name]




-----------------------------------------------------------------------------------------------------------------7
SELECT TOP(5) c.[Name], COUNT(c.[Name]) AS ReportsNumber
FROM Categories AS c
LEFT JOIN Reports AS r ON r.CategoryId = c.Id
GROUP BY c.[Name]
ORDER BY COUNT(c.[Name]) DESC, c.[Name]




-----------------------------------------------------------------------------------------------------------------8
SELECT u.Username, c.[Name] AS CategoryName
FROM Reports AS r
JOIN Users AS u ON u.Id = r.UserId
JOIN Categories AS c ON c.Id = r.CategoryId
WHERE DATEPART(DAY, u.Birthdate)+ ' ' + DATEPART(MONTH, u.Birthdate) = 
      DATEPART(DAY, r.OpenDate) + ' ' + DATEPART(MONTH, r.OpenDate) 
ORDER BY u.Username, c.[Name]



-----------------------------------------------------------------------------------------------------------------9
SELECT e.FirstName + ' ' + e.LastName AS FullName , COUNT(u.Id) AS UsersCount
FROM Employees AS e
LEFT JOIN Reports AS r ON r.EmployeeId = e.Id
LEFT JOIN Users AS u ON u.Id = r.UserId
GROUP BY e.FirstName + ' ' + e.LastName
ORDER BY UsersCount DESC, FullName


------------------------------------------------------------------------------------------------------------------------------------------10
SELECT ISNULL(e.FirstName + ' ' + e.LastName, 'None') AS Employee, 
       ISNULL(d.[Name], 'None') AS Department, 
       ISNULL(c.[Name], 'None') AS Category,
       ISNULL(r.[Description], 'None') AS [Description], 
       ISNULL(FORMAT(r.OpenDate, 'dd.MM.yyyy'), 'None') AS OpenDate,
	   ISNULL(s.[Label], 'None') AS [Status],
	   ISNULL(u.[Name], 'None') AS [User]
FROM Reports AS r
LEFT JOIN Users AS u ON u.Id = r.UserId
LEFT JOIN Employees AS e ON e.Id = r.EmployeeId
LEFT JOIN Departments AS d ON d.Id = e.DepartmentId
LEFT JOIN [Status] AS s ON s.Id = r.StatusId
LEFT JOIN Categories AS c ON c.Id = r.CategoryId
ORDER BY e.FirstName DESC, e.LastName DESC, d.[Name], c.[Name], r.Description,FORMAT(r.OpenDate, 'dd.MM.yyyy'),s.[Label], u.[Name]




-----------------------------------------------------------------------------------------------------------------11
CREATE FUNCTION udf_HoursToComplete(@StartDate DATETIME, @EndDate DATETIME)
RETURNS INT
AS

BEGIN

IF(@StartDate IS NULL)
RETURN 0

IF(@EndDate IS NULL)
RETURN 0

DECLARE @dif INT

SET @dif = DATEDIFF( HOUR ,@StartDate , @EndDate ) 
RETURN @dif

END


-----------------------------------------------------------------------------------------------------------------12
CREATE PROCEDURE usp_AssignEmployeeToReport(@EmployeeId INT, @ReportId INT) 
AS
BEGIN 

DECLARE @EmployeeDepartment INT 
DECLARE @ReportDepartment INT 
 
SET @EmployeeDepartment = (SELECT [DepartmentID]
                             FROM [Employees]
                            WHERE Id = @EmployeeId) 
 
SET @ReportDepartment = (SELECT [DepartmentId] 
                           FROM [Reports] AS r
                           LEFT JOIN [Categories] AS c ON r.CategoryId = c.[Id]
                          WHERE r.[Id] = @ReportId)
 
IF @EmployeeDepartment <> @ReportDepartment
  THROW 500001, 'Employee doesn''t belong to the appropriate department!',1;

UPDATE Reports
SET [EmployeeId] = @EmployeeId
WHERE [Id] = @ReportId
END







