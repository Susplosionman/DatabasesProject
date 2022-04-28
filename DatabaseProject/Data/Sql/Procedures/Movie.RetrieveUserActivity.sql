CREATE OR ALTER PROCEDURE Movie.RetrieveUserActivity
	@HighestRank INT
AS

WITH MoviesAttended(UserID, Username, MoviesAttended) AS 
(
	SELECT U.UserID, U.Username, IIF(COUNT(DISTINCT SA.ShowingID) IS NOT NULL, COUNT(DISTINCT SA.ShowingID), 0) AS MoviesAttended
	FROM Movie.[User] U
		LEFT JOIN Movie.ShowingAttendance SA ON SA.UserID = U.UserID
	GROUP BY U.UserID, U.Username
)

SELECT MA.Username, MA.MoviesAttended, IIF(COUNT(R.ReviewID) IS NOT NULL, COUNT(R.ReviewID), 0) AS ReviewCount, RANK() OVER (ORDER BY MA.MoviesAttended DESC, COUNT(*) DESC) AS [Rank]
FROM MoviesAttended MA
	LEFT JOIN Movie.Review R ON R.UserID = MA.UserID
GROUP BY MA.Username, MA.MoviesAttended
ORDER BY [Rank] ASC
OFFSET 0 ROWS
FETCH NEXT @HighestRank ROWS ONLY

GO
