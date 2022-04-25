CREATE OR ALTER PROCEDURE Movie.GetAvgReviewForMovie
	@MovieID INT
AS

SELECT R.Rating / Count(R.ReviewID) AS AvgRatingForMovie
FROM Movie.Review R
JOIN Movie.Movie M ON M.MovieID = R.MovieID
WHERE M.MovieID = @MovieID
GO

--THIS QUERY IS NOT CORRECT