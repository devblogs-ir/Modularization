namespace Design.Coupling.StampCoupling;

/* 
    Description: 
    this is third File.
    It is recommended to check the second file (DataCoupling.cs) before reading this file 
*/

public record NotificationData(string Title, string Message, string strEmailAddress, string strMobileNumber);

public class NotificationService
{
    public void SendEmail(NotificationData request)
    {
        // Todo: send email for notification
    }

    public void SendSMS(NotificationData request)
    {
        // Todo : send sms for notification
    }
}


public class NotificationController(NotificationService notificationService)
{
    private readonly NotificationService _notificationService = notificationService;

    public void PostAction()
    {
        // 1. Do something....

        // 2. Send notification
        var requestData = new NotificationData("my title", "sample message", "none@domain.com", "00000000000");
        _notificationService.SendEmail(requestData);
    }
}

/*
    Description: 
    When calling the SendEmail method in PostAction, there is no need for a mobile number, but we sent it.
*/