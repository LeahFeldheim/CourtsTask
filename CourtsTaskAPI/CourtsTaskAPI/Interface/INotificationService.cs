using System;
using CourtsTaskAPI.Models;

namespace CourtsTaskAPI.Interface;

public interface INotificationService
{
    Task<bool> SendEmailAsync(string email);
    Task<bool> SendSmsAsync(string sms);
    Task<bool> SendSystemNotificationAsync(NotificationModel notification);

}
