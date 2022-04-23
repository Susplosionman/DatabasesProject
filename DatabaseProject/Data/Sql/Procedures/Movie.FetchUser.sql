CREATE or ALTER PROCEDURE Movie.FetchUser
	@UserName NVARCHAR(64)
AS

SELECT *
FROM Movie.[User] U
WHERE U.UserName = @UserName
GO

