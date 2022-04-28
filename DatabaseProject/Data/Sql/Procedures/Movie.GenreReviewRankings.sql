CREATE OR ALTER PROCEDURE Movie.GenreReviewRankings
	@Genre NVARCHAR(64)
AS

WITH Aggregates([Name], AvgRating) AS
(
	SELECT M.[Name], IIF(COUNT(R.ReviewID) IS NOT NULL, CAST(SUM(R.Rating) AS DECIMAL(16,2))/COUNT(R.ReviewID), 0) AS AvgRating
	FROM Movie.Movie M
		INNER JOIN Movie.Review R ON R.MovieID = M.MovieID
	WHERE M.Genre = @Genre
	GROUP BY M.MovieID, M.[Name]
)
SELECT RANK() OVER (ORDER BY AvgRating DESC) AS [Rank], A.[Name], A.AvgRating
FROM Aggregates A
GO
