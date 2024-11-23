using System;

namespace CourtsTaskAPI.Models;

public class DocumentModel
{
    public int DocumentId { get; set; }
    public string? FileName { get; set; }
    public DateTime UploadDate { get; set; }
    public string? UploadedBy { get; set; }
    public int CaseId { get; set; } // קשר לתיק
    public string? Version { get; set; }
}
