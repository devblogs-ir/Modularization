namespace Design.Cohesion.TemporalCohesion;

using System.Timers;
/// <summary>
/// Temporal cohesion is a type of cohesion where elements or tasks are grouped together in a module based on their timing or frequency of execution. 
/// Scheduled maintenance tasks are used to keep systems running smoothly.
/// Here is an example that demonstrates temporal cohesion in a maintenance module
/// The Timer object is set to run the CleanUpTempFiles, DefragmentHardDrive, and UpdateSoftware methods every intervalInDays days.
/// </summary>
public class TemporalCohesion
{
    public void CleanUpTempFiles()
    {
        // Clean up temp files logic
        Console.WriteLine("Temporary files cleaned up successfully");
    }

    public void DefragmentHardDrive()
    {
        // Defragment hard drive logic
        Console.WriteLine("Hard drive defragmented successfully");
    }

    public void UpdateSoftware()
    {
        // Update software logic
        Console.WriteLine("Software updated successfully");
    }

    public void ScheduleMaintenance(int intervalInDays)
    {
        // Schedule maintenance logic
        Timer timer = new(intervalInDays * 24 * 60 * 60 * 1000);
        timer.Elapsed += (sender, e) =>
        {
            CleanUpTempFiles();
            DefragmentHardDrive();
            UpdateSoftware();
        };
        timer.Start();
        Console.WriteLine("Maintenance scheduled every " + intervalInDays + " days");
    }
}