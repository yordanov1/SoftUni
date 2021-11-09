SELECT * FROM(
SELECT EmployeeID, FirstName, LastName, Salary, DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS Ranked
	FROM Employees 
	WHERE Salary BETWEEN 10000 AND 50000 
) AS Result
	WHERE Ranked = 2
    ORDER BY Salary DESC