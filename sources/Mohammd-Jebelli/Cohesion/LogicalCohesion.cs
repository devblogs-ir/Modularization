namespace Cohesion.LogicalCohesion
{
    public class MusicPlayer
    {
        private Preferences _preferences;

        public MusicPlayer(Preferences preferences)
        {
            _preferences = preferences;
        }

        public void SetVolume(int volumeLevel)
        {
            // Logic to set the volume level of the music player
            _preferences.volume = volumeLevel;
        }

        public void SetRepeatMode(bool repeat)
        {
            // Logic to set the repeat mode for the music player
            _preferences.repeat = repeat;
        }
    }
    public class Preferences
    {
        public int volume;
        public bool repeat;
    }


}
