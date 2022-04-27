CREATE OR ALTER PROCEDURE Movie.GetAvgReviewForMovie
	@MovieID INT
AS

SELECT SUM(R.Rating) / COUNT(*) AS AvgRatingForMovie
FROM Movie.Movie M
	INNER JOIN Movie.Review R ON R.MovieID = M.MovieID
WHERE M.MovieID = @MovieID
GO