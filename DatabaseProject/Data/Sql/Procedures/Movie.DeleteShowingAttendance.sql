CREATE OR ALTER PROCEDURE Movie.DeleteShowingAttendance
	@ShowingID INT
AS

DELETE FROM Movie.ShowingAttendance
WHERE ShowingID = @ShowingID;

GO

