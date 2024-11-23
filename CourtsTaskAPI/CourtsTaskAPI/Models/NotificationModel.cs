using System;

namespace CourtsTaskAPI.Models;

public class NotificationModel
{
    public int NotificationId { get; set; }
    public string? Message { get; set; }
    public string? Type { get; set; } // דוגמה: Email, SMS, System
    public DateTime SentDate { get; set; }
    public int UserId { get; set; } // למי נשלחה ההתראה
}
