﻿IF NOT EXISTS
	(
		SELECT *
		FROM sys.schemas s
		WHERE s.[Name] = N'Movie'
	)
BEGIN
	EXEC(N'CREATE SCHEMA [MOVIE] AUTHORIZATION [dbo]');
END;