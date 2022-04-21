CREATE OR ALTER PROCEDURE Movie.CreateReview
	@Comment NVARCHAR(64),
	@UserID INT,
	@Rating INT,
	@MovieID INT,
	@ReviewID INT OUTPUT
AS

INSERT Movie.Review(UserID, Rating, Comment, MovieID)
VALUES(@UserID, @Rating, @Comment, @MovieID);

SET @ReviewID = SCOPE_IDENTITY();
GO