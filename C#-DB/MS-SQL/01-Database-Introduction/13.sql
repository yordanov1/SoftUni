--CREATE DATABASE Movies 


CREATE TABLE Directors 
(
	Id INT PRIMARY KEY NOT NULL,
	DirectorName VARCHAR(50) NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO Directors (Id, DirectorName, Notes)
VALUES (1, 'Jon', NULL),
       (2, 'JB', NULL),
       (3, 'Yanya', NULL),
       (4, 'Dimitrichko', NULL),
       (5, 'Dimitrichka', NULL)





CREATE TABLE Genres  
(
	Id INT PRIMARY KEY NOT NULL,
	GenreName VARCHAR(20) NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO Genres (Id, GenreName, Notes)
VALUES (1, 'Action', 'Mnogo qko'),
       (2, 'Comedy', NULL),
       (3, 'Comedy', NULL),
       (4, 'Horror', NULL),
       (5, 'Action', NULL)





CREATE TABLE Categories   
(
	Id INT PRIMARY KEY NOT NULL,
	CategoryName VARCHAR(20) NOT NULL,
	Notes VARCHAR(MAX)
)

INSERT INTO Categories (Id, CategoryName, Notes)
VALUES (1, 'Hard', 'Mnogo qko'),
       (2, 'Soft', NULL),
       (3, 'Middle', NULL),
       (4, 'Hard', NULL),
       (5, 'Soft', NULL)


CREATE TABLE  Movies   
(
	Id INT PRIMARY KEY NOT NULL,
	Title VARCHAR(30) NOT NULL,
	DirectorId INT NOT NULL,
	CopyrightYear INT NOT NULL,
	[Length] INT NOT NULL,
	GenreId INT NOT NULL,
	CategoryId INT NOT NULL,
	Rating INT NOT NULL,
	Notes VARCHAR(MAX)
)


INSERT INTO Movies (Id, Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes)
VALUES (1, 'Oskar', 1, 2021, 130, 1, 1, 9, NULL),
       (2, 'Oskar', 2, 2021, 130, 2, 2, 9, NULL),
       (3, 'Oskar', 3, 2021, 130, 3, 3, 9, NULL),
       (4, 'Oskar', 4, 2021, 130, 4, 4, 9, NULL),
       (5, 'Oskar', 5, 2021, 130, 5, 5, 9, NULL)

