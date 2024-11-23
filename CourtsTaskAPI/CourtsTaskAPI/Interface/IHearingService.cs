using System;
using CourtsTaskAPI.Models;

namespace CourtsTaskAPI.Interface;

public interface IHearingService
{
  Task<bool> ScheduleHearingAsync(HearingModel hearing);
    Task<bool> ManageProtocolsAsync(int hearingId, string protocol);
    Task<bool> InviteParticipantsAsync(int hearingId, List<string> participants);
}
