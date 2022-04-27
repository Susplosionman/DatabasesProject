IF OBJECT_ID(N'Movie.Showing') IS NULL
BEGIN
	CREATE TABLE Movie.Showing
	(
		ShowingID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ShowTime DATETIMEOFFSET NOT NULL,
		TicketPrice INT NOT NULL, -- want this to be DECIMAL(4,2)
		MovieID INT NOT NULL
			REFERENCES Movie.Movie(MovieID)
	);
END;