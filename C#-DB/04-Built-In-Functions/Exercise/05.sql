SELECT [Name]
FROM Towns
WHERE LEN(Towns.[Name]) = 5 OR LEN(Towns.[Name]) = 6
ORDER BY [Name]