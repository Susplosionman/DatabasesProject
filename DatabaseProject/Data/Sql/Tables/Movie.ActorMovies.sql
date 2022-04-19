IF OBJECT_ID(N'Movie.ActorMovies') IS NULL
BEGIN
	CREATE TABLE Movie.ActorMovies
	(
		ActorID INT NOT NULL
			REFERENCES Movie.Actor(ActorID),
		MovieID INT NOT NULL
			REFERENCES Movie.Movie(MovieID)

		PRIMARY KEY(ActorID,MovieID)
		
	);
END;