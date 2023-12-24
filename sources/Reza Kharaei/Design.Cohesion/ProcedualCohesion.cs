namespace Design.Cohesion.ProcedualCohesion;

/* 
    Description: 
    this is fourth File.
    It is recommended to check the third file (CommunicationCohesion.cs) before reading this file 
*/


public record UserDto(string FullName, string Password, string Mobile);

public class UserEntity
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Mobile { get; set; }
}


public class UserService
{
    public async Task<UserEntity?> FindUserByUsername(string username)
    {
        return new UserEntity { }; // find and reurn entity from database
    } 

    public async Task<bool> UpdateInfo(UserEntity user, UserDto request)
    {
        // 1. Initialization of fields (you can use AutoMapper)
        user.FullName = request.FullName;
        user.Password = request.Password;
        user.Mobile = request.Mobile;

        // 2. Save changes in database
        
        // 3. Return Result
        return true;
    }

    public void SendNotification(string strMobileNumber, string NotificationText)
    {
        // Todo : send sms for notification
    }

    public async Task ChangePassword(string username, string oldPassword, string newPassword)
    {
        var entity = await FindUserByUsername(username);
        if (entity is null)
            throw new Exception("User not found!");

        var newRequest = new UserDto(entity.FullName, newPassword, entity.Mobile);
        var ChangepasswordResult = await UpdateInfo(entity, newRequest);

        if (ChangepasswordResult)
            SendNotification(entity.Mobile, "your password changed!");
    }
}

/*
    Description: 
    In the ChangePassword method, if the entity is not null, the UpdateInfo method is called, 
    and if the UpdateInfo result is true, the SendNotification method is called.
*/