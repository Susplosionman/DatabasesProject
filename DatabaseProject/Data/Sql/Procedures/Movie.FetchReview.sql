CREATE or ALTER PROCEDURE Movie.FetchReview
	@MovieName NVARCHAR(64)
AS

SELECT R.ReviewID, R.UserID, R.Rating, R.Comment, R.MovieID
FROM Movie.Review R
	INNER JOIN Movie.Movie M ON M.MovieID = R.MovieID
WHERE M.Name = @MovieName
GROUP BY R.ReviewID, R.UserID, R.Rating, R.Comment, R.MovieID
ORDER BY R.Rating DESC
GO