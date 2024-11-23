using System;
using CourtsTaskAPI.Models;

namespace CourtsTaskAPI.Interface;

public interface IUserService
{
 Task<bool> ManageJudgesAsync(List<UserModel> judges);
    Task<bool> ManageClerksAsync(List<UserModel> clerks);
    Task<bool> ManagePermissionsAsync(int userId, List<string> permissions);
}
