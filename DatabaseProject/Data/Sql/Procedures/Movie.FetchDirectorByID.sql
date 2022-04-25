CREATE OR ALTER PROCEDURE Movie.FetchDirectorByID
   @DirectorID INT
AS

SELECT *
FROM Movie.Director D
WHERE D.DirectorID = @DirectorID
GO
