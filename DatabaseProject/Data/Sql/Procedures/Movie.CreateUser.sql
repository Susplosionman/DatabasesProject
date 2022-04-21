CREATE OR ALTER PROCEDURE Movie.CreateUser
	@Type NVARCHAR(64),
	@Username NVARCHAR(64),
	@Password NVARCHAR(64),
	@UserID INT OUTPUT
AS

INSERT Movie.[User]([Type], Username, [Password])
VALUES(@Type, @Username, @Password);

SET @UserID = SCOPE_IDENTITY();
GO
