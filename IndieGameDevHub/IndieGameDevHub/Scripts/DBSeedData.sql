USE [IndieGameDeveloperHub]
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
	'Lara'
	, 'Croft'
	, 'Crystal Dynamics'
	, 'London'
	, 'www.square-enix.com'
	, 'lara@tombraider.com'
	),
	(
	'Solid'
	, 'Snake'
	, 'Konami'
	, 'Shadow Moses Island'
	, 'www.metalgear.com'
	, 'snake@kojima.com'
	)
GO

-- Data for Login table
INSERT INTO Logins 
	(
	[User]
	, [Password]
	, DeveloperDeveloperId) 
VALUES 
	(
	'anfer'
	, 'anfer123'
	, 1
	),
	(
	'lara'
	, 'lara123'
	, 2
	),
	(
	'solid'
	, 'solid123'
	, 3
	)
GO

-- Data for projects table
INSERT INTO Projects 
	(
	Title
	, Genre
	, Engine
	, EsrbRating
	, DimensionType
	, [Description]
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
	'Race to the future'
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
	, 'Solve mysteries in the mystical land of Eldoria'
	, '2023-07-01'
	, '2024-11-15'
	, 'active'
	),
	(
	'God of Hugs'
	, 'Action'
	, 'GML2'
	, 'M'
	, 'VR'
	, 'Hug your way out of the underworld'
	, '2021-06-01'
	, '2024-11-15'
	, 'active'
	),
	(
	'Cyperpunkies 3099'
	, 'FPS'
	, 'In-House'
	, 'T'
	, 'AR'
	, 'Get to live the future now'
	, '2022-03-11'
	, '2027-10-17'
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
