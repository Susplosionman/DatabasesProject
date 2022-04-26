﻿IF OBJECT_ID(N'Movie.Director') IS NULL
BEGIN
	CREATE TABLE Movie.Director
	(
		DirectorID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		[Name] NVARCHAR(64) NOT NULL
	
		UNIQUE
		(
			[Name]
		)

	);
END;