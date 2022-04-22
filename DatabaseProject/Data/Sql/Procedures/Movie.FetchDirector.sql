CREATE OR ALTER PROCEDURE Movie.FetchDirector
   @Name NVARCHAR(64)
AS

SELECT *
FROM Movie.Director D
WHERE D.[Name] = @Name
GO
