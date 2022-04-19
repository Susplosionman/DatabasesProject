IF OBJECT_ID(N'Movie.ShowingAttendance') IS NULL
BEGIN
	CREATE TABLE Movie.ShowingAttendance
	(
		UserID INT NOT NULL
			REFERENCES Movie.[User](UserID),
		ShowingID INT NOT NULL
			REFERENCES Movie.Showing(ShowingID)

		PRIMARY KEY(UserID,ShowingID)
		
	);
END;