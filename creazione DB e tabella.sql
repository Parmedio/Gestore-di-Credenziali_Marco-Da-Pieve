CREATE DATABASE CREDENTIALS

CREATE TABLE Users
(
	UserID INT IDENTITY(1,1) PRIMARY KEY,
	UserName VARCHAR(20),
	[Password] VARCHAR(20),
	RegistrationDate VARCHAR(8)
)

 --INSERT INTO Users (UserName, Password, RegistrationDate)
 --VALUES ('Alice', 'p@ssw0rd', CONVERT(varchar(8), GETDATE(), 112));
