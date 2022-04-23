CREATE or ALTER PROCEDURE Movie.FetchSpecificShowing
	@MovieName NVARCHAR(64)
AS

SELECT S.ShowingID, S.ShowTime, S.TicketPrice, S.MovieID
FROM Movie.Showing S
	INNER JOIN Movie.[Movie] M ON M.MovieID = S.MovieID
WHERE M.Name = @MovieName
GROUP BY S.ShowingID, S.ShowTime, S.TicketPrice, S.MovieID
GO