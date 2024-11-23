using System;
using CourtsTaskAPI.Interface;
using CourtsTaskAPI.Models;

namespace CourtsTaskAPI.Service;

public class AuditService : IAuditService
{
    public async Task<bool> LogActionAsync(AuditLogModel log)
    {
        // לוגיקה לתיעוד פעולות
        return await Task.FromResult(true);
    }

    public async Task<List<AuditLogModel>> GetChangeLogsAsync(int entityId)
    {
        // לוגיקה לקבלת לוג שינויים
        return await Task.FromResult(new List<AuditLogModel>());
    }
}
