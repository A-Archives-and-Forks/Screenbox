using System.Collections.Generic;
using Screenbox.Core.ViewModels;

namespace Screenbox.Core.Models;

/// <summary>
/// The result of a music library fetch operation, ready to be applied to <see cref="Contexts.LibraryContext"/>.
/// </summary>
public sealed class MusicLibraryResult
{
    public MusicLibraryResult(
        List<MediaViewModel> songs,
        Dictionary<string, AlbumViewModel> albums,
        Dictionary<string, ArtistViewModel> artists,
        AlbumViewModel unknownAlbum,
        ArtistViewModel unknownArtist)
    {
        Songs = songs;
        Albums = albums;
        Artists = artists;
        UnknownAlbum = unknownAlbum;
        UnknownArtist = unknownArtist;
    }

    public List<MediaViewModel> Songs { get; }
    public Dictionary<string, AlbumViewModel> Albums { get; }
    public Dictionary<string, ArtistViewModel> Artists { get; }
    public AlbumViewModel UnknownAlbum { get; }
    public ArtistViewModel UnknownArtist { get; }
}
