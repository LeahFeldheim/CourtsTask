using System;
using CourtsTaskAPI.Interface;
using CourtsTaskAPI.Models;

namespace CourtsTaskAPI.Service;

public class SearchService : ISearchService
{
    public async Task<List<TikModel>> IndexCasesAsync()
    {
        // לוגיקה לאינדוקס תיקים
        return await Task.FromResult(new List<TikModel>());
    }

    public async Task<List<TikModel>> AdvancedSearchAsync(SearchCriteriaModel criteria)
    {
        // לוגיקה לחיפוש מתקדם
        return await Task.FromResult(new List<TikModel>());
    }

}