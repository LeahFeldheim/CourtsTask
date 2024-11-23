using System;

namespace CourtsTaskAPI.Models;

public class SearchCriteriaModel
{
    public string? CaseName { get; set; }
    public string? Status { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public string? AssignedTo { get; set; }
}
