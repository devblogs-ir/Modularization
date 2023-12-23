using System.Text;

namespace Design.Coupling.ExternalCoupling;

/* 
    Description: 
    this is fifth File.
    It is recommended to check the fourth file (ControlCoupling.cs) before reading this file 
*/

public record NotificationDto(string username, string MessageText);

public class NotificationService
{
    public async Task SendNotification(NotificationDto request)
    {
        try
        {
            HttpClient httpClient = new();
            string strJsonData = Newtonsoft.Json.JsonConvert.SerializeObject(request);
            StringContent httpClientContent = new(strJsonData, Encoding.UTF8, "application/json");
            await httpClient.PostAsync("https://domain.com/api/notification", httpClientContent);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex.InnerException);
        }
    }
}


public class NotificationController(NotificationService notificationService)
{
    private readonly NotificationService _notificationService = notificationService;

    public async Task PostAction()
    {
        // 1. Do something....

        // 2. Send notification
        var requestData = new NotificationDto("username", "sample message");
        await _notificationService.SendNotification(requestData);
    }
}

/*
    Description: 
    The functionality of the notification service is dependent on an external service.
*/