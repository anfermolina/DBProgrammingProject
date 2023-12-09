USE [master]

IF EXISTS (
    SELECT *
    FROM sys.databases
    WHERE name = 'IndieGameDeveloperHub'
)
BEGIN
    DROP Database [IndieGameDeveloperHub]
END
GO

CREATE DATABASE [IndieGameDeveloperHub]
GO

USE [IndieGameDeveloperHub]
GO

-- Drop existing tables if they exist
DROP TABLE IF EXISTS ProjectContributors
DROP TABLE IF EXISTS Projects
DROP TABLE IF EXISTS Developers
DROP TABLE IF EXISTS Logins
GO

-- Developer Table
CREATE TABLE Developers(
    [DeveloperId] INT IDENTITY(1,1) NOT NULL,
    [FirstName] VARCHAR(50) NOT NULL,
    [LastName] VARCHAR(50) NOT NULL,
    [StudioName] VARCHAR(255),
    [Location] VARCHAR(50) NOT NULL,
    [Website] VARCHAR(50),
    [Email] VARCHAR(50) NOT NULL,
    CONSTRAINT [PK_Developers] PRIMARY KEY CLUSTERED ([DeveloperId])
)
GO

-- Login Table
CREATE TABLE Logins(
    [LoginId] INT IDENTITY(1,1) NOT NULL,
    [User] VARCHAR(50) NOT NULL,
    [Password] VARCHAR(50) NOT NULL,
    [DeveloperDeveloperId] INT,
    CONSTRAINT [PK_Logins] PRIMARY KEY CLUSTERED ([LoginId]),
	CONSTRAINT [FK_Logins_Developers] FOREIGN KEY ([DeveloperDeveloperId]) REFERENCES Developers([DeveloperId])
)
GO


-- Project Table
CREATE TABLE Projects(
    [ProjectId] INT IDENTITY(1,1) NOT NULL,
    [Title] VARCHAR(50) NOT NULL,
    [Genre] VARCHAR(50) NOT NULL,
    [Engine] VARCHAR(50) NOT NULL,
    [EsrbRating] VARCHAR(50) NOT NULL,
    [DimensionType] VARCHAR(15) NOT NULL,
    [Description] VARCHAR(255) NOT NULL,
    [StartDate] DATE NOT NULL,
    [EstimatedCompletionDate] DATE NOT NULL,
    [StatusOfTheProject] VARCHAR(15) NOT NULL,
    CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED ([ProjectId])
)
GO

-- ProjectContributors Table
CREATE TABLE ProjectContributors(
    [DeveloperDeveloperId] INT NOT NULL,
    [ProjectProjectId] INT NOT NULL,
    [ContributionId] INT IDENTITY(1,1) NOT NULL,
    [Role] VARCHAR(50) NOT NULL,
    [StartDate] DATE NOT NULL,
    [EndDate] DATE,
    CONSTRAINT [PK_ProjectContributors] PRIMARY KEY CLUSTERED ([ContributionId]),
    CONSTRAINT [FK_ProjectContributors_Developers] FOREIGN KEY ([DeveloperDeveloperId]) REFERENCES Developers([DeveloperId]),
    CONSTRAINT [FK_ProjectContributors_Projects] FOREIGN KEY ([ProjectProjectId]) REFERENCES Projects([ProjectId])
)
GO

-- Data for Developers Table
INSERT INTO Developers 
	(
	FirstName
	, LastName
	, StudioName
	, [Location]
	, Website
	, Email) 
VALUES 
	(
	'Anfer'
	, 'Retro'
	, 'PixelDreams'
	, 'Moncton'
	, 'www.pixeldreams.com'
	, 'anfer@pixeldreams.com'
	),

	(
	'Sam'
	, 'Quest'
	, 'EpicVentures'
	, 'New York'
	, 'www.epicventures.com'
	, 'sam@epicventures.com'
	),
	(
	'Eva'
	, 'Blade'
	, 'FutureRealms'
	, 'Austin'
	, 'www.futurerealms.com'
	, 'eva@futurerealms.com'
	)
GO

INSERT INTO Logins 
	(
	[User]
	, [Password]
	, DeveloperDeveloperId) 
VALUES 
	(
	'alexretro'
	, 'password123'
	, 1
	),
	(
	'samquest'
	, 'epicpass456'
	, 2
	),
	(
	'evablade'
	, 'realm789'
	, 3
	)
GO

INSERT INTO Projects 
	(
	Title
	, Genre
	, Engine
	, EsrbRating
	, DimensionType
	, Description
	, StartDate
	, EstimatedCompletionDate
	, StatusOfTheProject
	) 
VALUES 
	(
	'AdventureQuest'
	, 'RPG'
	, 'Unreal Engine'
	, 'E'
	, '3D'
	, 'An epic role-playing adventure set in a fantasy world'
	, '2021-01-01'
	, '2023-12-31'
	, 'active'
	),
	(
	'CyberRacer'
	, 'Racing'
	, 'Unity'
	, 'E10+'
	, '2D'
	, 'Futuristic racing game with cybernetic enhancements'
	, '2022-02-15'
	, '2024-06-30'
	, 'inactive'
	),
	(
	'Mystery of Eldoria'
	, 'Adventure'
	, 'Godot'
	, 'T'
	, '2.5D'
	, 'Solve mysteries in the mystical land of Eldoria.'
	, '2021-06-01'
	, '2024-11-15'
	, 'active'
	)
GO

INSERT INTO ProjectContributors 
	(
	DeveloperDeveloperId
	, ProjectProjectId
	, [Role]
	, StartDate
	, EndDate
	) 
VALUES 
	(
	1
	, 1
	, 'Lead Developer'
	, '2021-01-01'
	, NULL
	),
	(
	2
	, 2
	, 'Game Designer'
	, '2022-02-15'
	, NULL
	),
	(
	3
	, 3, 
	'Art Director'
	, '2021-06-01'
	, '2023-11-15'
	)
GO



