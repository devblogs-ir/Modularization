namespace Design.Coupling.DataCoupling;

/* 
    Description: 
    this is Second File.
    It is recommended to check the first file (NoCoupling.cs) before reading this file 
*/

public class NotificationService
{
    public void SendEmail(string Title, string Message, string strEmailAddress)
    {
        // Todo: send email for notification
    }

    public void SendSMS(string strMobileNumber, string Messsage)
    {
        // Todo : send sms for notification
    }
}


public class NotificationController(NotificationService notificationService)
{
    private readonly NotificationService _notificationService = notificationService;

    public void PostAction()
    {
        _notificationService.SendSMS("09112345678", "this is sample message");
    }
}

/*
    Description: 
    If the parameters of the SendSMS method are increased or decreased, the PostAction method will change.
*/