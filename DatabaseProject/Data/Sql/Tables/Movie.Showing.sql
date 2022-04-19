IF OBJECT_ID(N'Movie.Showing') IS NULL
BEGIN
	CREATE TABLE Movie.Showing
	(
		ShowingID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
		ShowTime DATETIMEOFFSET NOT NULL,
		TicketPrice FLOAT(4,2) NOT NULL, -- 4 digits, 2 after the decimal point -> XX.YY
		MovieID INT NOT NULL
			REFERENCES Movie.Movie(MovieID)
	);
END;