CREATE OR ALTER PROCEDURE Movie.GetAvgReviewForMovie
	@MovieID INT
AS

SELECT IIF(COUNT(R.ReviewID) IS NOT NULL, CAST(SUM(R.Rating) AS DECIMAL(16,2))/COUNT(R.ReviewID), 0) AS AvgRatingForMovie
FROM Movie.Movie M
	INNER JOIN Movie.Review R ON R.MovieID = M.MovieID
WHERE M.MovieID = @MovieID
GO