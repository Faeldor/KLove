--CHANGE USING STATEMENT
USE [JWR_KLove]
GO

--CREATE NECESSARY TABLES FOR THIS PROJECT
IF EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[KLove_Department]', 'U'))
BEGIN
	IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS  WHERE CONSTRAINT_NAME ='KLove_EmployeeKLove_DepartmentId_fk')
	BEGIN
		ALTER TABLE [dbo].[KLove_Employee]
			DROP CONSTRAINT KLove_EmployeeKLove_DepartmentId_fk
	END

	DROP TABLE [dbo].[KLove_Department]
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[KLove_Department]', 'U'))
BEGIN
	CREATE TABLE [dbo].[KLove_Department](	
	[Id] 					int IDENTITY(1,1) NOT NULL,
	[Name]					varchar(100),
	[Active]				bit NOT NULL DEFAULT(0),
	[CreatedBy]				varchar(100),
	[Created]				datetime NOT NULL DEFAULT GETDATE(),
	[LastModifiedBy]		varchar(100),
	[LastModified]			datetime NOT NULL
	CONSTRAINT KLove_Department_pk PRIMARY KEY (Id),
	) ON [PRIMARY]
	PRINT '** ' + CONVERT(VARCHAR(30), GETDATE(), 121) + ' - Added KLove_Department table.';
END
GO

IF EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[KLove_Employee]', 'U'))
BEGIN
	
	DROP TABLE [dbo].[KLove_Employee]
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[KLove_Employee]', 'U'))
BEGIN
	CREATE TABLE [dbo].[KLove_Employee](	
	[Id] 					bigint IDENTITY(1,1) NOT NULL,
	[FirstName]				varchar(100) NULL,
	[LastName]				varchar(100) NULL,
	[StreetAddress]			varchar(100) NULL,
	[City]					varchar(100) NULL,
	[State]					varchar(10) NULL,
	[ZipCode]				varchar(10) NULL,
	[EmailAddress]			varchar(150) NULL,
	[PhoneNumber]			varchar(15) NULL,
	[Klove_DepartmentId]	int NOT NULL,
	[Active]				bit NOT NULL DEFAULT(0),
	[CreatedBy]				varchar(100),
	[Created]				datetime NOT NULL DEFAULT GETDATE(),
	[LastModifiedBy]		varchar(100),
	[LastModified]			datetime NOT NULL
	CONSTRAINT [KLove_Employee_pk] PRIMARY KEY (Id),
	CONSTRAINT KLove_EmployeeKLove_DepartmentId_fk FOREIGN KEY (Klove_DepartmentId) REFERENCES [dbo].[KLove_Department](Id),
	) ON [PRIMARY]
	 
	PRINT '** ' + CONVERT(VARCHAR(30), GETDATE(), 121) + ' - Added [KLove_Employee] table.';
END
GO

--SEED THE DATA
--DEPARTMENTS
INSERT INTO dbo.KLove_Department
	([Name], [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('HR', 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Department
	([Name], [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('Accounting', 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Department
	([Name], [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('Engineering', 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Department
	([Name], [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('Pastoral Staff', 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Department
	([Name], [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('Missionaries', 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Employee
	(FirstName, LastName, StreetAddress, City, [State], ZipCode, EmailAddress, PhoneNumber, Klove_DepartmentId, [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('John', 'Risoen', '212 Baldwin Ave', 'Roseville', 'Ca', '95678', 'faeldor@gmail.com', '916-342-4716', (SELECT Id FROM dbo.KLove_Department WHERE [Name] = 'Engineering'), 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Employee
	(FirstName, LastName, StreetAddress, City, [State], ZipCode, EmailAddress, PhoneNumber, Klove_DepartmentId, [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('Nancy', 'Shafer', '123 Fake St', 'Rocklin', 'Ca', '95661', 'NShafer@kloveair1.com', '', (SELECT Id FROM dbo.KLove_Department WHERE [Name] = 'HR'), 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Employee
	(FirstName, LastName, StreetAddress, City, [State], ZipCode, EmailAddress, PhoneNumber, Klove_DepartmentId, [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('Bryon', 'McIntyre', '456 Not A Real Rd', 'Santa Clara', 'Ca', '95911', '', '', (SELECT Id FROM dbo.KLove_Department WHERE [Name] = 'Engineering'), 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Employee
	(FirstName, LastName, StreetAddress, City, [State], ZipCode, EmailAddress, PhoneNumber, Klove_DepartmentId, [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('Kerri', 'Fischer', '400 A Galaxy Far Far Away', 'Alderaan', 'Ca', '67354', '', '', (SELECT Id FROM dbo.KLove_Department WHERE [Name] = 'Accounting'), 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Employee
	(FirstName, LastName, StreetAddress, City, [State], ZipCode, EmailAddress, PhoneNumber, Klove_DepartmentId, [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('Han', 'Solo', '743 Millenium Falcon', 'Space', 'Ga', '71717', '', '', (SELECT Id FROM dbo.KLove_Department WHERE [Name] = 'Missionaries'), 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Employee
	(FirstName, LastName, StreetAddress, City, [State], ZipCode, EmailAddress, PhoneNumber, Klove_DepartmentId, [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('Shelley', 'Marie', '800 Gibson Dr', 'Roseville', 'Ca', '95678', '', '', (SELECT Id FROM dbo.KLove_Department WHERE [Name] = 'HR'), 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Employee
	(FirstName, LastName, StreetAddress, City, [State], ZipCode, EmailAddress, PhoneNumber, Klove_DepartmentId, [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('Luke', 'SkyWalker', '1 Planet No One Can Find Blvd', 'Big Blueville', 'Ca', '95678', '', '', (SELECT Id FROM dbo.KLove_Department WHERE [Name] = 'Pastoral Staff'), 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Employee
	(FirstName, LastName, StreetAddress, City, [State], ZipCode, EmailAddress, PhoneNumber, Klove_DepartmentId, [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('Mace', 'Windu', 'The Only Purple Saber St', 'Sacramento', 'Ca', '56437', '', '', (SELECT Id FROM dbo.KLove_Department WHERE [Name] = 'Pastoral Staff'), 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())

INSERT INTO dbo.KLove_Employee
	(FirstName, LastName, StreetAddress, City, [State], ZipCode, EmailAddress, PhoneNumber, Klove_DepartmentId, [Active], CreatedBy, Created, LastModifiedBy, LastModified)
VALUES
	('Obi Wan', 'Kenobi', 'A Dirt Hut', 'The Dessert', 'Nv', '10101', '', '', (SELECT Id FROM dbo.KLove_Department WHERE [Name] = 'Missionaries'), 1, 'KLove_Script', GETDATE(), 'KLove_Script', GETDATE())