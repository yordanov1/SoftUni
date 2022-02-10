CREATE PROC usp_GetTownsStartingWith (@Input NVARCHAR(MAX))
AS
SELECT [Name]
	FROM Towns
	WHERE [Name] LIKE @Input + '%'