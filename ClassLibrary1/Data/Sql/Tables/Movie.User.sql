﻿IF OBJECT_ID(N'Movie.User') IS NULL
BEGIN
	CREATE TABLE Movie.[User]
	(
		UserID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		[Type] NVARCHAR(64) NOT NULL,
		Username NVARCHAR(64) NOT NULL,
		[Password] NVARCHAR(64) NOT NULL,

		UNIQUE
			(
				Username
			)
	);
END;