CREATE TABLE Users
(
Id BIGINT PRIMARY KEY IDENTITY
)

ALTER TABLE Users
ADD Username VARCHAR(30) NOT NULL

ALTER TABLE Users
ADD [Password] VARCHAR(26) NOT NULL

ALTER TABLE Users
ADD ProfilePicture VARCHAR(MAX) 

ALTER TABLE Users
ADD LastLoginTime DATETIME

ALTER TABLE Users
ADD IsDeleted BIT



INSERT INTO Users
(Username, [Password], ProfilePicture, LastLoginTime, IsDeleted)
VALUES
('sdf', '123', 'https://images.news18.com/ibnlive/uploads/2021/06/1622715559_disha.jpg', '4/4/2021', 0),
('zxcv', '123', 'https://images.news18.com/ibnlive/uploads/2021/06/1622715559_disha.jpg', '5/4/2021', 1),
('dfgh', '234', 'https://images.news18.com/ibnlive/uploads/2021/06/1622715559_disha.jpg', '6/4/2021', 1),
('zxcv', '123', 'https://images.news18.com/ibnlive/uploads/2021/06/1622715559_disha.jpg', '5/4/2021', 0),
('zxcv', '123', 'https://images.news18.com/ibnlive/uploads/2021/06/1622715559_disha.jpg', '5/4/2021', 0)