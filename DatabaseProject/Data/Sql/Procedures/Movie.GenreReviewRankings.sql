CREATE OR ALTER PROCEDURE Movie.GenreReviewRankings
	@Genre NVARCHAR(64)
AS

WITH Aggregates([Name], AvgRating) AS
(
	SELECT M.[Name], CAST(SUM(R.Rating) AS DECIMAL (4,2))/ COUNT(*) OVER (PARTITION BY M.MovieID) AS AvgRating
	FROM Movie.Movie M
		INNER JOIN Movie.Review R ON R.MovieID = M.MovieID
	WHERE M.Genre = @Genre
	GROUP BY M.MovieID, M.[Name]
)
SELECT RANK() OVER (ORDER BY AvgRating DESC) AS [Rank], A.[Name], A.AvgRating
FROM Aggregates A
GO
