using System;
using CourtsTaskAPI.Interface;
using CourtsTaskAPI.Models;

namespace CourtsTaskAPI.Service;
public class CaseService : ICaseService
{
    public async Task<int> OpenCaseAsync(TikModel tikModel)
    {
        // לוגיקה לפתיחת תיק חדש
        return await Task.FromResult(1); // מחזיר ID של תיק חדש
    }

    public async Task<bool> UpdateCaseStatusAsync(int tikId, string status)
    {
        // לוגיקה לעדכון סטטוס תיק
        return await Task.FromResult(true);
    }

    public async Task<bool> ManageDecisionsAsync(int caseId, List<string> decisions)
    {
        // לוגיקה לניהול החלטות
        return await Task.FromResult(true);
    }

    public async Task<bool> ManageIntermediateRequestsAsync(int caseId, List<string> requests)
    {
        // לוגיקה לניהול בקשות ביניים
        return await Task.FromResult(true);
    }
}