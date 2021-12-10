SELECT c.CountryCode, COUNT(c.CountryCode)
	FROM Countries AS c
	JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode	
	WHERE c.CountryCode = 'BG' OR c.CountryCode = 'RU' OR c.CountryCode = 'US'
	GROUP BY c.CountryCode