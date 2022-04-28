CREATE OR ALTER PROCEDURE Movie.UpdateShowing
	@ShowingID INT,
	@ShowTime DATETIMEOFFSET,
	@TicketPrice INT,
	@MovieID INT

AS

UPDATE Movie.Showing
SET 
	ShowTime = @ShowTime,
	TicketPrice = @TicketPrice,
	MovieID = @MovieID
WHERE ShowingID = @ShowingID;

GO