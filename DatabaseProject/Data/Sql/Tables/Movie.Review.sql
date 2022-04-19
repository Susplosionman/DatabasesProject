IF OBJECT_ID(N'Movie.Review') IS NULL
BEGIN
	CREATE TABLE Movie.Review
	(
		ReviewID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		UserID INT NOT NULL
			REFERENCES Movie.[User](UserID),
		Rating INT NOT NULL,
		Comment NVARCHAR(64) NOT NULL, -- may have to make this a larger size?
		MovieID INT NOT NULL
			REFERENCES Movie.Movie(MovieID)
	);
END;