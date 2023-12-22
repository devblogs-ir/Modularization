using System.Reflection.Metadata;

namespace Cohesion.TemporalCohesion
{
    public class MusicPlayer
    {
        public void ScheduleAlarm(string songId, DateTime time)
        {
            // Logic to schedule an alarm for playing the specified song at the specified time
            // ...
        }

        public void CancelAlarm(string songId)
        {
            // Logic to cancel a scheduled alarm for the specified song
            // ...
        }
    }

}
