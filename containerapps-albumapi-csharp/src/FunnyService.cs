namespace AlbumAPI;

public class FunnyService
{
    public string GetFunnyAlbums()
    {
        var albums = Album.GetAll();
        var albumsString = string.Empty;
        foreach (var album in albums)
        {
            albumsString += $"Album: {album.Title} by {album.Artist} is a great album!\n";
        }
        return albumsString;
    }
}