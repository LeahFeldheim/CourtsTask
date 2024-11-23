using System;
using CourtsTaskAPI.Models;

namespace CourtsTaskAPI.Interface;

public interface IAuditService
{
 Task<bool> LogActionAsync(AuditLogModel log);
    Task<List<AuditLogModel>> GetChangeLogsAsync(int entityId);
}
