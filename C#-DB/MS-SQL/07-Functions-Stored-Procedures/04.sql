CREATE PROC usp_GetEmployeesFromTown (@inputTown NVARCHAR(MAX))
AS
	SELECT FirstName, LastName 
	FROM Employees AS e
	JOIN Addresses AS a ON a.AddressID = e.AddressID
	JOIN Towns AS t ON t.TownID = a.TownID
	WHERE t.[Name] = @inputTown 