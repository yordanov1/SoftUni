SELECT TOP(5) e.EmployeeID, e.JobTitle, a.AddressID, a.AddressText
	FROM Employees e
	JOIN Addresses a ON a.AddressID = e.AddressID
	ORDER BY AddressID

SELECT TOP(5) e.EmployeeID, e.JobTitle, e.AddressID, a.AddressText
        FROM Employees AS e
	JOIN Addresses AS a ON a.AddressID = e.AddressID
	ORDER BY AddressID