﻿CREATE OR ALTER PROCEDURE Movie.GetDistinctGenres
AS
SELECT DISTINCT M.Genre
FROM Movie.Movie M
GO