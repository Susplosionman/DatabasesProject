CREATE OR ALTER PROCEDURE Movie.CreateDirector
	@Name NVARCHAR(64),
	@DirectorID INT OUTPUT
AS

INSERT Movie.Director([Name])
VALUES(@Name);

SET @DirectorID = SCOPE_IDENTITY();
GO