CREATE PROC usp_EmployeesBySalaryLevel(@input NVARCHAR(50)) 
AS
SELECT FirstName, LastName
	FROM Employees
	WHERE dbo.ufn_GetSalaryLevel(Salary) = @input