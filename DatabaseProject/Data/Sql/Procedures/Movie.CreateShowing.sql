CREATE OR ALTER PROCEDURE Movie.CreateShowing
	@ShowTime DATETIMEOFFSET,
	@TicketPrice INT,
	@MovieID INT,
	@ShowingID INT OUTPUT
AS

INSERT Movie.Showing(ShowTime, TicketPrice, MovieID)
VALUES(@ShowTime, @TicketPrice, @MovieID);

SET @ShowingID = SCOPE_IDENTITY();
GO