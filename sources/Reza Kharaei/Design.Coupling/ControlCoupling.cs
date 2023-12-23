namespace Design.Coupling.ControlCoupling;

/* 
    Description: 
    this is fourth File.
    It is recommended to check the third file (StampCoupling.cs) before reading this file 
*/

public record NotificationDto(string strType, string Title, string Message, string strEmailAddress, string strMobileNumber);

public class NotificationService
{
    public void SendNotification(NotificationDto request)
    {
        switch (request.strType)
        {
            case "SMS" :
            {
                // Todo: send sms for notification
                break;
            }
            case "Email":
            {
                // Todo : send email for notification
                break;
            }
        }
    }
}


public class NotificationController(NotificationService notificationService)
{
    private readonly NotificationService _notificationService = notificationService;

    public void PostAction()
    {
        // 1. Do something....

        // 2. Send notification
        var requestData = new NotificationDto("sms", "my title", "sample message", "none@domain.com", "09119314956");
        _notificationService.SendNotification(requestData);
    }
}

/*
    Description: 
    in this example, we controlled the behavior of the SendNotification method from outside it
    #Note: Also, this example includes Stamp Coupling...
*/