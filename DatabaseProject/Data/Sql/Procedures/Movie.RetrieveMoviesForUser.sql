CREATE OR ALTER PROCEDURE Movie.RetrieveMoviesForUser
	@UserID INT
AS

SELECT M.[Name], D.[Name], M.Genre, M.ReleaseDate 
FROM Movie.ShowingAttendance SA
JOIN Movie.Showing S ON S.ShowingID = SA.ShowingID
JOIN Movie.Movie M ON M.MovieID = S.MovieID
JOIN Movie.Director D ON D.DirectorID = M.DirectorID
WHERE SA.UserID = @UserID
GROUP BY M.MovieID, M.[Name], M.ReleaseDate, M.Genre, M.DirectorID, D.[Name]

GO






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

