CREATE OR ALTER PROCEDURE Movie.DeleteReview
	@ReviewID INT
AS

DELETE FROM Movie.Review
WHERE ReviewID = @ReviewID;

GO
