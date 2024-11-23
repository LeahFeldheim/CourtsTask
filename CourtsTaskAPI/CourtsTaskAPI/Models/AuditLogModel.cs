using System;

namespace CourtsTaskAPI.Models;

public class AuditLogModel
{
 public int AuditId { get; set; }
    public string? Action { get; set; }
    public string? PerformedBy { get; set; }
    public DateTime ActionDate { get; set; }
    public string? Details { get; set; }
}

