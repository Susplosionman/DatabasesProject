CREATE OR ALTER PROCEDURE Movie.RetrieveReviewsForUser
	@UserID INT
AS

SELECT R.Rating, R.Comment, M.[Name] AS MovieName, D.[Name] AS DirectorName, R.ReviewID
FROM Movie.[User] U
JOIN Movie.Review R ON U.UserID = R.UserID
JOIN Movie.Movie M ON M.MovieID = R.MovieID
JOIN Movie.Director D ON M.DirectorID = D.DirectorID
WHERE U.UserID = @UserID

GO

