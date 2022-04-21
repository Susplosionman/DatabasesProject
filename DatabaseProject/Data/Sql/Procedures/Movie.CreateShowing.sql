CREATE OR ALTER PROCEDURE Movie.CreateShowing
	@ShowTime DATETIMEOFFSET,
	@TicketPrice FLOAT,
	@MovieID INT,
	@ShowingID INT OUTPUT
AS

INSERT Movie.Showing(ShowingTime, TicketPrice, MovieID)
VALUES(@ShowingTime, @TicketPrice, @MovieID);

SET @ShowingID = SCOPE_IDENTITY();
GO