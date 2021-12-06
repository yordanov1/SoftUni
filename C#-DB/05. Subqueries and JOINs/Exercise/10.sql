SELECT TOP(50) emp.EmployeeID,
	   emp.FirstName + ' ' + emp.LastName AS EmployeeName,
	   man.FirstName + ' ' + man.LastName AS ManagerName,
	   dep.[Name] AS DepartmentName
	FROM Employees AS emp
	JOIN Employees AS man ON emp.ManagerID = man.EmployeeID
	JOIN Departments AS dep ON emp.DepartmentID = dep.DepartmentID

	ORDER BY EmployeeID