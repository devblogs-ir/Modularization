using System.Reflection.Metadata;

namespace Cohesion.SequentialCohesion
{
    public class MusicPlayer
    {
        private List<Song> _songs;
        private int _current;
        public MusicPlayer(List<Song> songs)
        {
            _songs = songs;
        }

        
        public void PlayNextSong()
        {
            // Logic to play the next song in the current playlist
            Play(_current++);
            
        }

        public void PlayPreviousSong()
        {
            // Logic to play the previous song in the current playlist
            Play(_current--);
        }

        public void QueueSong(int songId)
        {
            // Logic to add the specified song to the playback queue
            _songs.Add(new Song() { Id = songId });
        }

        public void Play(int songId)
        {
            // Logic to play song
        }

    }
    public class Song
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }
    }

}
