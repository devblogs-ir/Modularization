using System.Reflection.Metadata;

namespace Cohesion.CommunicationalCohesion
{
    public class MusicPlayer
    {
        public Song GetSongInfo(string songId)
        {
            // Logic to retrieve information about the specified song
            return new Song();  
        }

        public void UpdateSongRating(string songId, string artistName)
        {
            // Logic to update artist name of the specified song
            Song song = GetSongInfo(songId);
            song.SongName = artistName;
        }
    }

    public class Song
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }
    }

}
