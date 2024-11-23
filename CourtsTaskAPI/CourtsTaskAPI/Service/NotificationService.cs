using System;
using CourtsTaskAPI.Interface;
using CourtsTaskAPI.Models;

namespace CourtsTaskAPI.Service;

public class NotificationService : INotificationService
{
    public async Task<bool> SendEmailAsync(string email)
    {
        // לוגיקה לשליחת מייל
        return await Task.FromResult(true);
    }

    public async Task<bool> SendSmsAsync(string sms)
    {
        // לוגיקה לשליחת SMS
        return await Task.FromResult(true);
    }

    public async Task<bool> SendSystemNotificationAsync(NotificationModel notification)
    {
        // לוגיקה להתראות מערכת
        return await Task.FromResult(true);
    }
}