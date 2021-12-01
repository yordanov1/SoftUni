SELECT e.FirstName, e.LastName, e.HireDate, d.[Name] AS DeptName
	FROM Employees AS e 
	JOIN Departments AS d ON d.DepartmentID = e.DepartmentID

	WHERE e.HireDate > '1999-1-1' AND (d.[Name] = 'Sales' OR d.[Name] = 'Finance')
	ORDER BY e.HireDate