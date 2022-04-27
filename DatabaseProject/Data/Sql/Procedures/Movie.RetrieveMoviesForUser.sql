CREATE OR ALTER PROCEDURE Movie.RetrieveMoviesForUser
	@UserID INT
AS

SELECT M.MovieID, M.[Name], M.ReleaseDate, M.Genre, M.DirectorID
FROM Movie.ShowingAttendance SA
JOIN Movie.Showing S ON S.ShowingID = SA.ShowingID
JOIN Movie.Movie M ON M.MovieID = S.MovieID
WHERE SA.UserID = @UserID
GROUP BY M.MovieID, M.[Name], M.ReleaseDate, M.Genre, M.DirectorID

GO

