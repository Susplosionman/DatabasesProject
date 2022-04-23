CREATE OR ALTER PROCEDURE Movie.DeleteShowing
	@ShowingID INT
AS

DELETE FROM Movie.Showing
WHERE ShowingID = @ShowingID;

GO
