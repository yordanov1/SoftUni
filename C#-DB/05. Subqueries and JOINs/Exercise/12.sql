SELECT c.CountryCode, m.MountainRange, p.PeakName, p.Elevation
	FROM Peaks AS p
	JOIN Mountains AS m ON m.Id = p.MountainId
	JOIN MountainsCountries AS c ON c.MountainId = m.Id

	WHERE c.CountryCode = 'BG' AND p.Elevation > 2835
	ORDER BY p.Elevation DESC