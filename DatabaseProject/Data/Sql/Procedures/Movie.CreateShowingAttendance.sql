CREATE OR ALTER PROCEDURE Movie.CreateShowingAttendance
	@UserID INT,
	@ShowingID INT
AS

INSERT Movie.ShowingAttendance(UserID,ShowingID)
VALUES(@UserID,@ShowingID);

SET @ShowingID = SCOPE_IDENTITY();
GO