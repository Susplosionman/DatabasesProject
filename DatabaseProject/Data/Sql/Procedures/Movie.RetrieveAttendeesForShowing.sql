CREATE OR ALTER PROCEDURE Movie.RetrieveAttendeesForShowing
	@ShowingID INT
AS

SELECT *
FROM Movie.ShowingAttendance SA
WHERE ShowingID = @ShowingID
GO

