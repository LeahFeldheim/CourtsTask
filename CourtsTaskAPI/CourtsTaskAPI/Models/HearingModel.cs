using System;

namespace CourtsTaskAPI.Models;

public class HearingModel
{
   public int HearingId { get; set; }
    public DateTime ScheduledDate { get; set; }
    public string? Location { get; set; }
    public string? Participants { get; set; }
    public int TikId { get; set; }
}
