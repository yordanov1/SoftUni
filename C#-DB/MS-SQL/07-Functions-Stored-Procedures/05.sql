CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4)) 
RETURNS VARCHAR (50)
AS
BEGIN
DECLARE @levelOfSalary VARCHAR(50)

IF(@salary < 30000)
	SET @levelOfSalary = 'Low'
ELSE IF (@salary >= 30000 AND @salary <= 50000)
	SET @levelOfSalary = 'Average'
ELSE
	SET @levelOfSalary = 'High'

RETURN @levelOfSalary
END
