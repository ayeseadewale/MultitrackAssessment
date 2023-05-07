CREATE PROCEDURE [dbo].[GetArtistDetails]
AS
BEGIN
	SELECT Artist.biography AS artistBio, Artist.imageURL AS artistImage, Artist.heroURL AS artistheroUrl, Artist.title AS artistTitle,Artist.artistID AS artistId,
	Song.title AS songTitle, Song.bpm As songBpm, Album.title As albumTitle, Album.imageURL As albumImage
	FROM Artist
	JOIN Song ON Artist.artistID = Song.artistID
	JOIN Album ON Song.albumID = Album.albumID
	ORDER BY Album.dateCreation DESC
END