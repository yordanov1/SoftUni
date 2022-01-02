CREATE TABLE Majors
(
	MajorID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50)
)


CREATE TABLE Students
(
	StudentID INT PRIMARY KEY IDENTITY,
	StudentNumber INT,
	StudentName NVARCHAR(50),
	MajorID INT 

	CONSTRAINT FK_Majors_Students
	FOREIGN KEY (MajorID)
	REFERENCES Majors(MajorID)
)


CREATE TABLE Subjects
(
	SubjectID INT PRIMARY KEY IDENTITY,
	SubjectName NVARCHAR(50)
)


CREATE TABLE Agenda
(
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	SubjectID INT FOREIGN KEY REFERENCES Subjects(SubjectID)
	CONSTRAINT PK_Student_Subject
	PRIMARY KEY (StudentID, SubjectID)
)



CREATE TABLE Payments
(
	PaymentID INT PRIMARY KEY IDENTITY,
	PaymentDate DATE,
	PaymentAmount DECIMAL(15, 2),
	StudentID INT REFERENCES Students(StudentID)
)



