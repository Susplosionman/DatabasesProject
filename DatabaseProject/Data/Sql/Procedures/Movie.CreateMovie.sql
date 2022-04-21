CREATE OR ALTER PROCEDURE Movie.CreateMovie
	@Name NVARCHAR(64),
	@ReleaseDate DATETIMEOFFSET,
	@Genre NVARCHAR(64),
	@DirectorID INT,
	@MovieID INT OUTPUT
AS

INSERT Movie.Movie([Name], ReleaseDate, Genre, DirectorID)
VALUES(@Name,@ReleaseDate,@Genre,@DirectorID);

SET @MovieID = SCOPE_IDENTITY();
GO