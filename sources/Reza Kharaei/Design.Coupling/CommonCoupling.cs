using System.Text;

namespace Design.Coupling.CommonCoupling;

/* 
    Description: 
    this is sixth File.
    It is recommended to check the fifth file (ExternalCoupling.cs) before reading this file 
*/

public record NotificationDto(string NotificationText);

public class NotificationService
{
    TimeOnly NextReminder = TimeOnly.FromDateTime(DateTime.Now).AddMinutes(10);

    public void SendEmail(NotificationDto request)
    {
        // 1. Send email for notification

        // 2. Set Next Reminder Time
        NextReminder.AddMinutes(10);
    }

    public void SendSMS(NotificationDto request)
    {
        // 1. Send sms for notification

        // 2. Set Next Reminder Time
        NextReminder.AddMinutes(10);
    }
}

/*
    Description: 
    The value of NextReminder is share between SendEmail and SendSMS functions and creates Common Coupling.
*/