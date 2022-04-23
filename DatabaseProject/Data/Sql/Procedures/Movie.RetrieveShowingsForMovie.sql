CREATE OR ALTER PROCEDURE Movie.RetrieveShowingsForMovie
	@MovieID INT
AS

SELECT *
FROM Movie.Showing
WHERE MovieID = @MovieID
GO

