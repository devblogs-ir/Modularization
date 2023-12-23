namespace Design.Coupling.ContentCoupling;

/* 
    Description: 
    this is 7th File.
    It is recommended to check the 6th file (CommonCoupling.cs) before reading this file 
*/

public class UserService
{
    public IEnumerable<string> GetUsers()
    {
        return new List<string>();
    }
}

public class NotificationService
{
    public void SendNotification(string username, string NotificatinMessage)
    {
        // Todo : send notification to username
    }
}

public class NotificationController(NotificationService notificationService, UserService userService)
{
    private readonly NotificationService _notificationService = notificationService;
    private readonly UserService _userService = userService;

    public void PostAction()
    {
        var targetUsers = _userService.GetUsers();
        foreach (var user in targetUsers)
            _notificationService.SendNotification(user, $"hello {user}");
        
    }
}

/*
    Description: 
    In this example, it is seen Content Coupling inside the PostAction  
    because the notification sending operation depends on the number of users returned by the GetUsers method.

    # Note:
    in a real project, the above methods should be written in asynchronous format.
*/