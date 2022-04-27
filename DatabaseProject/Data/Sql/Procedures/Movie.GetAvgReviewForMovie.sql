CREATE OR ALTER PROCEDURE Movie.GetAvgReviewForMovie
	@MovieID INT
AS

SELECT ISNULL(CAST(SUM(R.Rating) AS DECIMAL(16,2)) / COUNT(*),0) AS AvgRatingForMovie
FROM Movie.Movie M
	INNER JOIN Movie.Review R ON R.MovieID = M.MovieID
WHERE M.MovieID = @MovieID
GO