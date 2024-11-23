using System;
using CourtsTaskAPI.Models;

namespace CourtsTaskAPI.Interface;

public interface ICaseService
{
    Task<int> OpenCaseAsync(TikModel tikModel);
    Task<bool> UpdateCaseStatusAsync(int tikId, string status);
    Task<bool> ManageDecisionsAsync(int tikId, List<string> decisions);
    Task<bool> ManageIntermediateRequestsAsync(int tikId, List<string> requests);
}
