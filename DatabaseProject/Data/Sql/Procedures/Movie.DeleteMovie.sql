CREATE OR ALTER PROCEDURE Movie.DeleteMovie
	@MovieID INT
AS

DELETE FROM Movie.Movie
WHERE MovieID = @MovieID;

GO
