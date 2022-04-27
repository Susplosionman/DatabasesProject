CREATE OR ALTER PROCEDURE Movie.RetrieveRecentShowingStats
	@FirstDate DATETIMEOFFSET,
	@LastDate DATETIMEOFFSET
AS 

WITH Aggregates(ShowingID, ShowTime, MovieID, TicketSales) AS
(
	SELECT S.ShowingID, S.ShowTime, S.MovieID, (COUNT(*) * S.TicketPrice) AS TicketSales 
	FROM Movie.Showing S
		INNER JOIN Movie.ShowingAttendance SA ON SA.ShowingID = S.ShowingID
	WHERE S.ShowTime BETWEEN @FirstDate AND @LastDate
	GROUP BY S.ShowingID, S.ShowTime, S.MovieID, S.TicketPrice
)

SELECT A.ShowTime, M.[Name] AS MovieName, A.TicketSales, CAST(SUM(R.Rating) AS DECIMAL(16,2)) / COUNT(*) OVER (PARTITION BY M.MovieID) AS AverageReview
FROM Aggregates A
	INNER JOIN Movie.Movie M ON M.MovieID = A.MovieID
	INNER JOIN Movie.Review R ON R.MovieID = M.MovieID
GROUP BY A.ShowTime, M.[Name], A.TicketSales, M.MovieID
ORDER BY A.ShowTime DESC

GO