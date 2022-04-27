CREATE OR ALTER PROCEDURE Movie.RetrieveReviewsForUser
	@UserID INT
AS

SELECT R.ReviewID, R.Rating, R.Comment, R.MovieID
FROM Movie.[User] U
JOIN Movie.Review R ON U.UserID = R.UserID
WHERE U.UserID = @UserID

GO

