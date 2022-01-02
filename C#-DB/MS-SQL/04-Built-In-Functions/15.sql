SELECT Username, SUBSTRING(Email, CHARINDEX('@', Email)+1 , 100) AS [Email Provider]
FROM Users
ORDER BY [Email Provider], Username