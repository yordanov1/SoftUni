CREATE TABLE Students
(
	StudentID INT IDENTITY PRIMARY KEY,
	[Name] VARCHAR(30)
)

CREATE TABLE Exams
(
	ExamID INT IDENTITY(101, 1) PRIMARY KEY,
	[Name] VARCHAR(30)
)


INSERT INTO Students VALUES 
	('Mila'),
	('Toni'),
	('Ron')

INSERT INTO Exams VALUES 
	('SpringMVC'),
	('Neo4j'),
	('Oracle 11g')


CREATE TABLE StudentsExams
(
	StudentID INT REFERENCES Students(StudentID),
	ExamID INT REFERENCES Exams(ExamID)
	--CONSTRAINT PK_StudentsExams
	PRIMARY KEY (StudentID, ExamID)
)
