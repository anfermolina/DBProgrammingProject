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




