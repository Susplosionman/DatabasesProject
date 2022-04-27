CREATE OR ALTER PROCEDURE Movie.MovieTotalGross
AS

WITH Aggregates(ShowingID, MovieID, GrossSales) AS
(
	SELECT S.ShowingID, S.MovieID, COUNT(SA.ShowingID) * S.TicketPrice AS GrossSales
	FROM Movie.Showing S
		INNER JOIN Movie.ShowingAttendance SA ON SA.ShowingID = S.ShowingID
	GROUP BY S.ShowingID, S.MovieID, S.TicketPrice
)

SELECT M.[Name], M.Genre, M.ReleaseDate, D.[Name], ISNULL(SUM(A.GrossSales),0) AS GrossSales
FROM Movie.Movie M
	INNER JOIN Movie.Director D ON D.DirectorID = M.DirectorID
	INNER JOIN Aggregates A ON A.MovieID = M.MovieID
GROUP BY M.[Name], M.Genre, M.ReleaseDate, D.[Name]
ORDER BY GrossSales DESC

GO